namespace ChocoMambo
{
    partial class frm_Permissions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Permissions));
            this.ms_permissions = new System.Windows.Forms.MenuStrip();
            this.tsi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_close = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_permissions = new System.Windows.Forms.DataGridView();
            this.colEmployee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colForm = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colRights = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_filter = new System.Windows.Forms.ComboBox();
            this.ms_permissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_permissions)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_permissions
            // 
            this.ms_permissions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_save,
            this.tst_close});
            this.ms_permissions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_permissions.Location = new System.Drawing.Point(0, 0);
            this.ms_permissions.Name = "ms_permissions";
            this.ms_permissions.ShowItemToolTips = true;
            this.ms_permissions.Size = new System.Drawing.Size(549, 24);
            this.ms_permissions.TabIndex = 9;
            this.ms_permissions.Visible = false;
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
            // dgv_permissions
            // 
            this.dgv_permissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_permissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_permissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_permissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployee,
            this.colForm,
            this.colRights,
            this.ID,
            this.FormID,
            this.EmployeeNumber,
            this.AccessType});
            this.dgv_permissions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_permissions.Location = new System.Drawing.Point(0, 38);
            this.dgv_permissions.Name = "dgv_permissions";
            this.dgv_permissions.Size = new System.Drawing.Size(549, 333);
            this.dgv_permissions.TabIndex = 10;
            // 
            // colEmployee
            // 
            this.colEmployee.HeaderText = "Employee";
            this.colEmployee.Name = "colEmployee";
            // 
            // colForm
            // 
            this.colForm.HeaderText = "Form";
            this.colForm.Name = "colForm";
            // 
            // colRights
            // 
            this.colRights.HeaderText = "Rights";
            this.colRights.Items.AddRange(new object[] {
            "Write",
            "Read",
            "Deny"});
            this.colRights.Name = "colRights";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FormID
            // 
            this.FormID.DataPropertyName = "FormID";
            this.FormID.HeaderText = "FormID";
            this.FormID.Name = "FormID";
            this.FormID.Visible = false;
            // 
            // EmployeeNumber
            // 
            this.EmployeeNumber.DataPropertyName = "EmployeeNumber";
            this.EmployeeNumber.HeaderText = "EmployeeNumber";
            this.EmployeeNumber.Name = "EmployeeNumber";
            this.EmployeeNumber.Visible = false;
            // 
            // AccessType
            // 
            this.AccessType.DataPropertyName = "AccessType";
            this.AccessType.HeaderText = "AccessType";
            this.AccessType.Name = "AccessType";
            this.AccessType.Visible = false;
            // 
            // cbo_filter
            // 
            this.cbo_filter.FormattingEnabled = true;
            this.cbo_filter.Location = new System.Drawing.Point(358, 11);
            this.cbo_filter.Name = "cbo_filter";
            this.cbo_filter.Size = new System.Drawing.Size(179, 21);
            this.cbo_filter.TabIndex = 11;
            this.cbo_filter.SelectedIndexChanged += new System.EventHandler(this.cbo_filter_SelectedIndexChanged);
            // 
            // frm_Permissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(549, 371);
            this.Controls.Add(this.cbo_filter);
            this.Controls.Add(this.dgv_permissions);
            this.Controls.Add(this.ms_permissions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Permissions";
            this.Text = "Permissions";
            this.Load += new System.EventHandler(this.frm_Permissions_Load);
            this.ms_permissions.ResumeLayout(false);
            this.ms_permissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_permissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_permissions;
        private System.Windows.Forms.ToolStripMenuItem tsi_save;
        private System.Windows.Forms.ToolStripMenuItem tst_close;
        private System.Windows.Forms.DataGridView dgv_permissions;
        private System.Windows.Forms.DataGridViewComboBoxColumn colEmployee;
        private System.Windows.Forms.DataGridViewComboBoxColumn colForm;
        private System.Windows.Forms.DataGridViewComboBoxColumn colRights;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessType;
        private System.Windows.Forms.ComboBox cbo_filter;
    }
}