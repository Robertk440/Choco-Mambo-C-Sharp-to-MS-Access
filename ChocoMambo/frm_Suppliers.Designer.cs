namespace ChocoMambo
{
    partial class frm_Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Suppliers));
            this.ms_supplier = new System.Windows.Forms.MenuStrip();
            this.tsi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_close = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_contactPerson = new System.Windows.Forms.TextBox();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.txt_suburb = new System.Windows.Forms.TextBox();
            this.txt_streetName = new System.Windows.Forms.TextBox();
            this.txt_buildingNumber = new System.Windows.Forms.TextBox();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.ep_supplier = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ms_supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_supplier
            // 
            this.ms_supplier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_save,
            this.tst_close});
            this.ms_supplier.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_supplier.Location = new System.Drawing.Point(0, 0);
            this.ms_supplier.Name = "ms_supplier";
            this.ms_supplier.Size = new System.Drawing.Size(304, 24);
            this.ms_supplier.TabIndex = 3;
            this.ms_supplier.Visible = false;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 120;
            this.label10.Text = "Postcode:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 119;
            this.label11.Text = "State:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 118;
            this.label12.Text = "Suburb:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 121;
            this.label13.Text = "Street Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 122;
            this.label14.Text = "Building#";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 117;
            this.label9.Text = "Contact Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Phone#:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "Name:";
            // 
            // txt_contactPerson
            // 
            this.txt_contactPerson.Location = new System.Drawing.Point(100, 240);
            this.txt_contactPerson.Name = "txt_contactPerson";
            this.txt_contactPerson.Size = new System.Drawing.Size(191, 20);
            this.txt_contactPerson.TabIndex = 113;
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(100, 214);
            this.txt_postcode.MaxLength = 4;
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(191, 20);
            this.txt_postcode.TabIndex = 112;
            this.txt_postcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_postcode_KeyPress);
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(100, 188);
            this.txt_state.MaxLength = 3;
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(191, 20);
            this.txt_state.TabIndex = 111;
            // 
            // txt_suburb
            // 
            this.txt_suburb.Location = new System.Drawing.Point(100, 162);
            this.txt_suburb.Name = "txt_suburb";
            this.txt_suburb.Size = new System.Drawing.Size(191, 20);
            this.txt_suburb.TabIndex = 110;
            // 
            // txt_streetName
            // 
            this.txt_streetName.Location = new System.Drawing.Point(100, 136);
            this.txt_streetName.Name = "txt_streetName";
            this.txt_streetName.Size = new System.Drawing.Size(191, 20);
            this.txt_streetName.TabIndex = 109;
            // 
            // txt_buildingNumber
            // 
            this.txt_buildingNumber.Location = new System.Drawing.Point(100, 110);
            this.txt_buildingNumber.Name = "txt_buildingNumber";
            this.txt_buildingNumber.Size = new System.Drawing.Size(191, 20);
            this.txt_buildingNumber.TabIndex = 108;
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(100, 84);
            this.txt_phoneNumber.MaxLength = 10;
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(191, 20);
            this.txt_phoneNumber.TabIndex = 107;
            this.txt_phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phoneNumber_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(100, 58);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(191, 20);
            this.txt_name.TabIndex = 106;
            // 
            // ep_supplier
            // 
            this.ep_supplier.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 52);
            this.panel1.TabIndex = 128;
            // 
            // frm_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(320, 279);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contactPerson);
            this.Controls.Add(this.txt_postcode);
            this.Controls.Add(this.txt_state);
            this.Controls.Add(this.txt_suburb);
            this.Controls.Add(this.txt_streetName);
            this.Controls.Add(this.txt_buildingNumber);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.ms_supplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 380);
            this.MinimizeBox = false;
            this.Name = "frm_Suppliers";
            this.Text = "Supplier";
            this.ms_supplier.ResumeLayout(false);
            this.ms_supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_supplier;
        private System.Windows.Forms.ToolStripMenuItem tsi_save;
        private System.Windows.Forms.ToolStripMenuItem tst_close;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_contactPerson;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.TextBox txt_suburb;
        private System.Windows.Forms.TextBox txt_streetName;
        private System.Windows.Forms.TextBox txt_buildingNumber;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ErrorProvider ep_supplier;
        private System.Windows.Forms.Panel panel1;
    }
}