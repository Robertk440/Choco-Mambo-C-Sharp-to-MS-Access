using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocoMambo
{
    class Validate
    {
        #region Class Variables
        #endregion

        #region Constructor
        public Validate()
        {

        }
        #endregion

        #region Properties
        #endregion

        #region Control Events
        #endregion

        #region Accessors
        public Boolean IsEmpty(String pTestString)
        {
            if (pTestString == "")
                return true;
            else
                return false;
        }
        public Boolean IsValid(String pTestString, String pFailValue)
        {
            if (pTestString != pFailValue)
                return true;
            else
                return false;
        }
        public Boolean isLong(String pTestString)
        {
            if (pTestString != "")
            {
                long temp;
                if (long.TryParse(pTestString, out temp))
                    return true;
                else return false;
            }
            else return false;
        }
        public Boolean isDouble(String pTestString)
        {
            if (pTestString != "")
            {
                double temp;
                if (double.TryParse(pTestString, out temp))
                    return true;
                else return false;
            }
            else return false;
        }
        public void isDigit(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Mutators
        #endregion
    }
}
