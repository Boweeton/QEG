using System.Collections.Generic;

namespace Quest_Enemy_Generator
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        #region Fields



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

        #endregion

        #region Methods

        

        #endregion
    }
}
