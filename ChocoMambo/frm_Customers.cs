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
    public partial class frm_Customers : Form
    {
        #region Class Variables
        Customer _customer = null;
        Validate _validate;
        #endregion

        #region Constructor
        public frm_Customers(Boolean pblnCanWrite)
        {
            InitializeComponent();
            this.Text = "New " + this.Text;
            _customer = new Customer();
            _validate = new Validate();
            tsi_save.Enabled = pblnCanWrite;
            populateSaleManangersComboBox();
        }
        public frm_Customers(long pLongID, Boolean pblnCanWrite)
        {
            InitializeComponent();
            _customer = new Customer(pLongID);
            _validate = new Validate();
            tsi_save.Enabled = pblnCanWrite;
            populateSaleManangersComboBox();
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
                _customer.saveData();
                this.Close();
            }
        }
        private void txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validate.isDigit(e);
        }

        private void txt_postcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validate.isDigit(e);
        }
        #endregion

        #region Accessors
        /// <summary>
        /// Pre-Condition: All properties have an assigned value
        /// Post-Condition: The current record is set to text boxes
        /// Description:Displays the current record in text boxes
        /// </summary>
        private void displayRecord()
        {
            txt_name.Text = _customer.Name;
            txt_phoneNumber.Text = _customer.PhoneNumber;
            txt_buildingNumber.Text = _customer.BuildingNumber;
            txt_streetName.Text = _customer.StreetName;
            txt_suburb.Text = _customer.Suburb;
            txt_state.Text = _customer.State;
            txt_postcode.Text = _customer.Postcode;
            cbo_saleManangers.SelectedValue = _customer.SalesMananger;
            txt_contactPerson.Text = _customer.ContactPerson;
        }
        /// <summary>
        /// Pre-Condition: Table must contain the columns "EmployeeName" and "ID"
        /// Post-Condition: cbo_saleManangers filled with the names of sales manangers.
        /// Description:Populates the combobox cbo_saleManangers
        /// </summary>
        private void populateSaleManangersComboBox()
        {
            cbo_saleManangers.DataSource = _customer.getSaleManangers();
            cbo_saleManangers.DisplayMember = "EmployeeName";
            cbo_saleManangers.ValueMember = "ID";
        }
        /// <summary>
        /// Pre-Condition: An instance of the class Validate.
        /// Post-Condition: Data in textboxes is checked and validated.
        /// Description:Checks all txtboxes for null entries and numberfields for text.
        /// </summary>
        private Boolean ValidData()
        {
            if (_validate.IsEmpty(txt_name.Text))
            {
                ep_customer.SetError(txt_name, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_phoneNumber.Text))
            {
                ep_customer.SetError(txt_phoneNumber, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_buildingNumber.Text))
            {
                ep_customer.SetError(txt_buildingNumber, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_streetName.Text))
            {
                ep_customer.SetError(txt_streetName, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_suburb.Text))
            {
                ep_customer.SetError(txt_suburb, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_state.Text))
            {
                ep_customer.SetError(txt_state, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_postcode.Text))
            {
                ep_customer.SetError(txt_postcode, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_contactPerson.Text))
            {
                ep_customer.SetError(txt_contactPerson, "All fields must contain a value");
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
        /// Pre-Condition: Textboxes are checked for correct format
        /// Post-Condition: Current record equals textbox values
        /// Description: Sets class properties to textbox values
        /// </summary>
        private void assignData()
        {
            _customer.Name = txt_name.Text;
            _customer.PhoneNumber = txt_phoneNumber.Text;
            _customer.BuildingNumber = txt_buildingNumber.Text;
            _customer.StreetName = txt_streetName.Text;
            _customer.Suburb = txt_suburb.Text;
            _customer.State = txt_state.Text;
            _customer.Postcode = txt_postcode.Text;
            _customer.SalesMananger = int.Parse(cbo_saleManangers.SelectedValue.ToString());
            _customer.ContactPerson = txt_contactPerson.Text;
        }
        #endregion

       
    }
}
