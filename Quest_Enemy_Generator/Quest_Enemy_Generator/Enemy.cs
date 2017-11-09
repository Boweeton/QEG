using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Quest_Enemy_Generator
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        #region Fields

        public const int ScreenWidth = 84;

        #endregion

        #region Constructors

        public Enemy()
        {
            // todo:TAKE ME OUT OF HERE!
            MagicSkill = 50;
        }

        #endregion

        #region Properties

        public EnemyDifficulty Difficulty { get; set; }
        public Race Race { get; set; }
        public GameClass GameClass { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Armor> Armors { get; set; }
        public List<Glyph> Glyphs { get; set; }

        public int TotalPDef { get; set; }
        public int TotalGDef { get; set; }
        public int TotalSDef { get; set; }
        public int XpYield { get; set; }
        public int AveragePlayerLevel { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Dex { get; set; }
        public int Acc { get; set; }
        public int Str { get; set; }
        public int Snek { get; set; }
        public int Percep { get; set; }
        public int MagicSkill { get; set; }
        public int WeaponSkill { get; set; }
        public int Scrips { get; set; }

        public bool PrintFullWeapons { get; set; }
        public bool PrintFullGlyphs { get; set; }
        public bool PrintArmor { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            // Local Declarations
            StringBuilder sb = new StringBuilder();

            // Create the partitions
            string fullPartition = CreateFullPartition();
            string partialPartition = CreatePartialPartition();

            // Create the info strings
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

            list1.Add($" Health: {Health}");
            list1.Add($"    Dex: {Dex}");
            list1.Add($"    Acc: {Acc}");
            list1.Add($"    Str: {Str}");
            list1.Add($" Percep: {Percep}");
            list1.Add($"   Snek: {Snek}");
            list1.Add($"W-Skill: {WeaponSkill}");
            list1.Add($"M-Skill: {MagicSkill}");
            list2.Add($"{Level} :Lvl   ");
            list2.Add($"{XpYield} :XP    ");
            list2.Add($"{TotalPDef} :P-Def ");
            list2.Add($"{TotalGDef} :G-Def ");
            list2.Add(" ");
            list2.Add(" ");
            list2.Add(" ");
            list2.Add($"{Scrips} :Scrips");

            // Print front end stuff
            sb.AppendLine(fullPartition);
            sb.AppendLine(TranslateCentered("--[Core Info]--"));

            for (int i = 0; i < list1.Count; i++)
            {
                sb.Append(list1[i]);
                sb.Append(' ', ScreenWidth - list1[i].Length - list2[i].Length);
                sb.AppendLine(list2[i]);
            }

            if (PrintFullWeapons)
            {
                sb.AppendLine(partialPartition);
                sb.AppendLine(TranslateCentered("--[Weapons (Full)]--"));
                foreach (Weapon weapon in Weapons)
                {
                    string parry = $"(Parry cost: {weapon.ParryVal})";
                    sb.AppendLine("----------");
                    sb.Append(weapon.Name);
                    sb.Append(' ', ScreenWidth - weapon.Name.Length - parry.Length);
                    sb.AppendLine(parry);
                }
            }
            else
            {
                
            }


            return sb.ToString();
        }

        /// <summary>
        /// Returns a string with enough spaces in the front so the input strin appear centered
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        string TranslateCentered(string input)
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
        string CreateFullPartition()
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
        string CreatePartialPartition()
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

        #endregion
    }
}