namespace SoftwareDev
{
    partial class SearchSize
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
            this.dg_sizeSearch = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSizeDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.productSizeDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ProductSizeDBTableAdapter();
            this.txt_sizeSearch = new System.Windows.Forms.TextBox();
            this.btn_AddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_sizeSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_sizeSearch
            // 
            this.dg_sizeSearch.AllowUserToAddRows = false;
            this.dg_sizeSearch.AllowUserToDeleteRows = false;
            this.dg_sizeSearch.AutoGenerateColumns = false;
            this.dg_sizeSearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_sizeSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_sizeSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.srNoDataGridViewTextBoxColumn,
            this.sizeCodeDataGridViewTextBoxColumn,
            this.productSizeDataGridViewTextBoxColumn});
            this.dg_sizeSearch.DataSource = this.productSizeDBBindingSource;
            this.dg_sizeSearch.Location = new System.Drawing.Point(12, 38);
            this.dg_sizeSearch.Name = "dg_sizeSearch";
            this.dg_sizeSearch.ReadOnly = true;
            this.dg_sizeSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_sizeSearch.Size = new System.Drawing.Size(343, 279);
            this.dg_sizeSearch.TabIndex = 1;
            this.dg_sizeSearch.TabStop = false;
            this.dg_sizeSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_sizeSearch_CellDoubleClick);
            this.dg_sizeSearch.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_sizeSearch_RowPostPaint);
            this.dg_sizeSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_sizeSearch_KeyDown);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "Sr. No.";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // srNoDataGridViewTextBoxColumn
            // 
            this.srNoDataGridViewTextBoxColumn.DataPropertyName = "SrNo";
            this.srNoDataGridViewTextBoxColumn.HeaderText = "SrNo";
            this.srNoDataGridViewTextBoxColumn.Name = "srNoDataGridViewTextBoxColumn";
            this.srNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.srNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // sizeCodeDataGridViewTextBoxColumn
            // 
            this.sizeCodeDataGridViewTextBoxColumn.DataPropertyName = "SizeCode";
            this.sizeCodeDataGridViewTextBoxColumn.HeaderText = "Size Code";
            this.sizeCodeDataGridViewTextBoxColumn.Name = "sizeCodeDataGridViewTextBoxColumn";
            this.sizeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productSizeDataGridViewTextBoxColumn
            // 
            this.productSizeDataGridViewTextBoxColumn.DataPropertyName = "ProductSize";
            this.productSizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.productSizeDataGridViewTextBoxColumn.Name = "productSizeDataGridViewTextBoxColumn";
            this.productSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productSizeDBBindingSource
            // 
            this.productSizeDBBindingSource.DataMember = "ProductSizeDB";
            this.productSizeDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productSizeDBTableAdapter
            // 
            this.productSizeDBTableAdapter.ClearBeforeFill = true;
            // 
            // txt_sizeSearch
            // 
            this.txt_sizeSearch.Location = new System.Drawing.Point(12, 12);
            this.txt_sizeSearch.Name = "txt_sizeSearch";
            this.txt_sizeSearch.Size = new System.Drawing.Size(343, 20);
            this.txt_sizeSearch.TabIndex = 0;
            this.txt_sizeSearch.TextChanged += new System.EventHandler(this.txt_sizeSearch_TextChanged);
            this.txt_sizeSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sizeSearch_KeyDown);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(280, 323);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNew.TabIndex = 2;
            this.btn_AddNew.Text = "Add New";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // SearchSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 358);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.txt_sizeSearch);
            this.Controls.Add(this.dg_sizeSearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchColor";
            this.Load += new System.EventHandler(this.SearchSize_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchSize_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dg_sizeSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productSizeDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductSizeDBTableAdapter productSizeDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_sizeSearch;
        public System.Windows.Forms.DataGridView dg_sizeSearch;
        private System.Windows.Forms.Button btn_AddNew;
    }
}