namespace SoftwareDev
{
    partial class SearchClient
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
            this.txt_searchClient = new System.Windows.Forms.TextBox();
            this.dg_searchClient = new System.Windows.Forms.DataGridView();
            this.shortCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.clientDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ClientDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dg_searchClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_searchClient
            // 
            this.txt_searchClient.Location = new System.Drawing.Point(13, 13);
            this.txt_searchClient.Name = "txt_searchClient";
            this.txt_searchClient.Size = new System.Drawing.Size(444, 20);
            this.txt_searchClient.TabIndex = 0;
            this.txt_searchClient.TextChanged += new System.EventHandler(this.txt_searchClient_TextChanged);
            // 
            // dg_searchClient
            // 
            this.dg_searchClient.AllowUserToAddRows = false;
            this.dg_searchClient.AllowUserToDeleteRows = false;
            this.dg_searchClient.AutoGenerateColumns = false;
            this.dg_searchClient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_searchClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_searchClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shortCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn});
            this.dg_searchClient.DataSource = this.clientDBBindingSource;
            this.dg_searchClient.Location = new System.Drawing.Point(13, 39);
            this.dg_searchClient.Name = "dg_searchClient";
            this.dg_searchClient.ReadOnly = true;
            this.dg_searchClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_searchClient.Size = new System.Drawing.Size(444, 278);
            this.dg_searchClient.TabIndex = 1;
            this.dg_searchClient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_searchClient_CellDoubleClick);
            // 
            // shortCodeDataGridViewTextBoxColumn
            // 
            this.shortCodeDataGridViewTextBoxColumn.DataPropertyName = "ShortCode";
            this.shortCodeDataGridViewTextBoxColumn.HeaderText = "ShortCode";
            this.shortCodeDataGridViewTextBoxColumn.Name = "shortCodeDataGridViewTextBoxColumn";
            this.shortCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDBBindingSource
            // 
            this.clientDBBindingSource.DataMember = "ClientDB";
            this.clientDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientDBTableAdapter
            // 
            this.clientDBTableAdapter.ClearBeforeFill = true;
            // 
            // SearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 329);
            this.Controls.Add(this.dg_searchClient);
            this.Controls.Add(this.txt_searchClient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchClient";
            this.Load += new System.EventHandler(this.SearchClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_searchClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_searchClient;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource clientDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ClientDBTableAdapter clientDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dg_searchClient;
    }
}