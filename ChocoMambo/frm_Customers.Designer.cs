namespace ChocoMambo
{
    partial class frm_Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customers));
            this.ms_customers = new System.Windows.Forms.MenuStrip();
            this.tsi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_close = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_buildingNumber = new System.Windows.Forms.TextBox();
            this.txt_streetName = new System.Windows.Forms.TextBox();
            this.txt_suburb = new System.Windows.Forms.TextBox();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.txt_contactPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbo_saleManangers = new System.Windows.Forms.ComboBox();
            this.ep_customer = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ms_customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_customers
            // 
            this.ms_customers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_save,
            this.tst_close});
            this.ms_customers.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_customers.Location = new System.Drawing.Point(0, 0);
            this.ms_customers.Name = "ms_customers";
            this.ms_customers.Size = new System.Drawing.Size(320, 24);
            this.ms_customers.TabIndex = 3;
            this.ms_customers.Visible = false;
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
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(101, 58);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(191, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(101, 84);
            this.txt_phoneNumber.MaxLength = 10;
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(191, 20);
            this.txt_phoneNumber.TabIndex = 5;
            this.txt_phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phoneNumber_KeyPress);
            // 
            // txt_buildingNumber
            // 
            this.txt_buildingNumber.Location = new System.Drawing.Point(101, 110);
            this.txt_buildingNumber.Name = "txt_buildingNumber";
            this.txt_buildingNumber.Size = new System.Drawing.Size(191, 20);
            this.txt_buildingNumber.TabIndex = 6;
            // 
            // txt_streetName
            // 
            this.txt_streetName.Location = new System.Drawing.Point(101, 136);
            this.txt_streetName.Name = "txt_streetName";
            this.txt_streetName.Size = new System.Drawing.Size(191, 20);
            this.txt_streetName.TabIndex = 7;
            // 
            // txt_suburb
            // 
            this.txt_suburb.Location = new System.Drawing.Point(101, 162);
            this.txt_suburb.Name = "txt_suburb";
            this.txt_suburb.Size = new System.Drawing.Size(191, 20);
            this.txt_suburb.TabIndex = 8;
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(101, 188);
            this.txt_state.MaxLength = 3;
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(191, 20);
            this.txt_state.TabIndex = 9;
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(101, 214);
            this.txt_postcode.MaxLength = 4;
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(191, 20);
            this.txt_postcode.TabIndex = 10;
            this.txt_postcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_postcode_KeyPress);
            // 
            // txt_contactPerson
            // 
            this.txt_contactPerson.Location = new System.Drawing.Point(101, 266);
            this.txt_contactPerson.Name = "txt_contactPerson";
            this.txt_contactPerson.Size = new System.Drawing.Size(191, 20);
            this.txt_contactPerson.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Phone#:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sales Manager:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Contact Person:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 102;
            this.label10.Text = "Postcode:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 101;
            this.label11.Text = "State:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "Suburb:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 103;
            this.label13.Text = "Street Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 104;
            this.label14.Text = "Building#";
            // 
            // cbo_saleManangers
            // 
            this.cbo_saleManangers.FormattingEnabled = true;
            this.cbo_saleManangers.Location = new System.Drawing.Point(101, 240);
            this.cbo_saleManangers.Name = "cbo_saleManangers";
            this.cbo_saleManangers.Size = new System.Drawing.Size(191, 21);
            this.cbo_saleManangers.TabIndex = 105;
            // 
            // ep_customer
            // 
            this.ep_customer.ContainerControl = this;
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
            // frm_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(320, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbo_saleManangers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.ms_customers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 380);
            this.MinimizeBox = false;
            this.Name = "frm_Customers";
            this.Text = "Customer";
            this.ms_customers.ResumeLayout(false);
            this.ms_customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_customers;
        private System.Windows.Forms.ToolStripMenuItem tsi_save;
        private System.Windows.Forms.ToolStripMenuItem tst_close;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.TextBox txt_buildingNumber;
        private System.Windows.Forms.TextBox txt_streetName;
        private System.Windows.Forms.TextBox txt_suburb;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.TextBox txt_contactPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbo_saleManangers;
        private System.Windows.Forms.ErrorProvider ep_customer;
        private System.Windows.Forms.Panel panel1;
    }
}