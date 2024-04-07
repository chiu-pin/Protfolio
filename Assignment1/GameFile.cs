using System;
using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Assignment1
{
	public class GameFile
	{

        public int Player_ID { get; set; }
        public char[] CurrentBoard { get; set; }

        public bool ComputerorHuman { get; set; }

        public static void SvaeGameFile(char[] CurrentBoard, int Player_ID, bool computerorhuman){
            string charBoardString = new string(CurrentBoard);
            string filePath = "Lastrecord.txt";

            // 检查文件是否存在，如果不存在则创建文件
            if (!File.Exists(filePath))
            {
                // 创建一个空的文件
                File.Create(filePath).Close();
            }
            string playerType = computerorhuman ? "computer" : "human";
            string textToSave = charBoardString + "|" + Player_ID + "|" + playerType;

            // 将文本追加到文件
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(textToSave);
            }
            Console.WriteLine("Save file sucessful ");
        }
        public static string[] LoadFile()
        {
            string filePath = "Lastrecord.txt";
            string[] context = new string[3]; 
            // 检查文件是否存在
            if (File.Exists(filePath))
            {
                // 读取文件内容
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        context = line.Split('|');
                    }
                }
                
            }
            else
            {
                Console.WriteLine("File not found.");
            }
            return context;
        }

    }
}

