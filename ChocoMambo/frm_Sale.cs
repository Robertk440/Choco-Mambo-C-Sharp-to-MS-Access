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
    public partial class frm_Sale : Form
    {
        #region Class Variables
        Sale _sale;
        Product _product;
        Customer _customer;
        #endregion

        #region Constructor
        public frm_Sale(Boolean pblnCanWrite)
        {
            InitializeComponent();
            tsi_save.Enabled = pblnCanWrite;
            _sale = new Sale();
            dgv_saleItems.DataSource = _sale.getSaleLinesTable();
            intComboBox();
        }

        public frm_Sale(long pLongID, Boolean pblnCanWrite)
        {
            InitializeComponent();
            tsi_save.Enabled = pblnCanWrite;
            _sale = new Sale(pLongID, false);
            intComboBox();
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

        private void cbo_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = new Product(Int32.Parse(cbo_products.SelectedValue.ToString()));
            _product = product;
            txt_procePer.Text = product.Price.ToString();
        }
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            assignChildData();
            _sale.SaleLineClass.addNewRecord();
            dgv_saleItems.Refresh();
            refreshTotal();
        }
        private void cbo_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int test = cbo_customer.SelectedIndex;
            if (cbo_customer.SelectedIndex > 0)
            {
                Customer customer = new Customer(Int32.Parse(cbo_customer.SelectedValue.ToString()));
                update_dgvCustomerDetails(customer);
                _customer = customer;
            }
        }

        private void tsi_save_Click(object sender, EventArgs e)
        {
            assignData();
            _sale.saveData();
            _sale.SaleLineClass.saveData();
            this.Close();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            _sale.SaleLineClass.deleteSaleLine(long.Parse(dgv_saleItems["ID", dgv_saleItems.CurrentCell.RowIndex].Value.ToString()));
            refreshTotal();
        }
        #endregion

        #region Accessors
      
        private void intComboBox()
        {
            populateCustomerComboBox();
            populateProductComboBox();
            populateSaleRepComboBox();
        }
        /// <summary>
        ///Description: Sums the "SaleLineTotal" colummn of the dataset and returns the value
        /// </summary>
        /// <returns></returns>
        private decimal SaleTotal()
        {
            return Decimal.Parse(_sale.getSaleLinesTable().Compute("Sum(SaleLineTotal)", "").ToString());

        }
        /// <summary>
        ///Description: Gets the items related to the customers address and concatenates the information in a string
        /// </summary>
        /// <returns></returns>
        private string GetCustomerAddress()
        {
            return _customer.BuildingNumber + " " + _customer.StreetName + " " +
                _customer.Suburb + " " + _customer.State + " " + _customer.Postcode;

        }
        /// <summary>
        ///Description: Populates the Customer combobox
        /// </summary>
        private void populateCustomerComboBox()
        {
            cbo_customer.DataSource = _sale.getCustomers();
            cbo_customer.DisplayMember = "ContactName";
            cbo_customer.ValueMember = "ID";
        }
        /// <summary>
        ///Description: Populates the Product combobox
        /// </summary>
        private void populateProductComboBox()
        {
            cbo_products.DataSource = _sale.getProducts();
            cbo_products.DisplayMember = "ProductName";
            cbo_products.ValueMember = "ID";

        }
        /// <summary>
        ///Description: Populates the SaleRep combobox
        /// </summary>
        private void populateSaleRepComboBox()
        {
            cbo_saleRep.DataSource = _sale.getSaleReps();
            cbo_saleRep.DisplayMember = "EmployeeName";
            cbo_saleRep.ValueMember = "ID";
        }

        #endregion

        #region Mutators
        /// <summary>
        ///Pre-Condition:All properties have an assigned value
        ///Post-Condition:The current record is set to text boxes
        ///Description:Displays the current record in text boxes
        /// </summary>
        private void displayRecord()
        {
            cbo_customer.SelectedValue = _sale.CustomerNumber;
            dtp_saleDate.Value = _sale.SaleDate;
            dtp_expectedShippingDate.Value = _sale.SaleShippingDate;
            txt_total.Text = _sale.SaleTotal.ToString();
            dgv_saleItems.DataSource = _sale.getSaleLinesTable();
        }
        private void refreshTotal()
        {
            txt_total.Text = SaleTotal().ToString();
        }
        /// <summary>
        ///Pre-Condition:Textboxes are checked for correct format
        ///Post-Condition:Child data associated with current record is assigned
        ///Description:Sets Assigns child data associated with current record
        /// </summary>
        private void assignChildData()
        {
            _sale.SaleLineClass.SaleNumber = _sale.PKID;
            _sale.SaleLineClass.ProductNumber = long.Parse(cbo_products.SelectedValue.ToString());
            _sale.SaleLineClass.productCode = _product.Code;
            _sale.SaleLineClass.ProductName = cbo_products.Text;
            _sale.SaleLineClass.ProductPrice = decimal.Parse(txt_procePer.Text);
            _sale.SaleLineClass.SaleLineQty = long.Parse(txt_qty.Text);
            _sale.SaleLineClass.SaleLineSubTotal = Decimal.Parse(txt_qty.Text) * Decimal.Parse(txt_procePer.Text);
        }
      /// <summary>
      ///Pre-Condition:Textboxes are checked for correct format
      ///Post-Condition:Current record equals textbox values
      ///Description:Sets class properties to textbox values
      /// </summary>
        private void assignData()
        {
            _sale.SaleDate = dtp_saleDate.Value;
            _sale.SaleShippingDate = dtp_expectedShippingDate.Value;
            _sale.CustomerNumber = long.Parse(cbo_customer.SelectedValue.ToString());
            _sale.SaleShippingAddress = GetCustomerAddress();
            _sale.SaleTotal = SaleTotal();
            _sale.SaleMananger = long.Parse(cbo_saleRep.SelectedValue.ToString());
        }
        /// <summary>
        /// Description:Updates the datagrid view with data related to the selected Customer
        /// </summary>
        /// <param name="customer"></param>
        private void update_dgvCustomerDetails(Customer customer)
        {
            dgv_CustomerDetails.Rows.Clear();
            dgv_customerAddress.Rows.Clear();
            dgv_CustomerDetails.Rows.Add("Name:", customer.Name);
            dgv_CustomerDetails.Rows.Add("Phone No:", customer.PhoneNumber);
            dgv_CustomerDetails.Rows.Add("Contact Person:", customer.ContactPerson);
            dgv_customerAddress.Rows.Add("Building No:", customer.BuildingNumber);
            dgv_customerAddress.Rows.Add("Street:", customer.StreetName);
            dgv_customerAddress.Rows.Add("Suburb:", customer.Suburb);
            dgv_customerAddress.Rows.Add("State:", customer.State);
            dgv_customerAddress.Rows.Add("Postcode:", customer.Postcode);
        }
        #endregion

      
    }
}
