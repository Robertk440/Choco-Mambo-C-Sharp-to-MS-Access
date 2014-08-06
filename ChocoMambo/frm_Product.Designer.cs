namespace ChocoMambo
{
    partial class frm_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Product));
            this.ms_product = new System.Windows.Forms.MenuStrip();
            this.tsi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_close = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_qtyOnOrder = new System.Windows.Forms.TextBox();
            this.txt_qtyOnHand = new System.Windows.Forms.TextBox();
            this.txt_productPrice = new System.Windows.Forms.TextBox();
            this.txt_productCode = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.ep_product = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ms_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_product)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_product
            // 
            this.ms_product.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_save,
            this.tst_close});
            this.ms_product.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_product.Location = new System.Drawing.Point(0, 0);
            this.ms_product.Name = "ms_product";
            this.ms_product.Size = new System.Drawing.Size(304, 24);
            this.ms_product.TabIndex = 3;
            this.ms_product.Visible = false;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 112;
            this.label12.Text = "Qty on Order";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 113;
            this.label13.Text = "Qty on Hand";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 114;
            this.label14.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Name:";
            // 
            // txt_qtyOnOrder
            // 
            this.txt_qtyOnOrder.Location = new System.Drawing.Point(101, 162);
            this.txt_qtyOnOrder.Name = "txt_qtyOnOrder";
            this.txt_qtyOnOrder.Size = new System.Drawing.Size(191, 20);
            this.txt_qtyOnOrder.TabIndex = 109;
            this.txt_qtyOnOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qtyOnOrder_KeyPress);
            // 
            // txt_qtyOnHand
            // 
            this.txt_qtyOnHand.Location = new System.Drawing.Point(101, 136);
            this.txt_qtyOnHand.Name = "txt_qtyOnHand";
            this.txt_qtyOnHand.Size = new System.Drawing.Size(191, 20);
            this.txt_qtyOnHand.TabIndex = 108;
            this.txt_qtyOnHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qtyOnHand_KeyPress);
            // 
            // txt_productPrice
            // 
            this.txt_productPrice.Location = new System.Drawing.Point(101, 110);
            this.txt_productPrice.Name = "txt_productPrice";
            this.txt_productPrice.Size = new System.Drawing.Size(191, 20);
            this.txt_productPrice.TabIndex = 107;
            this.txt_productPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productPrice_KeyPress);
            // 
            // txt_productCode
            // 
            this.txt_productCode.Location = new System.Drawing.Point(101, 84);
            this.txt_productCode.MaxLength = 10;
            this.txt_productCode.Name = "txt_productCode";
            this.txt_productCode.Size = new System.Drawing.Size(191, 20);
            this.txt_productCode.TabIndex = 106;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(101, 58);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(191, 20);
            this.txt_name.TabIndex = 105;
            // 
            // ep_product
            // 
            this.ep_product.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 52);
            this.panel1.TabIndex = 115;
            // 
            // frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(320, 203);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_qtyOnOrder);
            this.Controls.Add(this.txt_qtyOnHand);
            this.Controls.Add(this.txt_productPrice);
            this.Controls.Add(this.txt_productCode);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.ms_product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 280);
            this.MinimizeBox = false;
            this.Name = "frm_Product";
            this.Text = "Product";
            this.ms_product.ResumeLayout(false);
            this.ms_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_product;
        private System.Windows.Forms.ToolStripMenuItem tsi_save;
        private System.Windows.Forms.ToolStripMenuItem tst_close;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_qtyOnOrder;
        private System.Windows.Forms.TextBox txt_qtyOnHand;
        private System.Windows.Forms.TextBox txt_productPrice;
        private System.Windows.Forms.TextBox txt_productCode;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ErrorProvider ep_product;
        private System.Windows.Forms.Panel panel1;
    }
}