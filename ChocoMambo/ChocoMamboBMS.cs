using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErrorCollection;

namespace ChocoMambo
{
    public partial class ChocoMamboBMS : Form
    {
        #region Class Variables
        errorCollection _errorCollection;
        #endregion

        #region Constructor
        public ChocoMamboBMS()
        {
            InitializeComponent();
            _errorCollection = new errorCollection();
            //Sets the direction of the dropdown menu in the menu strip.
            ms_main.DefaultDropDownDirection = ToolStripDropDownDirection.BelowLeft;
        }
        #endregion

        #region Properties
        public static Hashtable AccessRights { get; set; }
        #endregion

        #region Control Events
        #region viewMenuStrip
        /// <summary>       
        /// Description: Handles all the events called by the menu strip
        /// </summary>
        private void vts_Employee_Search_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Employee"))
            {
                Employee _employee = new Employee();
                frm_Search _search = new frm_Search(_employee.employeeDataset, "Employee", canWrite("frm_Employee"));
                _search.MdiParent = this;
                _search.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }

        private void vts_Employee_New_Click_1(object sender, EventArgs e)
        {
            if (!isDenied("frm_Employee"))
            {
                frm_Employee _E = new frm_Employee(canWrite("frm_Employee"));
                _E.MdiParent = this;
                _E.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");        
        }
        private void vts_Customer_New_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Customers"))
            {
                frm_Customers _C = new frm_Customers(canWrite("frm_Customers"));
                _C.MdiParent = this;
                _C.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }
        private void vts_Customer_Search_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Customers"))
            {
                Customer _customer = new Customer();
                frm_Search _search = new frm_Search(_customer.cusomerDataSet, "Customer", canWrite("frm_Customers"));
                _search.MdiParent = this;
                _search.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }
        private void vts_Supplier_New_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Supplier"))
            {
                frm_Suppliers _S = new frm_Suppliers(canWrite("frm_Suppliers"));
                _S.MdiParent = this;
                _S.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }
        private void vts_Supplier_Search_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Suppliers"))
            {
                Supplier _supplier = new Supplier();
                frm_Search _search = new frm_Search(_supplier.supplierDataset, "Supplier", canWrite("frm_Suppliers"));
                _search.MdiParent = this;
                _search.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }
        private void vts_Sale_New_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Sale"))
            {
                frm_Sale _Sale = new frm_Sale(canWrite("frm_Sale"));
                _Sale.MdiParent = this;
                _Sale.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }
        private void vts_Sale_Find_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Sale"))
            {
                Sale _sale = new Sale("Search");
                frm_Search frmsearch = new frm_Search(_sale.saleDataset, "Sale", canWrite("frm_Sale"));
                frmsearch.MdiParent = this;
                frmsearch.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }

        private void vts_Order_New_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Order"))
            {
                frm_Order frmOrder = new frm_Order(canWrite("frm_Order"));
                frmOrder.MdiParent = this;
                frmOrder.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }
        private void vts_Order_Search_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Order"))
            {
                Order order = new Order("Search");
                frm_Search frmsearch = new frm_Search(order.OrderDataset, "Order", canWrite("frm_Order"));
                frmsearch.MdiParent = this;
                frmsearch.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }
        private void vts_Product_New_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Product"))
            {
                frm_Product frmProduct = new frm_Product(canWrite("frm_Product"));
                frmProduct.MdiParent = this;
                frmProduct.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }
        private void vts_Product_Search_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_Product"))
            {
                Product product = new Product();
                frm_Search frmsearch = new frm_Search(product.productDataSet, "Product", canWrite("frm_Product"));
                frmsearch.MdiParent = this;
                frmsearch.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }
        private void vts_RawIngredients_New_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_RawIngredients"))
            {
                frm_RawIngredients frmRawIngredients = new frm_RawIngredients(canWrite("frm_RawIngredients"));
                frmRawIngredients.MdiParent = this;
                frmRawIngredients.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");
        }
        private void vts_RawIngredients_Search_Click(object sender, EventArgs e)
        {
            if (!isDenied("frm_RawIngredients"))
            {
                RawIngredient ring = new RawIngredient();
                frm_Search frmsearch = new frm_Search(ring.ingredientDataSet, "RawIngredient", canWrite("frm_RawIngredients"));
                frmsearch.MdiParent = this;
                frmsearch.Show();
            }
            else
                MessageBox.Show("Access denied. Contact network administrator to gain access");

        }
        private void vps_permissions_Click(object sender, EventArgs e)
        {
            frm_Permissions frm_permissions = new frm_Permissions();
            frm_permissions.MdiParent = this;
            frm_permissions.Show();
        }
        private void tsmi_logout_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frm_login frmlogin = new frm_login(this);
            frmlogin.MdiParent = this;
            frmlogin.Show();
            ms_main.Enabled = false;
            tsm_admin.Visible = false;
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Layout
        private void vts_Layout_Horizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void vts_Layout_Vertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void vts_Layout_Cascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void vts_Layout_ArangeIcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        #endregion

        #endregion

        #endregion

        #region Accessors
        /// <summary>
        /// Pre-Condition:  A boolean of a successful login
        /// Post-Condition: the Enabled status on the menu strip will equal the boolean
        /// Description: Sets the Enabled status on the menu strip to the boolean
        /// </summary>
        /// <param name="pSuccessfulLogin"></param>
        public void refreshMenuStrip(Boolean pSuccessfulLogin,Boolean pblnIsAdmin)
        {
            ms_main.Enabled = pSuccessfulLogin;
            tsm_admin.Visible = pblnIsAdmin;
        }
        /// <summary>
        /// Pre-Condition: A string containing the form name to be tested
        /// Post-Condition: A boolean on if the user is denied 
        /// Description: Test the form name against the hash table to determines if the user is allowed access to the form. 
        /// </summary>
        /// <param name="pstrFormName"></param>
        /// <returns></returns>
        private Boolean isDenied(string pstrFormName)
        {
            if (AccessRights[pstrFormName].ToString().Equals("Deny"))
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Pre-Condition: A string containing the form name to be tested
        /// Post-Condition: A boolean on if the user is allowed to write to the form 
        /// Description: Test the form name against the hash table to determines if the user is allowed access to the form. 
        /// </summary>
        /// <param name="pstrFormName"></param>
        /// <returns></returns>
        private Boolean canWrite(string pstrFormName)
        {
            if (AccessRights[pstrFormName].ToString().Equals("Write"))
            {
                return true;
            }
            else return false;
          
        }

        private void ChocoMamboBMS_Load(object sender, EventArgs e)
        {
            frm_login frmlogin = new frm_login(this);
            frmlogin.MdiParent = this;
            frmlogin.Show();
            ms_main.Enabled = false;
            tsm_admin.Visible = false;
        }


        #endregion

        #region Mutators
        #endregion
    }
}
