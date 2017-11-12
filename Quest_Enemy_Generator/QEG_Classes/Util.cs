using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QEG_Classes
{
    /// <summary>
    /// 
    /// </summary>
    public static class Util
    {
        #region Fields



        #endregion

        #region Constructors



        #endregion

        #region Properties



        #endregion

        #region Methods

        #region Public Methods

        /// <summary>
        /// Returns how many line return characters are in the provided string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int CountLines(this string str)
        {
            return str.Length - str.Replace("\n", "").Length + 1;
        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}