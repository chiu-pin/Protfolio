using System;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment1
{
    public class Board
    {
        public Board()
        {
        }
        public static char[] CreatBoard(int number)
        {
            char[] board = new char[number];
            return board;
        }
        public static bool VaildateMove(char[] board,int position)
        {
            if (board[position] != '\0')
            {
                return false;
            }
            return true;
        }
        public static char[] RecordMovePosition(char[]board, int position)
        {
            board[position] = 'X';
            return board;
        }
        public static void DisplayBoard(char[] board)
        {
            // 打印顶部边界
            Console.Write("   ");
            for (int j = 0; j < board.Length; j++)
            {
                Console.Write("|" + j + "|");
            }
            Console.WriteLine(); // 换行

            // 打印棋盘及其元素
            Console.Write("   ");
            for (int j = 0; j < board.Length; j++)
            {
                if (board[j] == '\0')
                {
                    Console.Write("|" + " " + "|"); // 如果 board[j] 是空字符串，则打印三个空格
                }
                else
                {
                    Console.Write("|" + board[j] + "|"); // 否则打印 board[j] 的内容
                }
            }
            Console.WriteLine(); // 换行
        }


    }
}
