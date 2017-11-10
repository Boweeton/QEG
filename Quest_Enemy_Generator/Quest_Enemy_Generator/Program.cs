using System;
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

            const int Repeats = 100;

            int counter = 0;

            for (int i = 0; i < Repeats; i++)
            {
                const int PageHeight = 46;
                dm.RandomizeEnemy(30);

                dm.Enemy.PrintFullWeapons = true;
                dm.Enemy.PrintArmor = true;
                dm.Enemy.PrintFullGlyphs = true;

                string enemyString = dm.Enemy.ToString();
                int currentHeight = CountLines(enemyString);

                if (currentHeight > PageHeight - counter)
                {
                    for (int j = 0; j < (PageHeight-counter); j++)
                    {
                        Console.WriteLine();
                    }
                    counter = 0;
                }
                counter += currentHeight;

                Console.WriteLine(enemyString);
            }
        }

        static int CountLines(string str)
        {
            return str.Length - str.Replace("\n", "").Length;
        }
    }
}