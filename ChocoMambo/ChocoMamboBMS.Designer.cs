namespace ChocoMambo
{
    partial class ChocoMamboBMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChocoMamboBMS));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Employee_New = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Employee_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Customer_New = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Customer_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Supplier_New = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Supplier_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Sale = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Sale_New = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Sale_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Order_New = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Order_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Product_New = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Product_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_RawIngredients = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_RawIngredients_New = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_RawIngredients_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Sale_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Sale_Report_ByDate = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Sale_Report_ByCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Sale_Report_BySalesAgent = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Orders_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Orders_Report_ByDate = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Orders_Report_BySupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Orders_Report_ByBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Layout_Horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Layout_Vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Layout_Cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.vts_Layout_ArangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.vps_permissions = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Employee,
            this.vts_Customer,
            this.vts_Supplier,
            this.vts_Sale,
            this.vts_Order,
            this.vts_Product,
            this.vts_RawIngredients});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // vts_Employee
            // 
            this.vts_Employee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Employee_New,
            this.vts_Employee_Search});
            this.vts_Employee.Image = global::ChocoMambo.Properties.Resources.employee;
            this.vts_Employee.Name = "vts_Employee";
            this.vts_Employee.Size = new System.Drawing.Size(158, 22);
            this.vts_Employee.Text = "Employee";
            // 
            // vts_Employee_New
            // 
            this.vts_Employee_New.Image = global::ChocoMambo.Properties.Resources.add_icon;
            this.vts_Employee_New.Name = "vts_Employee_New";
            this.vts_Employee_New.Size = new System.Drawing.Size(98, 22);
            this.vts_Employee_New.Text = "New";
            this.vts_Employee_New.Click += new System.EventHandler(this.vts_Employee_New_Click_1);
            // 
            // vts_Employee_Search
            // 
            this.vts_Employee_Search.Image = global::ChocoMambo.Properties.Resources.Search_icon;
            this.vts_Employee_Search.Name = "vts_Employee_Search";
            this.vts_Employee_Search.Size = new System.Drawing.Size(98, 22);
            this.vts_Employee_Search.Text = "Find";
            this.vts_Employee_Search.Click += new System.EventHandler(this.vts_Employee_Search_Click);
            // 
            // vts_Customer
            // 
            this.vts_Customer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Customer_New,
            this.vts_Customer_Search});
            this.vts_Customer.Image = global::ChocoMambo.Properties.Resources.customer;
            this.vts_Customer.Name = "vts_Customer";
            this.vts_Customer.Size = new System.Drawing.Size(158, 22);
            this.vts_Customer.Text = "Customer";
            // 
            // vts_Customer_New
            // 
            this.vts_Customer_New.Image = global::ChocoMambo.Properties.Resources.add_icon;
            this.vts_Customer_New.Name = "vts_Customer_New";
            this.vts_Customer_New.Size = new System.Drawing.Size(98, 22);
            this.vts_Customer_New.Text = "New";
            this.vts_Customer_New.Click += new System.EventHandler(this.vts_Customer_New_Click);
            // 
            // vts_Customer_Search
            // 
            this.vts_Customer_Search.Image = global::ChocoMambo.Properties.Resources.Search_icon;
            this.vts_Customer_Search.Name = "vts_Customer_Search";
            this.vts_Customer_Search.Size = new System.Drawing.Size(98, 22);
            this.vts_Customer_Search.Text = "Find";
            this.vts_Customer_Search.Click += new System.EventHandler(this.vts_Customer_Search_Click);
            // 
            // vts_Supplier
            // 
            this.vts_Supplier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Supplier_New,
            this.vts_Supplier_Search});
            this.vts_Supplier.Image = global::ChocoMambo.Properties.Resources.supplier;
            this.vts_Supplier.Name = "vts_Supplier";
            this.vts_Supplier.Size = new System.Drawing.Size(158, 22);
            this.vts_Supplier.Text = "Supplier";
            // 
            // vts_Supplier_New
            // 
            this.vts_Supplier_New.Image = global::ChocoMambo.Properties.Resources.add_icon;
            this.vts_Supplier_New.Name = "vts_Supplier_New";
            this.vts_Supplier_New.Size = new System.Drawing.Size(98, 22);
            this.vts_Supplier_New.Text = "New";
            this.vts_Supplier_New.Click += new System.EventHandler(this.vts_Supplier_New_Click);
            // 
            // vts_Supplier_Search
            // 
            this.vts_Supplier_Search.Image = global::ChocoMambo.Properties.Resources.Search_icon;
            this.vts_Supplier_Search.Name = "vts_Supplier_Search";
            this.vts_Supplier_Search.Size = new System.Drawing.Size(98, 22);
            this.vts_Supplier_Search.Text = "Find";
            this.vts_Supplier_Search.Click += new System.EventHandler(this.vts_Supplier_Search_Click);
            // 
            // vts_Sale
            // 
            this.vts_Sale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Sale_New,
            this.vts_Sale_Search});
            this.vts_Sale.Image = global::ChocoMambo.Properties.Resources.sales_report;
            this.vts_Sale.Name = "vts_Sale";
            this.vts_Sale.Size = new System.Drawing.Size(158, 22);
            this.vts_Sale.Text = "Sale";
            // 
            // vts_Sale_New
            // 
            this.vts_Sale_New.Image = global::ChocoMambo.Properties.Resources.add_icon;
            this.vts_Sale_New.Name = "vts_Sale_New";
            this.vts_Sale_New.Size = new System.Drawing.Size(98, 22);
            this.vts_Sale_New.Text = "New";
            this.vts_Sale_New.Click += new System.EventHandler(this.vts_Sale_New_Click);
            // 
            // vts_Sale_Search
            // 
            this.vts_Sale_Search.Image = global::ChocoMambo.Properties.Resources.Search_icon;
            this.vts_Sale_Search.Name = "vts_Sale_Search";
            this.vts_Sale_Search.Size = new System.Drawing.Size(98, 22);
            this.vts_Sale_Search.Text = "Find";
            this.vts_Sale_Search.Click += new System.EventHandler(this.vts_Sale_Find_Click);
            // 
            // vts_Order
            // 
            this.vts_Order.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Order_New,
            this.vts_Order_Search});
            this.vts_Order.Image = global::ChocoMambo.Properties.Resources.order;
            this.vts_Order.Name = "vts_Order";
            this.vts_Order.Size = new System.Drawing.Size(158, 22);
            this.vts_Order.Text = "Order";
            // 
            // vts_Order_New
            // 
            this.vts_Order_New.Image = global::ChocoMambo.Properties.Resources.add_icon;
            this.vts_Order_New.Name = "vts_Order_New";
            this.vts_Order_New.Size = new System.Drawing.Size(98, 22);
            this.vts_Order_New.Text = "New";
            this.vts_Order_New.Click += new System.EventHandler(this.vts_Order_New_Click);
            // 
            // vts_Order_Search
            // 
            this.vts_Order_Search.Image = global::ChocoMambo.Properties.Resources.Search_icon;
            this.vts_Order_Search.Name = "vts_Order_Search";
            this.vts_Order_Search.Size = new System.Drawing.Size(98, 22);
            this.vts_Order_Search.Text = "Find";
            this.vts_Order_Search.Click += new System.EventHandler(this.vts_Order_Search_Click);
            // 
            // vts_Product
            // 
            this.vts_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Product_New,
            this.vts_Product_Search});
            this.vts_Product.Image = global::ChocoMambo.Properties.Resources.chocolate;
            this.vts_Product.Name = "vts_Product";
            this.vts_Product.Size = new System.Drawing.Size(158, 22);
            this.vts_Product.Text = "Product";
            // 
            // vts_Product_New
            // 
            this.vts_Product_New.Image = global::ChocoMambo.Properties.Resources.add_icon;
            this.vts_Product_New.Name = "vts_Product_New";
            this.vts_Product_New.Size = new System.Drawing.Size(98, 22);
            this.vts_Product_New.Text = "New";
            this.vts_Product_New.Click += new System.EventHandler(this.vts_Product_New_Click);
            // 
            // vts_Product_Search
            // 
            this.vts_Product_Search.Image = global::ChocoMambo.Properties.Resources.Search_icon;
            this.vts_Product_Search.Name = "vts_Product_Search";
            this.vts_Product_Search.Size = new System.Drawing.Size(98, 22);
            this.vts_Product_Search.Text = "Find";
            this.vts_Product_Search.Click += new System.EventHandler(this.vts_Product_Search_Click);
            // 
            // vts_RawIngredients
            // 
            this.vts_RawIngredients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_RawIngredients_New,
            this.vts_RawIngredients_Search});
            this.vts_RawIngredients.Image = global::ChocoMambo.Properties.Resources.ingredients;
            this.vts_RawIngredients.Name = "vts_RawIngredients";
            this.vts_RawIngredients.Size = new System.Drawing.Size(158, 22);
            this.vts_RawIngredients.Text = "Raw Ingredients";
            // 
            // vts_RawIngredients_New
            // 
            this.vts_RawIngredients_New.Image = global::ChocoMambo.Properties.Resources.add_icon;
            this.vts_RawIngredients_New.Name = "vts_RawIngredients_New";
            this.vts_RawIngredients_New.Size = new System.Drawing.Size(98, 22);
            this.vts_RawIngredients_New.Text = "New";
            this.vts_RawIngredients_New.Click += new System.EventHandler(this.vts_RawIngredients_New_Click);
            // 
            // vts_RawIngredients_Search
            // 
            this.vts_RawIngredients_Search.Image = global::ChocoMambo.Properties.Resources.Search_icon;
            this.vts_RawIngredients_Search.Name = "vts_RawIngredients_Search";
            this.vts_RawIngredients_Search.Size = new System.Drawing.Size(98, 22);
            this.vts_RawIngredients_Search.Text = "Find";
            this.vts_RawIngredients_Search.Click += new System.EventHandler(this.vts_RawIngredients_Search_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Sale_Report,
            this.vts_Orders_Report});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // vts_Sale_Report
            // 
            this.vts_Sale_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Sale_Report_ByDate,
            this.vts_Sale_Report_ByCustomer,
            this.vts_Sale_Report_BySalesAgent});
            this.vts_Sale_Report.Image = global::ChocoMambo.Properties.Resources.sales_report;
            this.vts_Sale_Report.Name = "vts_Sale_Report";
            this.vts_Sale_Report.Size = new System.Drawing.Size(109, 22);
            this.vts_Sale_Report.Text = "Sales";
            // 
            // vts_Sale_Report_ByDate
            // 
            this.vts_Sale_Report_ByDate.Image = global::ChocoMambo.Properties.Resources.Calendar_icon;
            this.vts_Sale_Report_ByDate.Name = "vts_Sale_Report_ByDate";
            this.vts_Sale_Report_ByDate.Size = new System.Drawing.Size(151, 22);
            this.vts_Sale_Report_ByDate.Text = "By Date";
            // 
            // vts_Sale_Report_ByCustomer
            // 
            this.vts_Sale_Report_ByCustomer.Image = global::ChocoMambo.Properties.Resources.customer;
            this.vts_Sale_Report_ByCustomer.Name = "vts_Sale_Report_ByCustomer";
            this.vts_Sale_Report_ByCustomer.Size = new System.Drawing.Size(151, 22);
            this.vts_Sale_Report_ByCustomer.Text = "By Customer";
            // 
            // vts_Sale_Report_BySalesAgent
            // 
            this.vts_Sale_Report_BySalesAgent.Image = global::ChocoMambo.Properties.Resources.employee;
            this.vts_Sale_Report_BySalesAgent.Name = "vts_Sale_Report_BySalesAgent";
            this.vts_Sale_Report_BySalesAgent.Size = new System.Drawing.Size(151, 22);
            this.vts_Sale_Report_BySalesAgent.Text = "By Sales Agent";
            // 
            // vts_Orders_Report
            // 
            this.vts_Orders_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Orders_Report_ByDate,
            this.vts_Orders_Report_BySupplier,
            this.vts_Orders_Report_ByBranch});
            this.vts_Orders_Report.Image = global::ChocoMambo.Properties.Resources.order;
            this.vts_Orders_Report.Name = "vts_Orders_Report";
            this.vts_Orders_Report.Size = new System.Drawing.Size(109, 22);
            this.vts_Orders_Report.Text = "Orders";
            // 
            // vts_Orders_Report_ByDate
            // 
            this.vts_Orders_Report_ByDate.Image = global::ChocoMambo.Properties.Resources.Calendar_icon;
            this.vts_Orders_Report_ByDate.Name = "vts_Orders_Report_ByDate";
            this.vts_Orders_Report_ByDate.Size = new System.Drawing.Size(133, 22);
            this.vts_Orders_Report_ByDate.Text = "By Date";
            // 
            // vts_Orders_Report_BySupplier
            // 
            this.vts_Orders_Report_BySupplier.Image = global::ChocoMambo.Properties.Resources.supplier;
            this.vts_Orders_Report_BySupplier.Name = "vts_Orders_Report_BySupplier";
            this.vts_Orders_Report_BySupplier.Size = new System.Drawing.Size(133, 22);
            this.vts_Orders_Report_BySupplier.Text = "By Supplier";
            // 
            // vts_Orders_Report_ByBranch
            // 
            this.vts_Orders_Report_ByBranch.Image = global::ChocoMambo.Properties.Resources.industry_icon;
            this.vts_Orders_Report_ByBranch.Name = "vts_Orders_Report_ByBranch";
            this.vts_Orders_Report_ByBranch.Size = new System.Drawing.Size(133, 22);
            this.vts_Orders_Report_ByBranch.Text = "By Branch";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vts_Layout_Horizontal,
            this.vts_Layout_Vertical,
            this.vts_Layout_Cascade,
            this.vts_Layout_ArangeIcons});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // vts_Layout_Horizontal
            // 
            this.vts_Layout_Horizontal.Name = "vts_Layout_Horizontal";
            this.vts_Layout_Horizontal.Size = new System.Drawing.Size(143, 22);
            this.vts_Layout_Horizontal.Text = "Horizontal";
            this.vts_Layout_Horizontal.Click += new System.EventHandler(this.vts_Layout_Horizontal_Click);
            // 
            // vts_Layout_Vertical
            // 
            this.vts_Layout_Vertical.Name = "vts_Layout_Vertical";
            this.vts_Layout_Vertical.Size = new System.Drawing.Size(143, 22);
            this.vts_Layout_Vertical.Text = "Vertical";
            this.vts_Layout_Vertical.Click += new System.EventHandler(this.vts_Layout_Vertical_Click);
            // 
            // vts_Layout_Cascade
            // 
            this.vts_Layout_Cascade.Name = "vts_Layout_Cascade";
            this.vts_Layout_Cascade.Size = new System.Drawing.Size(143, 22);
            this.vts_Layout_Cascade.Text = "Cascade";
            this.vts_Layout_Cascade.Click += new System.EventHandler(this.vts_Layout_Cascade_Click);
            // 
            // vts_Layout_ArangeIcons
            // 
            this.vts_Layout_ArangeIcons.Name = "vts_Layout_ArangeIcons";
            this.vts_Layout_ArangeIcons.Size = new System.Drawing.Size(143, 22);
            this.vts_Layout_ArangeIcons.Text = "Arange Icons";
            this.vts_Layout_ArangeIcons.Click += new System.EventHandler(this.vts_Layout_ArangeIcons_Click);
            // 
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.layoutToolStripMenuItem,
            this.tsmi_logout,
            this.tsm_admin});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(859, 24);
            this.ms_main.TabIndex = 1;
            this.ms_main.Text = "menuStrip1";
            // 
            // tsmi_logout
            // 
            this.tsmi_logout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_logout.Name = "tsmi_logout";
            this.tsmi_logout.Size = new System.Drawing.Size(57, 20);
            this.tsmi_logout.Text = "Logout";
            this.tsmi_logout.Click += new System.EventHandler(this.tsmi_logout_Click);
            // 
            // tsm_admin
            // 
            this.tsm_admin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsm_admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vps_permissions});
            this.tsm_admin.Name = "tsm_admin";
            this.tsm_admin.Size = new System.Drawing.Size(55, 20);
            this.tsm_admin.Text = "Admin";
            // 
            // vps_permissions
            // 
            this.vps_permissions.Name = "vps_permissions";
            this.vps_permissions.Size = new System.Drawing.Size(152, 22);
            this.vps_permissions.Text = "Permissions";
            this.vps_permissions.Click += new System.EventHandler(this.vps_permissions_Click);
            // 
            // ChocoMamboBMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(859, 446);
            this.Controls.Add(this.ms_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_main;
            this.Name = "ChocoMamboBMS";
            this.Text = "Choco Mambo BMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChocoMamboBMS_Load);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vts_Employee;
        private System.Windows.Forms.ToolStripMenuItem vts_Employee_New;
        private System.Windows.Forms.ToolStripMenuItem vts_Employee_Search;
        private System.Windows.Forms.ToolStripMenuItem vts_Customer;
        private System.Windows.Forms.ToolStripMenuItem vts_Customer_New;
        private System.Windows.Forms.ToolStripMenuItem vts_Customer_Search;
        private System.Windows.Forms.ToolStripMenuItem vts_Supplier;
        private System.Windows.Forms.ToolStripMenuItem vts_Supplier_New;
        private System.Windows.Forms.ToolStripMenuItem vts_Supplier_Search;
        private System.Windows.Forms.ToolStripMenuItem vts_Sale;
        private System.Windows.Forms.ToolStripMenuItem vts_Sale_New;
        private System.Windows.Forms.ToolStripMenuItem vts_Sale_Search;
        private System.Windows.Forms.ToolStripMenuItem vts_Order;
        private System.Windows.Forms.ToolStripMenuItem vts_Order_New;
        private System.Windows.Forms.ToolStripMenuItem vts_Order_Search;
        private System.Windows.Forms.ToolStripMenuItem vts_Product;
        private System.Windows.Forms.ToolStripMenuItem vts_Product_New;
        private System.Windows.Forms.ToolStripMenuItem vts_Product_Search;
        private System.Windows.Forms.ToolStripMenuItem vts_RawIngredients;
        private System.Windows.Forms.ToolStripMenuItem vts_RawIngredients_New;
        private System.Windows.Forms.ToolStripMenuItem vts_RawIngredients_Search;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vts_Sale_Report;
        private System.Windows.Forms.ToolStripMenuItem vts_Sale_Report_ByDate;
        private System.Windows.Forms.ToolStripMenuItem vts_Sale_Report_ByCustomer;
        private System.Windows.Forms.ToolStripMenuItem vts_Sale_Report_BySalesAgent;
        private System.Windows.Forms.ToolStripMenuItem vts_Orders_Report;
        private System.Windows.Forms.ToolStripMenuItem vts_Orders_Report_ByDate;
        private System.Windows.Forms.ToolStripMenuItem vts_Orders_Report_BySupplier;
        private System.Windows.Forms.ToolStripMenuItem vts_Orders_Report_ByBranch;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vts_Layout_Horizontal;
        private System.Windows.Forms.ToolStripMenuItem vts_Layout_Vertical;
        private System.Windows.Forms.ToolStripMenuItem vts_Layout_Cascade;
        private System.Windows.Forms.ToolStripMenuItem vts_Layout_ArangeIcons;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_admin;
        private System.Windows.Forms.ToolStripMenuItem vps_permissions;
        private System.Windows.Forms.ToolStripMenuItem tsmi_logout;
    }
}

