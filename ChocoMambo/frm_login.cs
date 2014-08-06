using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DBConnection;

namespace ChocoMambo
{
    public partial class frm_login : Form
    {
        #region Class Variables
        long _lngStaffID = 0;
        string _strTableName = "tbl_Users";        
        dbConnection _dbConnection = new dbConnection("Database/ChocoMambo.accdb");
        ChocoMamboBMS _ChocoMamboBMS;
        #endregion

        #region Constructor
        public frm_login(ChocoMamboBMS chocomambobms)
        {
            InitializeComponent();
            _ChocoMamboBMS = chocomambobms;
        }
        #endregion

        #region Properties



        #endregion

        #region Control Events
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Brn_login_Click(object sender, EventArgs e)
        {
            if (allowLogin())
            {
                ChocoMamboBMS.AccessRights = getAccessRightHashTable();
                _ChocoMamboBMS.refreshMenuStrip(true,IsAdmin(_lngStaffID));
              

                this.Close();
            }
            else
                MessageBox.Show("Username or Password not valid.\n Please try again! ");
        }
        #endregion

        #region Accessors

        /// <summary>
        ///Pre-Condition: Login table has valid users
        ///Post-Condition: boolean of successful login
        ///Description: tests user entered data against records kept to see if valid login
        /// </summary>
        /// <returns></returns>
        private bool allowLogin()
        {
            bool blnallowLogin = false;

            DataTable dtbUsers = _dbConnection.GetDataTable(_strTableName);

            foreach (DataRow row in dtbUsers.Rows)
            {
                if (txt_username.Text.Equals(row["Username"].ToString()) && txt_password.Text.Equals(row["Password"].ToString()))
                {
                    _lngStaffID = long.Parse(row["EmployeeNumber"].ToString());
                    blnallowLogin = true;
                    break;
                }
            }
            return blnallowLogin;
        }
        /// <summary>
        ///Pre-Condition: A long with an assigned value greator than one
        ///Post-Condition: True or false of is user an admin
        ///Description: reads dataset and determines if admin or not
        /// </summary>
        /// <param name="plngPKID"></param>
        /// <returns></returns>
        private Boolean IsAdmin(long plngPKID)
        {
            string strQuery = "SELECT * FROM " + _strTableName   
             + " WHERE EmployeeNumber = " + plngPKID;
            DataTable dtbUsers = _dbConnection.GetDataTable(strQuery,"tbl_Users");

            if (Boolean.Parse(dtbUsers.Rows[0]["IsAdmin"].ToString()))
                return true;
            else
            return false;
           

        }
        #endregion

        #region Mutators
        /// <summary>
        /// Description: Fills hashtable with permissions of logged in user.
        /// </summary>
        /// <returns></returns>
        private Hashtable getAccessRightHashTable()
        {
            long lngFormID = 0;
            Hashtable hshAccessRights = new Hashtable();
            DataTable dtbForms = _dbConnection.GetDataTable("tbl_Forms");
            DataTable dtbEmployeeForms = _dbConnection.GetDataTable("Select * FROM tbl_UserForms Where EmployeeNumber = " + _lngStaffID, "tbl_UserForms");
            foreach (DataRow drwForms in dtbForms.Rows)
            {
                foreach (DataRow drwEmployeeForms in dtbEmployeeForms.Rows)
                {
                    lngFormID = long.Parse(drwForms["ID"].ToString());
                    String lngtest = drwEmployeeForms["FormID"].ToString();

                    if (lngFormID.Equals(long.Parse(drwEmployeeForms["FormID"].ToString())) && _lngStaffID.Equals(long.Parse(drwEmployeeForms["EmployeeNumber"].ToString())))
                    {
                        hshAccessRights.Add(drwForms["FormName"].ToString(), drwEmployeeForms["AccessType"].ToString());
                    }
                }
            }
            return hshAccessRights;
        }
        #endregion
        
    }
}
