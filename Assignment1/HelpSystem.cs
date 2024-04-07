﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class HelpSystem
    {
        public HelpSystem() { }
        public static void showcommand(int playerId)
        {
            Console.WriteLine( "Player" + playerId + ", Please choose action:" +
                    "\nM: Make a move to the number of position" +
                    "\nS: Save the game" +
                    "\nU: Undo your last step " +
                    "\nR: Redo your last step " + 
                    "\nQ: Quit Game" +
                    "\nH: Help");
        }
        public static int CallUndoMove(List<History> history, int currentdata)
        {
            int number =Move.UndoMove(currentdata);
            if (number >= 0) {
                Console.WriteLine("UndoMove Successful");
                Board.DisplayBoard(history[number].CurrentBoard);
                return number;
            }
            else
            {
                Console.WriteLine("UndoMove Fail");
                Console.WriteLine("sorry, there are not enough trackmove can undo");
                return number;
            }
                
        }
        public static int CallRedoMove(List<History> history,int CurrentCount) {
            int number = Move.RedoMove(history, CurrentCount);
            Board.DisplayBoard(history[number].CurrentBoard);
            return number;
        }
    }
}
