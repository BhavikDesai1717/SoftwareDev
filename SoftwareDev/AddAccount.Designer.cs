namespace SoftwareDev
{
    partial class AddAccount
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
            this.btn_CloseAccount = new System.Windows.Forms.Button();
            this.btn_ExportAccount = new System.Windows.Forms.Button();
            this.btn_ImportAccount = new System.Windows.Forms.Button();
            this.btn_DeleteAccount = new System.Windows.Forms.Button();
            this.btn_DsiplayAccount = new System.Windows.Forms.Button();
            this.btn_EditAccount = new System.Windows.Forms.Button();
            this.btn_AddNewAccount = new System.Windows.Forms.Button();
            this.dg_AccountDB = new System.Windows.Forms.DataGridView();
            this.SNoAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.accountDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.AccountDBTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dg_AccountDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CloseAccount
            // 
            this.btn_CloseAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseAccount.Location = new System.Drawing.Point(264, 222);
            this.btn_CloseAccount.Name = "btn_CloseAccount";
            this.btn_CloseAccount.Size = new System.Drawing.Size(75, 24);
            this.btn_CloseAccount.TabIndex = 15;
            this.btn_CloseAccount.Text = "Close";
            this.btn_CloseAccount.UseVisualStyleBackColor = true;
            this.btn_CloseAccount.Click += new System.EventHandler(this.btn_CloseAccount_Click);
            this.btn_CloseAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_CloseAccount_KeyDown);
            // 
            // btn_ExportAccount
            // 
            this.btn_ExportAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportAccount.Location = new System.Drawing.Point(264, 187);
            this.btn_ExportAccount.Name = "btn_ExportAccount";
            this.btn_ExportAccount.Size = new System.Drawing.Size(75, 24);
            this.btn_ExportAccount.TabIndex = 14;
            this.btn_ExportAccount.Text = "Export";
            this.btn_ExportAccount.UseVisualStyleBackColor = true;
            this.btn_ExportAccount.Click += new System.EventHandler(this.btn_ExportAccount_Click);
            // 
            // btn_ImportAccount
            // 
            this.btn_ImportAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportAccount.Location = new System.Drawing.Point(264, 152);
            this.btn_ImportAccount.Name = "btn_ImportAccount";
            this.btn_ImportAccount.Size = new System.Drawing.Size(75, 24);
            this.btn_ImportAccount.TabIndex = 13;
            this.btn_ImportAccount.Text = "Import";
            this.btn_ImportAccount.UseVisualStyleBackColor = true;
            this.btn_ImportAccount.Click += new System.EventHandler(this.btn_ImportAccount_Click);
            // 
            // btn_DeleteAccount
            // 
            this.btn_DeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteAccount.Location = new System.Drawing.Point(264, 117);
            this.btn_DeleteAccount.Name = "btn_DeleteAccount";
            this.btn_DeleteAccount.Size = new System.Drawing.Size(75, 24);
            this.btn_DeleteAccount.TabIndex = 12;
            this.btn_DeleteAccount.Text = "Delete";
            this.btn_DeleteAccount.UseVisualStyleBackColor = true;
            this.btn_DeleteAccount.Click += new System.EventHandler(this.btn_DeleteAccount_Click);
            this.btn_DeleteAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DeleteAccount_KeyDown);
            // 
            // btn_DsiplayAccount
            // 
            this.btn_DsiplayAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DsiplayAccount.Location = new System.Drawing.Point(264, 82);
            this.btn_DsiplayAccount.Name = "btn_DsiplayAccount";
            this.btn_DsiplayAccount.Size = new System.Drawing.Size(75, 24);
            this.btn_DsiplayAccount.TabIndex = 10;
            this.btn_DsiplayAccount.Text = "Display";
            this.btn_DsiplayAccount.UseVisualStyleBackColor = true;
            this.btn_DsiplayAccount.Click += new System.EventHandler(this.btn_DsiplayAccount_Click);
            this.btn_DsiplayAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DsiplayAccount_KeyDown);
            // 
            // btn_EditAccount
            // 
            this.btn_EditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditAccount.Location = new System.Drawing.Point(264, 47);
            this.btn_EditAccount.Name = "btn_EditAccount";
            this.btn_EditAccount.Size = new System.Drawing.Size(75, 24);
            this.btn_EditAccount.TabIndex = 9;
            this.btn_EditAccount.Text = "Edit";
            this.btn_EditAccount.UseVisualStyleBackColor = true;
            this.btn_EditAccount.Click += new System.EventHandler(this.btn_EditAccount_Click);
            this.btn_EditAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_EditAccount_KeyDown);
            // 
            // btn_AddNewAccount
            // 
            this.btn_AddNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewAccount.Location = new System.Drawing.Point(264, 12);
            this.btn_AddNewAccount.Name = "btn_AddNewAccount";
            this.btn_AddNewAccount.Size = new System.Drawing.Size(75, 24);
            this.btn_AddNewAccount.TabIndex = 7;
            this.btn_AddNewAccount.Text = "Add New";
            this.btn_AddNewAccount.UseVisualStyleBackColor = true;
            this.btn_AddNewAccount.Click += new System.EventHandler(this.btn_AddNewAccount_Click);
            this.btn_AddNewAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_AddNewAccount_KeyDown);
            // 
            // dg_AccountDB
            // 
            this.dg_AccountDB.AllowUserToAddRows = false;
            this.dg_AccountDB.AllowUserToDeleteRows = false;
            this.dg_AccountDB.AutoGenerateColumns = false;
            this.dg_AccountDB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_AccountDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_AccountDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNoAccount,
            this.accountDataGridViewTextBoxColumn,
            this.srNoDataGridViewTextBoxColumn});
            this.dg_AccountDB.DataSource = this.accountDBBindingSource;
            this.dg_AccountDB.Location = new System.Drawing.Point(12, 12);
            this.dg_AccountDB.Name = "dg_AccountDB";
            this.dg_AccountDB.ReadOnly = true;
            this.dg_AccountDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_AccountDB.Size = new System.Drawing.Size(246, 248);
            this.dg_AccountDB.TabIndex = 8;
            this.dg_AccountDB.TabStop = false;
            this.dg_AccountDB.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_AccountDB_RowPostPaint);
            // 
            // SNoAccount
            // 
            this.SNoAccount.HeaderText = "Sr. No.";
            this.SNoAccount.Name = "SNoAccount";
            this.SNoAccount.ReadOnly = true;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // srNoDataGridViewTextBoxColumn
            // 
            this.srNoDataGridViewTextBoxColumn.DataPropertyName = "SrNo";
            this.srNoDataGridViewTextBoxColumn.HeaderText = "SrNo";
            this.srNoDataGridViewTextBoxColumn.Name = "srNoDataGridViewTextBoxColumn";
            this.srNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.srNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountDBBindingSource
            // 
            this.accountDBBindingSource.DataMember = "AccountDB";
            this.accountDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountDBTableAdapter
            // 
            this.accountDBTableAdapter.ClearBeforeFill = true;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 288);
            this.Controls.Add(this.btn_CloseAccount);
            this.Controls.Add(this.btn_ExportAccount);
            this.Controls.Add(this.btn_ImportAccount);
            this.Controls.Add(this.btn_DeleteAccount);
            this.Controls.Add(this.btn_DsiplayAccount);
            this.Controls.Add(this.btn_EditAccount);
            this.Controls.Add(this.btn_AddNewAccount);
            this.Controls.Add(this.dg_AccountDB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_AccountDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_CloseAccount;
        private System.Windows.Forms.Button btn_ExportAccount;
        private System.Windows.Forms.Button btn_ImportAccount;
        private System.Windows.Forms.Button btn_DeleteAccount;
        private System.Windows.Forms.Button btn_DsiplayAccount;
        private System.Windows.Forms.Button btn_EditAccount;
        private System.Windows.Forms.Button btn_AddNewAccount;
        private System.Windows.Forms.DataGridView dg_AccountDB;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource accountDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.AccountDBTableAdapter accountDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNoAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNoDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}