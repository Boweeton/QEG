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

            DataManager dm = new DataManager();

            const int Repeats = 8;
            const int Level = 13;

            // New way of printing
            dm.FillEnemyList(Level, Repeats);
            dm.PrintWeaponsFull = true;
            dm.PrintGlyphsFull = true;
            dm.PrintArmorFull = true;
            List<string> printList = dm.FormatListForDisplay();

            foreach (string s in printList)
            {
                Console.WriteLine(s);
            }
        }
    }
}