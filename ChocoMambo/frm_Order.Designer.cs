namespace ChocoMambo
{
    partial class frm_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tp_OrderItems = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_procePer = new System.Windows.Forms.TextBox();
            this.cbo_products = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_expectedDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.cbo_Branch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_orderDate = new System.Windows.Forms.DateTimePicker();
            this.dgv_orderItems = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderLineQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderLineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tp_Supplier = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_supplierAddress = new System.Windows.Forms.DataGridView();
            this.cdetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccdetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_supplierDetails = new System.Windows.Forms.DataGridView();
            this.clm_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_cdetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_supplier = new System.Windows.Forms.ComboBox();
            this.tc_Order = new System.Windows.Forms.TabControl();
            this.ms_Order = new System.Windows.Forms.MenuStrip();
            this.tsi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_close = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tp_OrderItems.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderItems)).BeginInit();
            this.tp_Supplier.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierAddress)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierDetails)).BeginInit();
            this.tc_Order.SuspendLayout();
            this.ms_Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_OrderItems
            // 
            this.tp_OrderItems.Controls.Add(this.btn_delete);
            this.tp_OrderItems.Controls.Add(this.groupBox2);
            this.tp_OrderItems.Controls.Add(this.groupBox1);
            this.tp_OrderItems.Controls.Add(this.dgv_orderItems);
            this.tp_OrderItems.Controls.Add(this.txt_total);
            this.tp_OrderItems.Controls.Add(this.lbl_total);
            this.tp_OrderItems.Location = new System.Drawing.Point(4, 22);
            this.tp_OrderItems.Name = "tp_OrderItems";
            this.tp_OrderItems.Padding = new System.Windows.Forms.Padding(3);
            this.tp_OrderItems.Size = new System.Drawing.Size(612, 312);
            this.tp_OrderItems.TabIndex = 0;
            this.tp_OrderItems.Text = "Order";
            this.tp_OrderItems.UseVisualStyleBackColor = true;
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
            this.btn_addProduct.Location = new System.Drawing.Point(159, 58);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(32, 23);
            this.btn_addProduct.TabIndex = 23;
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(81, 60);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(72, 20);
            this.txt_qty.TabIndex = 22;
            this.txt_qty.Tag = "test";
            this.txt_qty.Text = "0";
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_procePer
            // 
            this.txt_procePer.Location = new System.Drawing.Point(6, 60);
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
            this.groupBox1.Controls.Add(this.dtp_expectedDeliveryDate);
            this.groupBox1.Controls.Add(this.lbl_date);
            this.groupBox1.Controls.Add(this.cbo_Branch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_orderDate);
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
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Expected DeliveryDate:";
            // 
            // dtp_expectedDeliveryDate
            // 
            this.dtp_expectedDeliveryDate.Location = new System.Drawing.Point(125, 30);
            this.dtp_expectedDeliveryDate.Name = "dtp_expectedDeliveryDate";
            this.dtp_expectedDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_expectedDeliveryDate.TabIndex = 20;
            this.dtp_expectedDeliveryDate.Value = new System.DateTime(2014, 3, 6, 13, 24, 1, 0);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(8, 13);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(62, 13);
            this.lbl_date.TabIndex = 19;
            this.lbl_date.Text = "Order Date:";
            // 
            // cbo_Branch
            // 
            this.cbo_Branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_Branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_Branch.FormattingEnabled = true;
            this.cbo_Branch.Location = new System.Drawing.Point(125, 59);
            this.cbo_Branch.Name = "cbo_Branch";
            this.cbo_Branch.Size = new System.Drawing.Size(200, 21);
            this.cbo_Branch.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Branch:";
            // 
            // dtp_orderDate
            // 
            this.dtp_orderDate.CustomFormat = "dd-MMM-yyyy";
            this.dtp_orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderDate.Location = new System.Drawing.Point(11, 30);
            this.dtp_orderDate.Name = "dtp_orderDate";
            this.dtp_orderDate.Size = new System.Drawing.Size(95, 20);
            this.dtp_orderDate.TabIndex = 16;
            // 
            // dgv_orderItems
            // 
            this.dgv_orderItems.AllowUserToAddRows = false;
            this.dgv_orderItems.AllowUserToResizeColumns = false;
            this.dgv_orderItems.AllowUserToResizeRows = false;
            this.dgv_orderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_orderItems.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_orderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IngNumber,
            this.IngPrice,
            this.OrderLineQty,
            this.OrderLineTotal,
            this.OrderNumber});
            this.dgv_orderItems.Location = new System.Drawing.Point(8, 102);
            this.dgv_orderItems.Name = "dgv_orderItems";
            this.dgv_orderItems.ReadOnly = true;
            this.dgv_orderItems.Size = new System.Drawing.Size(600, 156);
            this.dgv_orderItems.TabIndex = 3;
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
            // IngNumber
            // 
            this.IngNumber.DataPropertyName = "IngNumber";
            this.IngNumber.HeaderText = "IngNumber";
            this.IngNumber.Name = "IngNumber";
            this.IngNumber.ReadOnly = true;
            this.IngNumber.Width = 84;
            // 
            // IngPrice
            // 
            this.IngPrice.DataPropertyName = "IngPrice";
            this.IngPrice.HeaderText = "IngPrice";
            this.IngPrice.Name = "IngPrice";
            this.IngPrice.ReadOnly = true;
            this.IngPrice.Width = 71;
            // 
            // OrderLineQty
            // 
            this.OrderLineQty.DataPropertyName = "OrderLineQty";
            this.OrderLineQty.HeaderText = "OrderLineQty";
            this.OrderLineQty.Name = "OrderLineQty";
            this.OrderLineQty.ReadOnly = true;
            this.OrderLineQty.Width = 94;
            // 
            // OrderLineTotal
            // 
            this.OrderLineTotal.DataPropertyName = "OrderLineTotal";
            this.OrderLineTotal.HeaderText = "OrderLineTotal";
            this.OrderLineTotal.Name = "OrderLineTotal";
            this.OrderLineTotal.ReadOnly = true;
            this.OrderLineTotal.Width = 102;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "OrderNumber";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            this.OrderNumber.Visible = false;
            this.OrderNumber.Width = 95;
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
            // tp_Supplier
            // 
            this.tp_Supplier.Controls.Add(this.groupBox4);
            this.tp_Supplier.Controls.Add(this.groupBox3);
            this.tp_Supplier.Controls.Add(this.cbo_supplier);
            this.tp_Supplier.Location = new System.Drawing.Point(4, 22);
            this.tp_Supplier.Name = "tp_Supplier";
            this.tp_Supplier.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Supplier.Size = new System.Drawing.Size(612, 312);
            this.tp_Supplier.TabIndex = 1;
            this.tp_Supplier.Text = "Supplier Details";
            this.tp_Supplier.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_supplierAddress);
            this.groupBox4.Location = new System.Drawing.Point(312, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 254);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Supplier Address";
            // 
            // dgv_supplierAddress
            // 
            this.dgv_supplierAddress.AllowUserToAddRows = false;
            this.dgv_supplierAddress.AllowUserToDeleteRows = false;
            this.dgv_supplierAddress.AllowUserToResizeColumns = false;
            this.dgv_supplierAddress.AllowUserToResizeRows = false;
            this.dgv_supplierAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_supplierAddress.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_supplierAddress.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_supplierAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_supplierAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplierAddress.ColumnHeadersVisible = false;
            this.dgv_supplierAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_supplierAddress.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_supplierAddress.Location = new System.Drawing.Point(6, 19);
            this.dgv_supplierAddress.Name = "dgv_supplierAddress";
            this.dgv_supplierAddress.ReadOnly = true;
            this.dgv_supplierAddress.Size = new System.Drawing.Size(284, 229);
            this.dgv_supplierAddress.TabIndex = 2;
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
            this.groupBox3.Controls.Add(this.dgv_supplierDetails);
            this.groupBox3.Location = new System.Drawing.Point(6, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 254);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supplier Details";
            // 
            // dgv_supplierDetails
            // 
            this.dgv_supplierDetails.AllowUserToAddRows = false;
            this.dgv_supplierDetails.AllowUserToDeleteRows = false;
            this.dgv_supplierDetails.AllowUserToResizeColumns = false;
            this.dgv_supplierDetails.AllowUserToResizeRows = false;
            this.dgv_supplierDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_supplierDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_supplierDetails.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_supplierDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_supplierDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplierDetails.ColumnHeadersVisible = false;
            this.dgv_supplierDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_supplierDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_supplierDetails.Location = new System.Drawing.Point(6, 19);
            this.dgv_supplierDetails.Name = "dgv_supplierDetails";
            this.dgv_supplierDetails.ReadOnly = true;
            this.dgv_supplierDetails.Size = new System.Drawing.Size(288, 229);
            this.dgv_supplierDetails.TabIndex = 1;
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
            // cbo_supplier
            // 
            this.cbo_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_supplier.FormattingEnabled = true;
            this.cbo_supplier.Items.AddRange(new object[] {
            "supplier"});
            this.cbo_supplier.Location = new System.Drawing.Point(6, 6);
            this.cbo_supplier.Name = "cbo_supplier";
            this.cbo_supplier.Size = new System.Drawing.Size(190, 21);
            this.cbo_supplier.TabIndex = 0;
            this.cbo_supplier.Text = "Select a supplier";
            this.cbo_supplier.SelectedIndexChanged += new System.EventHandler(this.cbo_supplier_SelectedIndexChanged);
            // 
            // tc_Order
            // 
            this.tc_Order.Controls.Add(this.tp_Supplier);
            this.tc_Order.Controls.Add(this.tp_OrderItems);
            this.tc_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Order.Location = new System.Drawing.Point(0, 0);
            this.tc_Order.Name = "tc_Order";
            this.tc_Order.SelectedIndex = 0;
            this.tc_Order.Size = new System.Drawing.Size(620, 338);
            this.tc_Order.TabIndex = 17;
            // 
            // ms_Order
            // 
            this.ms_Order.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_save,
            this.tst_close});
            this.ms_Order.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_Order.Location = new System.Drawing.Point(0, 0);
            this.ms_Order.Name = "ms_Order";
            this.ms_Order.ShowItemToolTips = true;
            this.ms_Order.Size = new System.Drawing.Size(624, 24);
            this.ms_Order.TabIndex = 18;
            this.ms_Order.Visible = false;
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
            this.tst_close.Click += new System.EventHandler(this.tst_close_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(8, 257);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 23);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete Line";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(620, 338);
            this.Controls.Add(this.ms_Order);
            this.Controls.Add(this.tc_Order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 380);
            this.MinimizeBox = false;
            this.Name = "frm_Order";
            this.Text = "Order";
            this.tp_OrderItems.ResumeLayout(false);
            this.tp_OrderItems.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderItems)).EndInit();
            this.tp_Supplier.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierAddress)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierDetails)).EndInit();
            this.tc_Order.ResumeLayout(false);
            this.ms_Order.ResumeLayout(false);
            this.ms_Order.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tp_OrderItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_procePer;
        private System.Windows.Forms.ComboBox cbo_products;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_expectedDeliveryDate;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.ComboBox cbo_Branch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_orderDate;
        private System.Windows.Forms.DataGridView dgv_orderItems;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TabPage tp_Supplier;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_supplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccdetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_supplierDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_cdetails;
        private System.Windows.Forms.ComboBox cbo_supplier;
        private System.Windows.Forms.TabControl tc_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderLineQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderLineTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.MenuStrip ms_Order;
        private System.Windows.Forms.ToolStripMenuItem tsi_save;
        private System.Windows.Forms.ToolStripMenuItem tst_close;
        private System.Windows.Forms.Button btn_delete;

    }
}