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
    public class Armor
    {
        #region Fields

        string description;
        ArmorBlueprint armorBlueprint;
        ArmorEnchant armorEnchant;

        #endregion

        #region Constructors

        public Armor()
        {
            
        }

        public Armor(Armor armor)
        {
            Name = armor.Name;
            IsLight = armor.IsLight;
            AType = armor.AType;
            DType = armor.DType;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public Armor(string name, bool isLight, ArmorType armorType, int defVal, DefType dType)
        {
            Name = name;
            IsLight = isLight;
            AType = armorType;
            DType = dType;
        }

        #endregion

        #region Properties

        public string Name { get; set; }
        public bool IsLight { get; set; }
        public ArmorType AType { get; set; }
        public DefType DType { get; set; }

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
