using DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocoMambo
{
    class BusinessContact:Person
    {
        /// <summary>
        /// A general class that inherits the Address Class 
        /// </summary>
        #region Properties       
        public string ContactPerson { get; set; }
        #endregion      
    }
}
