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
    public class WeaponEnchant
    {
        #region Fields

        

        #endregion

        #region Constructors

        public WeaponEnchant()
        {
            
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public WeaponEnchant(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        #endregion

        #region Properties

        public string Name { get; set; }
        public string Description { get; set; }

        #endregion

        #region Methods



        #endregion
    }
}
