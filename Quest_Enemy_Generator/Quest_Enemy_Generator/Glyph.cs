
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

        #endregion
    }
}
