using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocoMambo
{
    public partial class frm_Employee : Form
    {
        #region Class Variables
        Employee _employee;
        Validate _validate;
        #endregion

        #region Constructor
        public frm_Employee(Boolean pblnCanWrite)
        {
            InitializeComponent();
            this.Text = "New " + this.Text;
            _employee = new Employee();
            _validate = new Validate();
            tsi_save.Enabled = pblnCanWrite;

        }
        public frm_Employee(long pLongID, Boolean pblnCanWrite)
        {
            InitializeComponent();
            _employee = new Employee(pLongID);
            _validate = new Validate();
            tsi_save.Enabled = pblnCanWrite;
            displayRecord();
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
            if (ValidData())
            {
                assignData();
                _employee.saveData();
                this.Close();
            }
        }
        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validate.isDigit(e);
        }

        private void txt_postcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validate.isDigit(e);
        }

        private void txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validate.isDigit(e);
        }
        #endregion

        #region Accessors
        /// <summary>
        ///Pre-Condition:All properties have an assigned value
        ///Post-Condition:The current record is set to text boxes
        ///Description:Displays the current record in text boxes
        /// </summary>
        private void displayRecord()
        {
            txt_name.Text = _employee.Name;
            txt_phoneNumber.Text = _employee.PhoneNumber;
            txt_houseNumber.Text = _employee.BuildingNumber;
            txt_streetName.Text = _employee.StreetName;
            txt_suburb.Text = _employee.Suburb;
            txt_state.Text = _employee.State;
            txt_postcode.Text = _employee.Postcode;
            txt_department.Text = _employee.Department;
            txt_salary.Text = _employee.Salary.ToString();
        }
        /// <summary>
        ///Pre-Condition:An instance of the class Validate.
        ///Post-Condition:Data in textboxes is checked and validated.
        ///Description:Checks all txtboxes for null entries and numberfields for text.
        /// </summary>
        /// <returns></returns>
        private Boolean ValidData()
        {
            if (_validate.IsEmpty(txt_name.Text))
            {
                ep_employee.SetError(txt_name, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_phoneNumber.Text))
            {
                ep_employee.SetError(txt_phoneNumber, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_houseNumber.Text))
            {
                ep_employee.SetError(txt_houseNumber, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_streetName.Text))
            {
                ep_employee.SetError(txt_streetName, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_suburb.Text))
            {
                ep_employee.SetError(txt_suburb, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_state.Text))
            {
                ep_employee.SetError(txt_state, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_postcode.Text))
            {
                ep_employee.SetError(txt_postcode, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_department.Text))
            {
                ep_employee.SetError(txt_department, "All fields must contain a value");
                return false;
            }
            if (!_validate.isLong(txt_salary.Text))// The isLong Method will check if null first, than if can be passed as long.
            {
                ep_employee.SetError(txt_salary, "Must be a number value");
                return false;
            }
            if (!_validate.IsValid(txt_salary.Text, "0"))
            {
                ep_employee.SetError(txt_salary, "Salary must be greater than Zero");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Mutators
        /// <summary>
        ///Pre-Condition:Textboxes are checked for correct format
        ///Post-Condition:Current record equals textbox values
        ///Description:Sets class properties to textbox values
        /// </summary>
        private void assignData()
        {
            _employee.Name = txt_name.Text;
            _employee.PhoneNumber = txt_phoneNumber.Text;
            _employee.BuildingNumber = txt_houseNumber.Text;
            _employee.StreetName = txt_streetName.Text;
            _employee.Suburb = txt_suburb.Text;
            _employee.State = txt_state.Text;
            _employee.Postcode = txt_postcode.Text;
            _employee.Department = txt_department.Text;
            _employee.Salary = long.Parse(txt_salary.Text);
        }



        #endregion
    }
}
