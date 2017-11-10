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

            long average = 0;

            for (int i = 0; i < Repeats; i++)
            {
                dm.RandomizeEnemy(10);

                dm.Enemy.PrintFullWeapons = true;
                dm.Enemy.PrintArmor = true;
                dm.Enemy.PrintFullGlyphs = true;

                Console.WriteLine(dm.Enemy.ToString());
            }
            average = average / (Repeats - 1);
            Console.WriteLine($"Average calculation time (ms): {average / 10000f:0.0000}");
        }

        /// <summary>
        /// Returns a string with enough spaces in the front so the input strin appear centered
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string TranslateCentered(string input)
        {
            // Local declarations
            string returnString = "";

            // Calculate the number of spaces
            int spacesCount = (ScreenWidth - input.Length) / 2;

            // Shove in the spaces
            for (int i = 0; i < spacesCount; i++)
            {
                returnString = $"{returnString} ";
            }

            // Stick the input string on the end
            returnString = $"{returnString}{input}";

            return returnString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string CreateFullPartition()
        {
            // Local declarations
            StringBuilder bobTheStringBuilder = new StringBuilder();

            // Fill the StringBuilder with the '_' character ScreenWidth times and return it
            return bobTheStringBuilder.Append('_', ScreenWidth).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string CreatePartialPartition()
        {
            // Local declarations
            StringBuilder bobTheStringBuilder = new StringBuilder();

            for (int i = 0; i < (ScreenWidth / 2) - 2; i++)
            {
                bobTheStringBuilder.Append("- ");
            }
            bobTheStringBuilder.Append("-");

            // Fill the StringBuilder with the '_' character ScreenWidth times and return it
            return bobTheStringBuilder.ToString();
        }
    }
}