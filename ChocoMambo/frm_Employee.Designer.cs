namespace ChocoMambo
{
    partial class frm_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Employee));
            this.ms_employee = new System.Windows.Forms.MenuStrip();
            this.tsi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_close = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_houseNumber = new System.Windows.Forms.TextBox();
            this.txt_streetName = new System.Windows.Forms.TextBox();
            this.txt_suburb = new System.Windows.Forms.TextBox();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.ep_employee = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ms_employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_employee
            // 
            this.ms_employee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_save,
            this.tst_close});
            this.ms_employee.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_employee.Location = new System.Drawing.Point(0, 0);
            this.ms_employee.Name = "ms_employee";
            this.ms_employee.Size = new System.Drawing.Size(304, 24);
            this.ms_employee.TabIndex = 2;
            this.ms_employee.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Phone#:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "House#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Street Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Suburb:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "State:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Postcode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Department:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Salary:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(84, 58);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(208, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_houseNumber
            // 
            this.txt_houseNumber.Location = new System.Drawing.Point(84, 110);
            this.txt_houseNumber.Name = "txt_houseNumber";
            this.txt_houseNumber.Size = new System.Drawing.Size(208, 20);
            this.txt_houseNumber.TabIndex = 3;
            // 
            // txt_streetName
            // 
            this.txt_streetName.Location = new System.Drawing.Point(84, 136);
            this.txt_streetName.Name = "txt_streetName";
            this.txt_streetName.Size = new System.Drawing.Size(208, 20);
            this.txt_streetName.TabIndex = 4;
            // 
            // txt_suburb
            // 
            this.txt_suburb.Location = new System.Drawing.Point(84, 162);
            this.txt_suburb.Name = "txt_suburb";
            this.txt_suburb.Size = new System.Drawing.Size(208, 20);
            this.txt_suburb.TabIndex = 5;
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(84, 188);
            this.txt_state.MaxLength = 3;
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(208, 20);
            this.txt_state.TabIndex = 6;
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(84, 240);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(208, 20);
            this.txt_department.TabIndex = 8;
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(84, 84);
            this.txt_phoneNumber.MaxLength = 10;
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(208, 20);
            this.txt_phoneNumber.TabIndex = 2;
            this.txt_phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phoneNumber_KeyPress);
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(84, 214);
            this.txt_postcode.MaxLength = 4;
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(208, 20);
            this.txt_postcode.TabIndex = 7;
            this.txt_postcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_postcode_KeyPress);
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(84, 266);
            this.txt_salary.MaxLength = 6;
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(208, 20);
            this.txt_salary.TabIndex = 9;
            this.txt_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // ep_employee
            // 
            this.ep_employee.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 52);
            this.panel1.TabIndex = 100;
            // 
            // frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_postcode);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.txt_state);
            this.Controls.Add(this.txt_suburb);
            this.Controls.Add(this.txt_streetName);
            this.Controls.Add(this.txt_houseNumber);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ms_employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_employee;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 380);
            this.MinimizeBox = false;
            this.Name = "frm_Employee";
            this.Text = "Employee";
            this.ms_employee.ResumeLayout(false);
            this.ms_employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_employee;
        private System.Windows.Forms.ToolStripMenuItem tst_close;
        private System.Windows.Forms.ToolStripMenuItem tsi_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_houseNumber;
        private System.Windows.Forms.TextBox txt_streetName;
        private System.Windows.Forms.TextBox txt_suburb;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.ErrorProvider ep_employee;
        private System.Windows.Forms.Panel panel1;

    }
}