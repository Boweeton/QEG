using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quest_Enemy_Generator
{
    /// <summary>
    /// 
    /// </summary>
    public class Weapon
    {
        #region Fields



        #endregion

        #region Constructors

        public Weapon()
        {
            DisplayName = Name;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public Weapon(string name, string parryVal)
        {
            Name = name;
            DisplayName = Name;
            ParryVal = parryVal;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public Weapon(Weapon weapon)
        {
            Name = weapon.Name;
            DisplayName = weapon.Name;
            WType = weapon.WType;
            IsTwoHanded = weapon.IsTwoHanded;
            ParryVal = weapon.ParryVal;
            WeaponMoves = new List<WeaponMove>(weapon.WeaponMoves);
        }

        #endregion

        #region Properties

        public string Name { get; set; }
        public WeaponType WType { get; set; }
        public bool IsTwoHanded { get; set; }
        public string ParryVal { get; set; }
        public List<WeaponMove> WeaponMoves { get; set; }

        public string DisplayName { get; set; }
        public string Description { get; set; }
        public WeaponBlueprint Blueprint { get; set; }
        public WeaponEnchant Enchant { get; set; }
        public WeaponUpgrade Upgrade { get; set; }

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