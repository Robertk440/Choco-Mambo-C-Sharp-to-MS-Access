using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnection;

namespace ChocoMambo
{
    public partial class frm_Permissions : Form
    {
        #region Class Variables
        dbConnection _dbconnection = new dbConnection("Database/ChocoMambo.accdb");
        DataSet _dataSet;
        #endregion

        #region Constructor
        public frm_Permissions()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties



        #endregion

        #region Control Events
        private void tst_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsi_save_Click(object sender, EventArgs e)
        {
            dgv_permissions.BeginEdit(false);
            _dbconnection.SaveData(_dataSet, "tbl_UserForms");
        }
        private void cbo_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dataSet.Tables[0].DefaultView.RowFilter = _dataSet.Tables[0].Columns[2].ColumnName + " = '" + int.Parse(cbo_filter.SelectedValue.ToString()) + "'";

            dgv_permissions.DataSource = _dataSet.Tables[0];
        }

        #endregion

        #region Accessors
        private void frm_Permissions_Load(object sender, EventArgs e)
        {
            _dataSet = new DataSet();
            _dbconnection.fillDataSet(_dataSet, "SELECT * FROM tbl_UserForms", "tbl_UserForms");
            dgv_permissions.DataSource = _dataSet.Tables["tbl_UserForms"];

            //SetEmployeeCombo
            colEmployee.DisplayMember = "EmployeeName";
            colEmployee.ValueMember = "ID";
            colEmployee.DataSource = _dbconnection.GetDataTable("qry_EmployeeList");
            colEmployee.DataPropertyName = "EmployeeNumber";


            //Set Form Combo
            colForm.DisplayMember = "FormName";
            colForm.ValueMember = "ID";
            colForm.DataSource = _dbconnection.GetDataTable("tbl_Forms");
            colForm.DataPropertyName = "FormID";

            //Set Access Combo
            colRights.DataPropertyName = "AccessType";

            //setFilterCombo
            cbo_filter.DisplayMember = "EmployeeName";
            cbo_filter.ValueMember = "ID";
            cbo_filter.DataSource = _dbconnection.GetDataTable("qry_EmployeeList");

        }

        #endregion

        #region Mutators

        #endregion
    }
}
