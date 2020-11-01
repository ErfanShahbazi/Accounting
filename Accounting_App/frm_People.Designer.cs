namespace Accounting_App
{
    partial class frm_People
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddPerson = new System.Windows.Forms.ToolStripButton();
            this.btnEditPerson = new System.Windows.Forms.ToolStripButton();
            this.btnDeletePerson = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnShowSearchBox = new System.Windows.Forms.ToolStripButton();
            this.dgPeople = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPerson,
            this.btnEditPerson,
            this.btnDeletePerson,
            this.btnRefresh,
            this.btnShowSearchBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::Accounting_App.Properties.Resources._013_plus;
            this.btnAddPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(45, 35);
            this.btnAddPerson.Text = "  Add  ";
            this.btnAddPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Image = global::Accounting_App.Properties.Resources._007_edit;
            this.btnEditPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(43, 35);
            this.btnEditPerson.Text = "  Edit  ";
            this.btnEditPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Image = global::Accounting_App.Properties.Resources._008_error;
            this.btnDeletePerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(44, 35);
            this.btnDeletePerson.Text = "Delete";
            this.btnDeletePerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Accounting_App.Properties.Resources._001_share;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 35);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShowSearchBox
            // 
            this.btnShowSearchBox.Image = global::Accounting_App.Properties.Resources._018_search;
            this.btnShowSearchBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowSearchBox.Name = "btnShowSearchBox";
            this.btnShowSearchBox.Size = new System.Drawing.Size(46, 35);
            this.btnShowSearchBox.Text = "Search";
            this.btnShowSearchBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowSearchBox.Click += new System.EventHandler(this.btnShowSearchBox_Click);
            // 
            // dgPeople
            // 
            this.dgPeople.AllowUserToAddRows = false;
            this.dgPeople.AllowUserToDeleteRows = false;
            this.dgPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Phone,
            this.Email});
            this.dgPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPeople.Location = new System.Drawing.Point(0, 38);
            this.dgPeople.Name = "dgPeople";
            this.dgPeople.ReadOnly = true;
            this.dgPeople.Size = new System.Drawing.Size(484, 213);
            this.dgPeople.TabIndex = 1;
            this.dgPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 147;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 147;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 147;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(243, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(89, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frm_People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 251);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgPeople);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_People";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "`";
            this.Load += new System.EventHandler(this.frm_People_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddPerson;
        private System.Windows.Forms.ToolStripButton btnEditPerson;
        private System.Windows.Forms.ToolStripButton btnDeletePerson;
        private System.Windows.Forms.DataGridView dgPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnShowSearchBox;
    }
}