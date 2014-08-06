namespace ChocoMambo
{
    partial class frm_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Search));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsASupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ms_search = new System.Windows.Forms.MenuStrip();
            this.tst_close = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.ms_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(391, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(221, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // dgv_search
            // 
            this.dgv_search.AllowUserToDeleteRows = false;
            this.dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_search.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IsASupplier});
            this.dgv_search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_search.Location = new System.Drawing.Point(0, 38);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.ReadOnly = true;
            this.dgv_search.Size = new System.Drawing.Size(624, 304);
            this.dgv_search.TabIndex = 1;
            this.dgv_search.DoubleClick += new System.EventHandler(this.dgv_search_DoubleClick);
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
            // IsASupplier
            // 
            this.IsASupplier.DataPropertyName = "IsASupplier";
            this.IsASupplier.HeaderText = "IsASupplier";
            this.IsASupplier.Name = "IsASupplier";
            this.IsASupplier.ReadOnly = true;
            this.IsASupplier.Visible = false;
            this.IsASupplier.Width = 85;
            // 
            // ms_search
            // 
            this.ms_search.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_close,
            this.tst_delete});
            this.ms_search.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_search.Location = new System.Drawing.Point(0, 0);
            this.ms_search.Name = "ms_search";
            this.ms_search.Size = new System.Drawing.Size(624, 24);
            this.ms_search.TabIndex = 3;
            this.ms_search.Visible = false;
            // 
            // tst_close
            // 
            this.tst_close.Image = global::ChocoMambo.Properties.Resources.close;
            this.tst_close.Name = "tst_close";
            this.tst_close.Size = new System.Drawing.Size(28, 20);
            this.tst_close.ToolTipText = "Close";
            this.tst_close.Click += new System.EventHandler(this.tst_close_Click);
            // 
            // tst_delete
            // 
            this.tst_delete.Image = global::ChocoMambo.Properties.Resources.Recycle_Bin_icon;
            this.tst_delete.Name = "tst_delete";
            this.tst_delete.Size = new System.Drawing.Size(28, 20);
            this.tst_delete.Click += new System.EventHandler(this.tst_delete_Click);
            // 
            // frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(624, 342);
            this.Controls.Add(this.dgv_search);
            this.Controls.Add(this.ms_search);
            this.Controls.Add(this.txt_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frm_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.ms_search.ResumeLayout(false);
            this.ms_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.MenuStrip ms_search;
        private System.Windows.Forms.ToolStripMenuItem tst_close;
        private System.Windows.Forms.ToolStripMenuItem tst_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsASupplier;
    }
}