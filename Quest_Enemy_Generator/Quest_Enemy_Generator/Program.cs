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

            string fullPartition = CreateFullPartition();
            string partialPartition = CreatePartialPartition();
            Console.WriteLine(fullPartition);

            string message = TranslateCentered("[Primary Information]");

            Console.WriteLine(message);
            DataManager dm = new DataManager();
            const int Repeats = 50;
            long average = 0;

            const int NameToDescriptionOffset = 28;
            const int DescriptionTpSpeedOffset = 50;
            const int SpeedToDamageOffset = 5;


            for (int i = 0; i < Repeats; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                dm.RandomizeEnemy(10);
                sw.Stop();
                if (i != 0)
                {
                    average += sw.ElapsedTicks;
                }
                Console.WriteLine($"Calculation time (ms): {sw.ElapsedTicks / 10000f:0.0000}");

                Console.WriteLine(dm.Enemy.ToString());

                //const int HeaderPartitioning = 17;

                //Console.WriteLine(TranslateCentered("[Enemy]"));
                //Console.Write($"Lvl: {dm.Enemy.Level,-HeaderPartitioning}");
                //Console.Write($"// {dm.Enemy.Difficulty,-HeaderPartitioning}");
                //Console.Write($"// {dm.Enemy.GameClass.Name,-HeaderPartitioning}");
                //Console.Write($"// {dm.Enemy.Race.Name,-HeaderPartitioning}");
                //Console.WriteLine();

                //Console.WriteLine($"Kill XP: {dm.Enemy.XpYield,-4} Ast XP: {(dm.Enemy.XpYield + 1)/2}");

                //Console.WriteLine(partialPartition);

                //const int Partition = 8;

                //Console.WriteLine(TranslateCentered("[Core Stats]"));
                //Console.WriteLine($"{"Health:",+Partition} {dm.Enemy.Health}");
                //Console.WriteLine($"{"Dex:",+Partition} {dm.Enemy.Dex}");
                //Console.WriteLine($"{"Acc:",+Partition} {dm.Enemy.Acc}");
                //Console.WriteLine($"{"Str:",+Partition} {dm.Enemy.Str}");
                //Console.WriteLine($"{"Percep:",+Partition} {dm.Enemy.Percep}");
                //Console.WriteLine($"{"Snek:",+Partition} {dm.Enemy.Snek}");
                //Console.WriteLine($"{"W-Skill:",+Partition} {dm.Enemy.WeaponSkill}");
                //Console.WriteLine($"{"M-Skill:",+Partition} {dm.Enemy.MagicSkill}");
                

                //Console.WriteLine(TranslateCentered("[Weapons]"));
                //foreach (Weapon currentWeapon in dm.Enemy.Weapons)
                //{
                //    Console.WriteLine(partialPartition);
                //    Console.WriteLine($"{currentWeapon.DisplayName,-35}(Parry Cost: {currentWeapon.ParryVal})");
                //    Console.WriteLine($"{"Name",-NameToDescriptionOffset}{"Description",-DescriptionTpSpeedOffset}{"SPD",-SpeedToDamageOffset}{"DMG"}");
                //    foreach (WeaponMove currentMove in currentWeapon.WeaponMoves)
                //    {
                //        Console.WriteLine($"{currentMove.Name,-NameToDescriptionOffset}{currentMove.Description,-DescriptionTpSpeedOffset}{currentMove.Speed,-SpeedToDamageOffset}{currentMove.Damage}");
                //    }
                //}

                //if (dm.Enemy.GameClass.CanUseMagic)
                //{
                //    Console.WriteLine(partialPartition);
                //    Console.WriteLine(TranslateCentered("[Magic stuffs]"));
                //    foreach (Glyph enemyGlyph in dm.Enemy.Glyphs)
                //    {
                //        Console.WriteLine($"{enemyGlyph.Name, -25}: \"{enemyGlyph.Description}\"");
                //    }
                //}
                //const int TypeOffset = 10;
                //const int NameOffset = 25;
                //Console.WriteLine(partialPartition);
                //Console.WriteLine(TranslateCentered("[Armors]"));
                //Console.WriteLine($"{"Type",-TypeOffset}{"Name",-NameOffset}DefVal");
                //foreach (Armor arm in dm.Enemy.Armors)
                //{
                //    Console.WriteLine($"{arm.AType.ToString(),-TypeOffset}{arm.Name,-NameOffset}{arm.DefVal}");
                //}

                //Console.WriteLine(TranslateCentered($"TOTAL PDef: {dm.Enemy.TotalPDef,-10} TOTAL GDef: {dm.Enemy.TotalGDef}"));


                //Console.WriteLine(partialPartition);
                //Console.WriteLine(TranslateCentered("[Loot]"));
                //Console.WriteLine($"Scrips: {dm.Enemy.Scrips}");

                //Console.WriteLine(fullPartition);
                //Console.WriteLine(fullPartition);
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