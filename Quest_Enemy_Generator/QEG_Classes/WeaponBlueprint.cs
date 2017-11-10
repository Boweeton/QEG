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
    public class WeaponBlueprint
    {
        #region Fields

        

        #endregion

        #region Constructors

        public WeaponBlueprint()
        {
            
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public WeaponBlueprint(string name, string destWeapon, WeaponMove move)
        {
            this.Name = name;
            DestWeapon = destWeapon;
            this.Move = move;
        }

        #endregion

        #region Properties

        public string Name { get; set; }
        public string DestWeapon { get; set; }
        public WeaponMove Move { get; set; }

        #endregion

        #region Methods



        #endregion
    }
}
