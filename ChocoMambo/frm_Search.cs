using DBConnection;
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
    public partial class frm_Search : Form
    {
        #region Class Variables
        DataSet _dataset;
        dbConnection _dbConnection = new dbConnection("Database/ChocoMambo.accdb");
        Boolean blnCanWrite = false;
        String SearchCategory;
        #endregion

        #region Constructor
        public frm_Search(DataSet dataset, String searchCategory, Boolean pblnCanWrite)
        {
            InitializeComponent();
            blnCanWrite = pblnCanWrite;
            tst_delete.Enabled = blnCanWrite;
            _dataset = dataset;
            displaySearchResults();
            SearchCategory = searchCategory;
            setDGVproperties();
            if (SearchCategory.Equals("Sale") || SearchCategory.Equals("Order"))
               txt_search.Enabled = false;
            
        }
        #endregion

        #region Properties
        #endregion

        #region Control Events
        private void dgv_search_DoubleClick(object sender, EventArgs e)
        {
            openSelected(searchID());
        }
        private void frm_Search_Load(object sender, EventArgs e)
        {
            this.Text = SearchCategory;
        }

        private void tst_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tst_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?\n !!Warning This can NOT be undone!! ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteRecordFromDataset(long.Parse(dgv_search["ID", dgv_search.CurrentCell.RowIndex].Value.ToString()));
                saveDataset();
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            _dataset.Tables[0].DefaultView.RowFilter = _dataset.Tables[0].Columns[1].ColumnName + " Like '%" + txt_search.Text + "%'";
            dgv_search.DataSource = _dataset.Tables[0];
            setDGVproperties();
        }
        #endregion

        #region Accessors
        /// <summary>
        ///Pre-Condition:Dataset is loaded to the data grid view
        ///Post-Condition: properties are set to the  data grid view
        ///Description: Hides selected columns
        /// </summary>
        private void setDGVproperties()
        {
            if (SearchCategory == "Supplier")
                dgv_search.Columns["SalesMananger"].Visible = false;

            dgv_search.Columns["IsASupplier"].Visible = false;
        }
        /// <summary>
        ///Pre-Condition: Dataset is passed to the class and assigned to a private dataset
        ///Post-Condition: data grid view is filled with the data from the dataset
        ///Description:Assigned The dataSource of the data grid view
        /// </summary>
        private void displaySearchResults()
        {
            dgv_search.DataSource = _dataset;
            dgv_search.DataMember = _dataset.Tables[0].TableName;
        }
        /// <summary>
        ///Description: gets the id of the selected information in the data grid view
        /// </summary>
        /// <returns></returns>
        private long searchID()
        {
            long lngPKID = 0;
            if (dgv_search["ID", dgv_search.CurrentCell.RowIndex].Value.ToString() != "")
            {
                lngPKID = long.Parse(dgv_search["ID",
                                    dgv_search.CurrentCell.RowIndex].Value.ToString());
            }
            return lngPKID;
        }
        /// <summary>
        ///Pre-Condition: A cell is selected
        ///Post-Condition: A form is opened filled with the data of the selected row
        ///Description: Opens a form associated with the selected cell and information in the data grid view
        /// </summary>
        /// <param name="pkID"></param>
        private void openSelected(long pkID)
        {
            switch (SearchCategory)
            {
                case "Customer":
                    frm_Customers frmCustomers;
                    if (pkID <= -1)
                        frmCustomers = new frm_Customers(blnCanWrite);
                    else
                        frmCustomers = new frm_Customers(pkID, blnCanWrite);

                    frmCustomers.MdiParent = this.MdiParent;
                    frmCustomers.Show();
                    break;

                case "Supplier":
                    frm_Suppliers frmSuppliers;
                    if (pkID <= -1)
                        frmSuppliers = new frm_Suppliers(blnCanWrite);
                    else
                        frmSuppliers = new frm_Suppliers(pkID, blnCanWrite);

                    frmSuppliers.MdiParent = this.MdiParent;
                    frmSuppliers.Show();
                    break;

                case "Employee":
                    frm_Employee frmEmployee;
                    if (pkID == -1)
                        frmEmployee = new frm_Employee(blnCanWrite);
                    else
                        frmEmployee = new frm_Employee(pkID, blnCanWrite);

                    frmEmployee.MdiParent = this.MdiParent;
                    frmEmployee.Show();
                    break;

                case "Product":
                    frm_Product frmProduct;
                    if (pkID == -1)
                        frmProduct = new frm_Product(blnCanWrite);
                    else
                        frmProduct = new frm_Product(pkID, blnCanWrite);
                    frmProduct.MdiParent = this.MdiParent;
                    frmProduct.Show();
                    break;

                case "RawIngredient":
                    frm_RawIngredients frmRawIngredients;
                    if (pkID == -1)
                        frmRawIngredients = new frm_RawIngredients(blnCanWrite);
                    else
                        frmRawIngredients = new frm_RawIngredients(pkID, blnCanWrite);
                    frmRawIngredients.MdiParent = this.MdiParent;
                    frmRawIngredients.Show();
                    break;

                case "Sale":
                    frm_Sale frmSale;
                    if (pkID <= 0)
                        frmSale = new frm_Sale(blnCanWrite);
                    else
                        frmSale = new frm_Sale(pkID, blnCanWrite);
                    frmSale.MdiParent = this.MdiParent;
                    frmSale.Show();
                    break;

                case "Order":
                    frm_Order frmOrder;
                    if (pkID <= 0)
                        frmOrder = new frm_Order(blnCanWrite);
                    else
                        frmOrder = new frm_Order(pkID, blnCanWrite);
                    frmOrder.MdiParent = this.MdiParent;
                    frmOrder.Show();
                    break;
            }
        }
        #endregion

        #region Mutators
      
        private void deleteRecordFromDataset(long PlongPKID)
        {
            _dataset.Tables[0].Rows.Find(PlongPKID).Delete();
        }
        private void saveDataset()
        {
            for (int i = _dataset.Tables.Count - 1; i >= 0; i--)
                _dbConnection.SaveData(_dataset, _dataset.Tables[i].TableName);
        }
        #endregion
    }
}
