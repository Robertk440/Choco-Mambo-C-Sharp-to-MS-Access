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
    public partial class frm_Product : Form
    {
        #region Class Variables
        Product _product;
        Validate _validate;
        #endregion

        #region Constructor
        public frm_Product(Boolean pblnCanWrite)
        {
            InitializeComponent();
            tsi_save.Enabled = pblnCanWrite;
            _product = new Product();
            this.Text = "New " + this.Text;
            _validate = new Validate();

        }

        public frm_Product(long pLongID, Boolean pblnCanWrite)
        {
            InitializeComponent();
            tsi_save.Enabled = pblnCanWrite;
            _product = new Product(pLongID);
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
                _product.saveData();
                this.Close();
            }
        }

        private void txt_productPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validate.isDigit(e);
        }

        private void txt_qtyOnHand_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validate.isDigit(e);
        }

        private void txt_qtyOnOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validate.isDigit(e);
        }


        #endregion

        #region Accessors
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
                ep_product.SetError(txt_name, "All fields must contain a value");
                return false;
            }
            if (_validate.IsEmpty(txt_productCode.Text))
            {
                ep_product.SetError(txt_productCode, "All fields must contain a value");
                return false;
            }
            if (!_validate.isDouble(txt_productPrice.Text))// The isLong Method will check if null first, than if can be passed as long.
            {
                ep_product.SetError(txt_productPrice, "Must be a number value");
                return false;
            }
            if (!_validate.IsValid(txt_productPrice.Text, "0"))
            {
                ep_product.SetError(txt_productPrice, "Value must be greater than Zero");
                return false;
            }
            if (!_validate.isLong(txt_qtyOnHand.Text))// The isLong Method will check if null first, than if can be passed as long.
            {
                ep_product.SetError(txt_qtyOnHand, "Must be a number value");
                return false;
            }
            if (!_validate.IsValid(txt_qtyOnHand.Text, "0"))
            {
                ep_product.SetError(txt_qtyOnHand, "Value must be greater than Zero");
                return false;
            }
            if (!_validate.isDouble(txt_qtyOnOrder.Text))// The isLong Method will check if null first, than if can be passed as long.
            {
                ep_product.SetError(txt_qtyOnOrder, "Must be a number value");
                return false;
            }
            if (!_validate.IsValid(txt_qtyOnOrder.Text, "0"))
            {
                ep_product.SetError(txt_qtyOnOrder, "Value must be greater than Zero");
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        ///Pre-Condition:All properties have an assigned value
        ///Post-Condition:The current record is set to text boxes
        ///Description:Displays the current record in text boxes
        /// </summary>
        private void displayRecord()
        {
            txt_name.Text = _product.Name;
            txt_productCode.Text = _product.Code;
            txt_productPrice.Text = _product.Price.ToString();
            txt_qtyOnHand.Text = _product.QtyOnHand.ToString();
            txt_qtyOnOrder.Text = _product.QtyOnOrder.ToString();
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
            _product.Name = txt_name.Text;
            _product.Code = txt_productCode.Text;
            _product.Price = decimal.Parse(txt_productPrice.Text);
            _product.QtyOnHand = long.Parse(txt_qtyOnHand.Text);
            _product.QtyOnOrder = long.Parse(txt_qtyOnOrder.Text);
        }
        #endregion
    }
}
