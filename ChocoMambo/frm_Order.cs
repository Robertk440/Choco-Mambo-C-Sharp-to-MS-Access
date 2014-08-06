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
    public partial class frm_Order : Form
    {
        #region Class Variables
        Order _order;
        #endregion

        #region Constructor
        public frm_Order(Boolean pblnCanWrite)
        {
            InitializeComponent();
            tsi_save.Enabled = pblnCanWrite;
            _order = new Order();
            dgv_orderItems.DataSource = _order.getOrderLinesTable();
            intComboBox();

        }
        public frm_Order(long pLongID, Boolean pblnCanWrite)
        {
            InitializeComponent();
            tsi_save.Enabled = pblnCanWrite;
            _order = new Order(pLongID);
            intComboBox();
            displayRecord();
        }
        #endregion

        #region Properties
        #endregion

        #region Control Events
        private void tst_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            long temp = 0;
            if (long.TryParse(cbo_supplier.SelectedValue.ToString(), out temp))
            {
                Supplier tempSupplier = new Supplier(temp);
                populateRawIngredientsComboBox(temp);
                update_dgvSupplierDetails(tempSupplier);
            }
        }
        private void cbo_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            long temp = 0;
            if (long.TryParse(cbo_products.SelectedValue.ToString(), out temp))
            {
                RawIngredient tempRawIngredient = new RawIngredient(temp);
                txt_procePer.Text = tempRawIngredient.Price.ToString();
            }
        }
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            assignChildData();
            _order.OrderLineClass.addNewRecord();
            dgv_orderItems.Refresh();
            refreshTotal();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            _order.OrderLineClass.deleteOrderLine(long.Parse(dgv_orderItems["ID", dgv_orderItems.CurrentCell.RowIndex].Value.ToString()));
            refreshTotal();
        }
        private void tsi_save_Click(object sender, EventArgs e)
        {
            assignData();
            _order.saveData();
            _order.OrderLineClass.saveData();
            this.Close();
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
            cbo_supplier.SelectedValue = _order.SupplierNumber;
            dtp_orderDate.Value = _order.OrderDate;
            dtp_expectedDeliveryDate.Value = _order.OrderExpectedDeliveryDate;
            txt_total.Text = _order.OrderTotal.ToString();
            dgv_orderItems.DataSource = _order.getOrderLinesTable();
        }
        /// <summary>
        ///Description: Calls populate combobox methods
        /// </summary>
        private void intComboBox()
        {
            populateSupplierComboBox();
            populateBranchComboBox();
        }
        /// <summary>
        ///Description: populates Supplier combo box
        /// </summary>
        private void populateSupplierComboBox()
        {
            cbo_supplier.DataSource = _order.getSuppliers();
            cbo_supplier.DisplayMember = "ContactName";
            cbo_supplier.ValueMember = "ID";
        }
        /// <summary>
        ///Pre-Condition: A supplier is selected
        ///Post-Condition: Combobox is filled with Raw Ingredients related to the supplier id passed
        ///Description: fills a combobox with Raw Ingredients related to the supplier id passed
        /// </summary>
        /// <param name="pLongSupplierID"></param>
        private void populateRawIngredientsComboBox(long pLongSupplierID)
        {
            cbo_products.DataSource = _order.getRawIngredients(pLongSupplierID, "qry_RawIngredientsList");
            cbo_products.DisplayMember = "IngName";
            cbo_products.ValueMember = "ID";
        }
        /// <summary>
        ///Description:populates the branch Combobox
        /// </summary>
        private void populateBranchComboBox()
        {
            cbo_Branch.DataSource = _order.getBranch();
            cbo_Branch.DisplayMember = "BranchName";
            cbo_Branch.ValueMember = "ID";
        }
        /// <summary>
        ///Description: Sums the "OrderLineSubTotal" colummn of the dataset and returns the value
        /// </summary>
        /// <returns></returns>
        private decimal SaleTotal()
        {
            return Decimal.Parse(_order.getOrderLinesTable().Compute("Sum(OrderLineSubTotal)", "").ToString());
        }
        #endregion

        #region Mutators
        private void refreshTotal()
        {
            txt_total.Text = SaleTotal().ToString();
        }
        /// <summary>
        ///Pre-Condition:Textboxes are checked for correct format
        ///Post-Condition:Current record equals textbox values
        ///Description:Sets class properties to textbox values
        /// </summary>
        private void assignData()
        {
            _order.OrderDate = dtp_orderDate.Value;
            _order.OrderExpectedDeliveryDate = dtp_expectedDeliveryDate.Value;
            _order.SupplierNumber = long.Parse(cbo_supplier.SelectedValue.ToString());
            _order.OrderTotal = SaleTotal();
            _order.Branch = long.Parse(cbo_Branch.SelectedValue.ToString());
        }
        /// <summary>
        ///Pre-Condition:Textboxes are checked for correct format
        ///Post-Condition:Child data associated with current record is assigned
        ///Description:Sets Assigns child data associated with current record
        /// </summary>
        private void assignChildData()
        {
            _order.OrderLineClass.OrderNumber = _order.PKID;
            _order.OrderLineClass.IngNumber = long.Parse(cbo_products.SelectedValue.ToString());
            _order.OrderLineClass.IngPrice = decimal.Parse(txt_procePer.Text);
            _order.OrderLineClass.OrderLineQty = long.Parse(txt_qty.Text);
            _order.OrderLineClass.OrderLineSubTotal = Decimal.Parse(txt_qty.Text) * Decimal.Parse(txt_procePer.Text);
        }
        /// <summary>
        ///Description:Updates the datagrid view with data related to the selected Supplier
        /// </summary>
        /// <param name="supplier"></param>
        private void update_dgvSupplierDetails(Supplier supplier)
        {
            dgv_supplierDetails.Rows.Clear();
            dgv_supplierAddress.Rows.Clear();
            dgv_supplierDetails.Rows.Add("Name:", supplier.Name);
            dgv_supplierDetails.Rows.Add("Phone No:", supplier.PhoneNumber);
            dgv_supplierDetails.Rows.Add("Contact Person:", supplier.ContactPerson);
            dgv_supplierAddress.Rows.Add("Building No:", supplier.BuildingNumber);
            dgv_supplierAddress.Rows.Add("Street:", supplier.StreetName);
            dgv_supplierAddress.Rows.Add("Suburb:", supplier.Suburb);
            dgv_supplierAddress.Rows.Add("State:", supplier.State);
            dgv_supplierAddress.Rows.Add("Postcode:", supplier.Postcode);
        }
        #endregion

       
    }
}
