﻿
using System.Text;

namespace Quest_Enemy_Generator
{
    /// <summary>
    /// 
    /// </summary>
    public class Glyph
    {
        #region Fields

        

        #endregion

        #region Constructors

        public Glyph()
        {
            
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public Glyph(string name, MagicianType school, int lvlReq, int speed, string description)
        {
            Name = name;
            School = school;
            LvlReq = lvlReq;
            Speed = speed;
            Description = description;
        }

        #endregion

        #region Properties

        public string Name { get; set; }
        public MagicianType School { get; set; }
        public int LvlReq { get; set; }
        public int Speed { get; set; }
        public string Description { get; set; }

        #endregion

        #region Methods

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}";
        }

        public string ToDescripString(int screeWidth, int offset)
        {
            // Local declarations
            int spaceToWorkWith = screeWidth - offset;
            string tmpDescription = $"{Description} [{School}]";
            StringBuilder sb = new StringBuilder();

            // Split up the description
            string[] list = tmpDescription.Split(' ');

            int counter = 0;

            // Print the first word
            sb.Append(list[0]);
            counter += list[0].Length;

            for (int i = 1; i < list.Length; i++)
            {
                if (list[i].Length+1 > (spaceToWorkWith - counter))
                {
                    counter = 0;
                    sb.AppendLine();
                    sb.Append(' ', offset-1);
                    sb.Append($" {list[i]}");
                    counter += (list[i].Length + 1);
                }
                else
                {
                    sb.Append($" {list[i]}");
                    counter += (list[i].Length + 1);
                }
            }

            return sb.ToString();
        }

        #endregion
    }
}