using System;
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

            // Print enemy title
            sb.AppendLine(TranslateCentered($"{Difficulty} : {Race.Name} : {GameClass.Name}"));
            sb.AppendLine(partialPartition);

            for (int i = 0; i < list1.Count; i++)
            {
                sb.Append(list1[i]);
                sb.Append(' ', ScreenWidth - list1[i].Length - list2[i].Length);
                sb.AppendLine(list2[i]);
            }

            // Print the weapons
            if (PrintFullWeapons)
            {
                sb.AppendLine(partialPartition);
                sb.AppendLine(TranslateCentered("--[Weapons (Full)]--"));
                foreach (Weapon weapon in Weapons)
                {
                    // Calculations
                    string parry = $"(Parry cost: {weapon.ParryVal})";
                    const int BufferAfterName = 21;
                    const int BufferAfterDescription = 38;
                    const int BufferAfterSpeed = 8;

                    sb.AppendLine("----------");

                    // Print name
                    sb.Append(weapon.DisplayName);
                    sb.Append(' ', ScreenWidth - weapon.DisplayName.Length - parry.Length);
                    sb.AppendLine(parry);

                    // Print moves title
                    sb.AppendLine($"   {"Name",-BufferAfterName}{"Description",-BufferAfterDescription}{"SPD",-BufferAfterSpeed}DMG");

                    // Print ALL the moves
                    foreach (WeaponMove move in weapon.WeaponMoves)
                    {
                        sb.AppendLine($"   {move.Name,-BufferAfterName}{move.Description,-BufferAfterDescription}{move.Speed,-BufferAfterSpeed}{move.Damage}");
                    }
                }
                sb.AppendLine("----------");
            }
            else
            {
                // Print front end stuff
                sb.AppendLine(partialPartition);
                sb.AppendLine(TranslateCentered("--[Weapons (Compacted)]--"));

                // Print the compacted form of each weapon
                const int BufferAtEnd = 8;
                const int BufferAfterSpeed = 6;

                sb.Append($"Name");
                sb.Append(' ', ScreenWidth - "Name".Length - "SPD".Length - "DMG".Length - (BufferAfterSpeed - "SPD".Length) - BufferAtEnd);
                sb.AppendLine($"{"SPD",-BufferAfterSpeed}DMG  ");

                foreach (Weapon weapon in Weapons)
                {
                    sb.Append($"{weapon.DisplayName}");
                    sb.Append(' ', ScreenWidth - weapon.DisplayName.Length - "SPD".Length - "DMG".Length - (BufferAfterSpeed - "SPD".Length) - BufferAtEnd);
                    sb.Append($"{weapon.WeaponMoves[1].Speed,-BufferAfterSpeed}");
                    sb.AppendLine(weapon.WeaponMoves[1].Damage);
                }
            }

            // Print the glyphs
            if (GameClass.CanUseMagic)
            {
                if (PrintFullGlyphs)
                {
                    // Print front end stuff
                    sb.AppendLine(partialPartition);
                    sb.AppendLine(TranslateCentered("--[Glyphs (Full)]--"));

                    // Buffer constants
                    const int BufferAfterName = 20;
                    const int BufferAfterSpeed = 7;

                    // Print the title
                    sb.AppendLine($"{"Name",-BufferAfterName}{"SPD",-BufferAfterSpeed}Description");

                    // Print ALL the glyphs
                    foreach (Glyph glyph in Glyphs)
                    {
                        sb.AppendLine($"{glyph.Name,-BufferAfterName}{glyph.Speed,-BufferAfterSpeed}{glyph.ToDescripString(ScreenWidth, BufferAfterSpeed + BufferAfterName)}");
                        sb.AppendLine();
                    }
                }
                else
                {
                    // Print front end stuff
                    sb.AppendLine(partialPartition);
                    sb.AppendLine(TranslateCentered("--[Glyphs (Compact)]--"));

                    // Print glyphs
                    int counter = 0;

                    // Print the first one
                    sb.Append($"({Glyphs[0].Name})");
                    counter += Glyphs[0].Name.Length + 2;

                    for (int i = 1; i < Glyphs.Count; i++)
                    {
                        if (Glyphs[i].Name.Length + 4 > ScreenWidth - counter)
                        {
                            sb.AppendLine();
                            counter = 0;
                            sb.Append($"({Glyphs[i].Name})");
                            counter += Glyphs[i].Name.Length + 2;
                        }
                        else
                        {
                            sb.Append($"  ({Glyphs[i].Name})");
                            counter += Glyphs[i].Name.Length + 4;
                        }
                    }
                    sb.AppendLine();
                }
            }

            // Print armor
            if (PrintArmor)
            {
                // Print front end stuff
                sb.AppendLine(partialPartition);
                sb.AppendLine(TranslateCentered("--[Armor]--"));

                //Print ALL the armor
                const int TypeOffset = 10;
                const int NameOffset = 10;
                foreach (Armor arm in Armors)
                {
                    sb.AppendLine($"{arm.AType.ToString(),-TypeOffset}{arm.Name,-NameOffset}{arm.DefVal}");
                }
            }

            sb.AppendLine(fullPartition);
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

            for (int i = 0; i < (ScreenWidth / 2) - 1; i++)
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