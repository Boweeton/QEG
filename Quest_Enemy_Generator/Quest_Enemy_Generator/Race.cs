using System.Collections.Generic;

namespace Quest_Enemy_Generator
{
    /// <summary>
    /// 
    /// </summary>
    public class Race
    {
        #region Fields



        #endregion

        #region Constructors

        public Race()
        {
            
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public Race(string name, List<string> possibleClassList)
        {
            Name = name;
            PossibleClassList = possibleClassList;
        }

        #endregion

        #region Properties


        public string Name { get; set; }
        public int Health { get; set; }
        public List<string> PossibleClassList { get; set; }

        #endregion

        #region Methods

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}";
        }

        #endregion
    }
}