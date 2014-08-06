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
    public partial class frm_Suppliers : Form
    {
        #region Class Variables
        Supplier _supplier;
        Validate _validate;
        #endregion

        #region Constructor
        public frm_Suppliers(Boolean pblnCanWrite)
        {
            InitializeComponent();
            tsi_save.Enabled = pblnCanWrite;
            this.Text = "New " + this.Text;
            _supplier = new Supplier();
            _validate = new Validate();
        }

        public frm_Suppliers(long pLongID, Boolean pblnCanWrite)
        {
            InitializeComponent();
            tsi_save.Enabled = pblnCanWrite;
            _supplier = new Supplier(pLongID);
            _validate = new Validate();
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
                _supplier.saveData();
                this.Close();
            }
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
            txt_name.Text = _supplier.Name;
            txt_phoneNumber.Text = _supplier.PhoneNumber;
            txt_buildingNumber.Text = _supplier.BuildingNumber;
            txt_streetName.Text = _supplier.StreetName;
            txt_suburb.Text = _supplier.Suburb;
            txt_state.Text = _supplier.State;
            txt_postcode.Text = _supplier.Postcode;
            txt_contactPerson.Text = _supplier.ContactPerson;
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
                ep_supplier.SetError(txt_name, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_phoneNumber.Text))
            {
                ep_supplier.SetError(txt_phoneNumber, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_buildingNumber.Text))
            {
                ep_supplier.SetError(txt_buildingNumber, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_streetName.Text))
            {
                ep_supplier.SetError(txt_streetName, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_suburb.Text))
            {
                ep_supplier.SetError(txt_suburb, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_state.Text))
            {
                ep_supplier.SetError(txt_state, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_postcode.Text))
            {
                ep_supplier.SetError(txt_postcode, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_contactPerson.Text))
            {
                ep_supplier.SetError(txt_contactPerson, "All fields must contain a value");
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
            _supplier.Name = txt_name.Text;
            _supplier.PhoneNumber = txt_phoneNumber.Text;
            _supplier.BuildingNumber = txt_buildingNumber.Text;
            _supplier.StreetName = txt_streetName.Text;
            _supplier.Suburb = txt_suburb.Text;
            _supplier.State = txt_state.Text;
            _supplier.Postcode = txt_postcode.Text;
            _supplier.IsASupplier = true;
            _supplier.ContactPerson = txt_contactPerson.Text;
        }
        #endregion
    }
}
