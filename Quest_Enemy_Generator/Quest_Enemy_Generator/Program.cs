using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Quest_Enemy_Generator
{
    public class Program
    {
        // Class level declarations
        public const int ScreenWidth = Enemy.ScreenWidth;

        static void Main()
        {
            // Resize the console
            Console.SetWindowSize(ScreenWidth+1, 30);
            //Console.SetBufferSize(ScreenWidth, 30);

            Console.Title = "Quest Enemy Generator";

            DataManager dm = new DataManager();

            const int Repeats = 8;
            const int Level = 13;


            // New way of printing
            dm.FillEnemyList(Level, Repeats);
            List<string> printList = dm.FormatListForDisplay(true, true, false);

            foreach (string s in printList)
            {
                Console.WriteLine(s);
            }
        }

        static int CountLines(string str)
        {
            return str.Length - str.Replace("\n", "").Length;
        }
    }
}