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
    public class WeaponMove
    {
        #region Fields

        

        #endregion

        #region Constructors

        public WeaponMove()
        {
            
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public WeaponMove(string name, string description, string speed, string damage)
        {
            Name = name;
            Description = description;
            Speed = speed;
            Damage = damage;
        }

        #endregion

        #region Properties

        public string Name { get; set; }
        public string Description { get; set; }
        public string Speed { get; set; }
        public string Damage { get; set; }

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
