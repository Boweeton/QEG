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
    public class WeaponUpgrade
    {
        #region Fields



        #endregion

        #region Constructors

        public WeaponUpgrade()
        {
            
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public WeaponUpgrade(int upgradeVal)
        {
            UpgradeVal = upgradeVal;
        }

        #endregion

        #region Properties

        public int UpgradeVal { get; set; }

        #endregion

        #region Methods

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"{nameof(UpgradeVal)}: {UpgradeVal}";
        }

        #endregion
    }
}
