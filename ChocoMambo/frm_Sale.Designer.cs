namespace ChocoMambo
{
    partial class frm_Sale
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sale));
            this.ms_sale = new System.Windows.Forms.MenuStrip();
            this.tsi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_close = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_sales = new System.Windows.Forms.TabControl();
            this.tp_Customer = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_customerAddress = new System.Windows.Forms.DataGridView();
            this.cdetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccdetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_CustomerDetails = new System.Windows.Forms.DataGridView();
            this.clm_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_cdetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_customer = new System.Windows.Forms.ComboBox();
            this.tp_SaleItems = new System.Windows.Forms.TabPage();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_procePer = new System.Windows.Forms.TextBox();
            this.cbo_products = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_expectedShippingDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.cbo_saleRep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_saleDate = new System.Windows.Forms.DateTimePicker();
            this.dgv_saleItems = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleLineQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleLineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.ti_sale = new System.Windows.Forms.NotifyIcon(this.components);
            this.ms_sale.SuspendLayout();
            this.tc_sales.SuspendLayout();
            this.tp_Customer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerAddress)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerDetails)).BeginInit();
            this.tp_SaleItems.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_saleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_sale
            // 
            this.ms_sale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_save,
            this.tst_close});
            this.ms_sale.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_sale.Location = new System.Drawing.Point(0, 0);
            this.ms_sale.Name = "ms_sale";
            this.ms_sale.ShowItemToolTips = true;
            this.ms_sale.Size = new System.Drawing.Size(624, 24);
            this.ms_sale.TabIndex = 8;
            this.ms_sale.Visible = false;
            // 
            // tsi_save
            // 
            this.tsi_save.Image = global::ChocoMambo.Properties.Resources.save;
            this.tsi_save.Name = "tsi_save";
            this.tsi_save.Size = new System.Drawing.Size(28, 20);
            this.tsi_save.ToolTipText = "Save";
            this.tsi_save.Click += new System.EventHandler(this.tsi_save_Click);
            // 
            // tst_close
            // 
            this.tst_close.Image = global::ChocoMambo.Properties.Resources.close;
            this.tst_close.Name = "tst_close";
            this.tst_close.Size = new System.Drawing.Size(28, 20);
            this.tst_close.ToolTipText = "Close";
            this.tst_close.Click += new System.EventHandler(this.tst_close_Click);
            // 
            // tc_sales
            // 
            this.tc_sales.Controls.Add(this.tp_Customer);
            this.tc_sales.Controls.Add(this.tp_SaleItems);
            this.tc_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_sales.Location = new System.Drawing.Point(0, 0);
            this.tc_sales.Name = "tc_sales";
            this.tc_sales.SelectedIndex = 0;
            this.tc_sales.Size = new System.Drawing.Size(620, 338);
            this.tc_sales.TabIndex = 16;
            // 
            // tp_Customer
            // 
            this.tp_Customer.Controls.Add(this.groupBox4);
            this.tp_Customer.Controls.Add(this.groupBox3);
            this.tp_Customer.Controls.Add(this.cbo_customer);
            this.tp_Customer.Location = new System.Drawing.Point(4, 22);
            this.tp_Customer.Name = "tp_Customer";
            this.tp_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Customer.Size = new System.Drawing.Size(612, 312);
            this.tp_Customer.TabIndex = 1;
            this.tp_Customer.Text = "Customer Details";
            this.tp_Customer.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_customerAddress);
            this.groupBox4.Location = new System.Drawing.Point(312, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 254);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shipping Address";
            // 
            // dgv_customerAddress
            // 
            this.dgv_customerAddress.AllowUserToAddRows = false;
            this.dgv_customerAddress.AllowUserToDeleteRows = false;
            this.dgv_customerAddress.AllowUserToResizeColumns = false;
            this.dgv_customerAddress.AllowUserToResizeRows = false;
            this.dgv_customerAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_customerAddress.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_customerAddress.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_customerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_customerAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customerAddress.ColumnHeadersVisible = false;
            this.dgv_customerAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdetails,
            this.cccdetails});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customerAddress.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customerAddress.Location = new System.Drawing.Point(6, 19);
            this.dgv_customerAddress.Name = "dgv_customerAddress";
            this.dgv_customerAddress.ReadOnly = true;
            this.dgv_customerAddress.Size = new System.Drawing.Size(284, 229);
            this.dgv_customerAddress.TabIndex = 2;
            // 
            // cdetails
            // 
            this.cdetails.HeaderText = "";
            this.cdetails.Name = "cdetails";
            this.cdetails.ReadOnly = true;
            // 
            // cccdetails
            // 
            this.cccdetails.HeaderText = "";
            this.cccdetails.Name = "cccdetails";
            this.cccdetails.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_CustomerDetails);
            this.groupBox3.Location = new System.Drawing.Point(6, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 254);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Details";
            // 
            // dgv_CustomerDetails
            // 
            this.dgv_CustomerDetails.AllowUserToAddRows = false;
            this.dgv_CustomerDetails.AllowUserToDeleteRows = false;
            this.dgv_CustomerDetails.AllowUserToResizeColumns = false;
            this.dgv_CustomerDetails.AllowUserToResizeRows = false;
            this.dgv_CustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CustomerDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_CustomerDetails.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_CustomerDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_CustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerDetails.ColumnHeadersVisible = false;
            this.dgv_CustomerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_details,
            this.clm_cdetails});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CustomerDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CustomerDetails.Location = new System.Drawing.Point(6, 19);
            this.dgv_CustomerDetails.Name = "dgv_CustomerDetails";
            this.dgv_CustomerDetails.ReadOnly = true;
            this.dgv_CustomerDetails.Size = new System.Drawing.Size(288, 229);
            this.dgv_CustomerDetails.TabIndex = 1;
            // 
            // clm_details
            // 
            this.clm_details.HeaderText = "";
            this.clm_details.Name = "clm_details";
            this.clm_details.ReadOnly = true;
            // 
            // clm_cdetails
            // 
            this.clm_cdetails.HeaderText = "";
            this.clm_cdetails.Name = "clm_cdetails";
            this.clm_cdetails.ReadOnly = true;
            // 
            // cbo_customer
            // 
            this.cbo_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_customer.FormattingEnabled = true;
            this.cbo_customer.Location = new System.Drawing.Point(6, 6);
            this.cbo_customer.Name = "cbo_customer";
            this.cbo_customer.Size = new System.Drawing.Size(190, 21);
            this.cbo_customer.TabIndex = 0;
            this.cbo_customer.SelectedIndexChanged += new System.EventHandler(this.cbo_customer_SelectedIndexChanged);
            // 
            // tp_SaleItems
            // 
            this.tp_SaleItems.Controls.Add(this.btn_delete);
            this.tp_SaleItems.Controls.Add(this.groupBox2);
            this.tp_SaleItems.Controls.Add(this.groupBox1);
            this.tp_SaleItems.Controls.Add(this.dgv_saleItems);
            this.tp_SaleItems.Controls.Add(this.txt_total);
            this.tp_SaleItems.Controls.Add(this.lbl_total);
            this.tp_SaleItems.Location = new System.Drawing.Point(4, 22);
            this.tp_SaleItems.Name = "tp_SaleItems";
            this.tp_SaleItems.Padding = new System.Windows.Forms.Padding(3);
            this.tp_SaleItems.Size = new System.Drawing.Size(612, 312);
            this.tp_SaleItems.TabIndex = 0;
            this.tp_SaleItems.Text = "Sale";
            this.tp_SaleItems.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(8, 257);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete Line";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_addProduct);
            this.groupBox2.Controls.Add(this.txt_qty);
            this.groupBox2.Controls.Add(this.txt_procePer);
            this.groupBox2.Controls.Add(this.cbo_products);
            this.groupBox2.Location = new System.Drawing.Point(406, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 90);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.AutoSize = true;
            this.btn_addProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_addProduct.Image")));
            this.btn_addProduct.Location = new System.Drawing.Point(159, 57);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(32, 23);
            this.btn_addProduct.TabIndex = 23;
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(81, 59);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(72, 20);
            this.txt_qty.TabIndex = 22;
            this.txt_qty.Tag = "test";
            this.txt_qty.Text = "0";
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_procePer
            // 
            this.txt_procePer.Location = new System.Drawing.Point(6, 59);
            this.txt_procePer.Name = "txt_procePer";
            this.txt_procePer.ReadOnly = true;
            this.txt_procePer.Size = new System.Drawing.Size(69, 20);
            this.txt_procePer.TabIndex = 21;
            this.txt_procePer.Text = "0";
            this.txt_procePer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbo_products
            // 
            this.cbo_products.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_products.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_products.FormattingEnabled = true;
            this.cbo_products.Items.AddRange(new object[] {
            "Select a product"});
            this.cbo_products.Location = new System.Drawing.Point(6, 29);
            this.cbo_products.Name = "cbo_products";
            this.cbo_products.Size = new System.Drawing.Size(185, 21);
            this.cbo_products.TabIndex = 20;
            this.cbo_products.Text = "Select a Product";
            this.cbo_products.SelectedIndexChanged += new System.EventHandler(this.cbo_products_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_expectedShippingDate);
            this.groupBox1.Controls.Add(this.lbl_date);
            this.groupBox1.Controls.Add(this.cbo_saleRep);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_saleDate);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 90);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Expected Shipping Date:";
            // 
            // dtp_expectedShippingDate
            // 
            this.dtp_expectedShippingDate.Location = new System.Drawing.Point(125, 30);
            this.dtp_expectedShippingDate.Name = "dtp_expectedShippingDate";
            this.dtp_expectedShippingDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_expectedShippingDate.TabIndex = 20;
            this.dtp_expectedShippingDate.Value = new System.DateTime(2014, 3, 6, 13, 24, 1, 0);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(8, 13);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(57, 13);
            this.lbl_date.TabIndex = 19;
            this.lbl_date.Text = "Sale Date:";
            // 
            // cbo_saleRep
            // 
            this.cbo_saleRep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_saleRep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_saleRep.FormattingEnabled = true;
            this.cbo_saleRep.Location = new System.Drawing.Point(125, 59);
            this.cbo_saleRep.Name = "cbo_saleRep";
            this.cbo_saleRep.Size = new System.Drawing.Size(200, 21);
            this.cbo_saleRep.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sales Representative:";
            // 
            // dtp_saleDate
            // 
            this.dtp_saleDate.CustomFormat = "dd-MMM-yyyy";
            this.dtp_saleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_saleDate.Location = new System.Drawing.Point(11, 30);
            this.dtp_saleDate.Name = "dtp_saleDate";
            this.dtp_saleDate.Size = new System.Drawing.Size(95, 20);
            this.dtp_saleDate.TabIndex = 16;
            // 
            // dgv_saleItems
            // 
            this.dgv_saleItems.AllowUserToAddRows = false;
            this.dgv_saleItems.AllowUserToResizeColumns = false;
            this.dgv_saleItems.AllowUserToResizeRows = false;
            this.dgv_saleItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_saleItems.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_saleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_saleItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductNumber,
            this.ProductCode,
            this.ProductName,
            this.ProductPrice,
            this.SaleLineQty,
            this.SaleLineTotal,
            this.SaleNumber});
            this.dgv_saleItems.Location = new System.Drawing.Point(8, 102);
            this.dgv_saleItems.Name = "dgv_saleItems";
            this.dgv_saleItems.ReadOnly = true;
            this.dgv_saleItems.Size = new System.Drawing.Size(600, 156);
            this.dgv_saleItems.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 43;
            // 
            // ProductNumber
            // 
            this.ProductNumber.DataPropertyName = "ProductNumber";
            this.ProductNumber.HeaderText = "ProductNumber";
            this.ProductNumber.Name = "ProductNumber";
            this.ProductNumber.ReadOnly = true;
            this.ProductNumber.Visible = false;
            this.ProductNumber.Width = 106;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "ProductCode";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 94;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 97;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 93;
            // 
            // SaleLineQty
            // 
            this.SaleLineQty.DataPropertyName = "SaleLineQty";
            this.SaleLineQty.HeaderText = "SaleLineQty";
            this.SaleLineQty.Name = "SaleLineQty";
            this.SaleLineQty.ReadOnly = true;
            this.SaleLineQty.Width = 89;
            // 
            // SaleLineTotal
            // 
            this.SaleLineTotal.DataPropertyName = "SaleLineTotal";
            this.SaleLineTotal.HeaderText = "SaleLineTotal";
            this.SaleLineTotal.Name = "SaleLineTotal";
            this.SaleLineTotal.ReadOnly = true;
            this.SaleLineTotal.Width = 97;
            // 
            // SaleNumber
            // 
            this.SaleNumber.DataPropertyName = "SaleNumber";
            this.SaleNumber.HeaderText = "SaleNumber";
            this.SaleNumber.Name = "SaleNumber";
            this.SaleNumber.ReadOnly = true;
            this.SaleNumber.Visible = false;
            this.SaleNumber.Width = 90;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_total.Location = new System.Drawing.Point(501, 264);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(107, 20);
            this.txt_total.TabIndex = 4;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(449, 267);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(46, 13);
            this.lbl_total.TabIndex = 5;
            this.lbl_total.Text = "Total:  $";
            // 
            // ti_sale
            // 
            this.ti_sale.Text = "Sale";
            this.ti_sale.Visible = true;
            // 
            // frm_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(620, 338);
            this.Controls.Add(this.tc_sales);
            this.Controls.Add(this.ms_sale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 380);
            this.Name = "frm_Sale";
            this.Text = "Sale";
            this.ms_sale.ResumeLayout(false);
            this.ms_sale.PerformLayout();
            this.tc_sales.ResumeLayout(false);
            this.tp_Customer.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerAddress)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerDetails)).EndInit();
            this.tp_SaleItems.ResumeLayout(false);
            this.tp_SaleItems.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_saleItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_sale;
        private System.Windows.Forms.ToolStripMenuItem tsi_save;
        private System.Windows.Forms.ToolStripMenuItem tst_close;
        private System.Windows.Forms.TabControl tc_sales;
        private System.Windows.Forms.TabPage tp_SaleItems;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.ComboBox cbo_saleRep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_saleDate;
        private System.Windows.Forms.DataGridView dgv_saleItems;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TabPage tp_Customer;
        private System.Windows.Forms.ComboBox cbo_customer;
        private System.Windows.Forms.DataGridView dgv_customerAddress;
        private System.Windows.Forms.DataGridView dgv_CustomerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_cdetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_procePer;
        private System.Windows.Forms.ComboBox cbo_products;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_expectedShippingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleLineQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleLineTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleNumber;
        private System.Windows.Forms.NotifyIcon ti_sale;
        private System.Windows.Forms.Button btn_delete;
    }
}