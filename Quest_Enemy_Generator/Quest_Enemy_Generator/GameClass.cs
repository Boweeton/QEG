using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_Enemy_Generator
{
    /// <summary>
    /// 
    /// </summary>
    public class GameClass
    {
        #region Fields



        #endregion

        #region Constructors

        public GameClass()
        { }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public GameClass(string name, List<string> possibleWeaponsList, bool canUseMagic)
        {
            Name = name;
            PossibleWeaponsList = possibleWeaponsList;
            CanUseMagic = canUseMagic;
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        public bool WearsLight { get; set; }

        public List<string> PossibleWeaponsList { get; set; }

        public bool CanUseMagic { get; set; }

        public MagicianType MagType { get; set; }

        public SkillGrade DexGrade { get; set; }

        public SkillGrade AccGrade { get; set; }

        public SkillGrade StrGrade { get; set; }

        public SkillGrade SnekGrade { get; set; }

        public SkillGrade PercepGrade { get; set; }

        public SkillGrade MSkillGrade { get; set; }

        public SkillGrade WSkillGrade { get; set; }

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