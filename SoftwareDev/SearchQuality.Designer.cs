namespace SoftwareDev
{
    partial class SearchQuality
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
            this.dg_SearchQuality = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQualityDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.productQualityDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ProductQualityDBTableAdapter();
            this.txt_searchQuality = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SearchQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQualityDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_SearchQuality
            // 
            this.dg_SearchQuality.AllowUserToAddRows = false;
            this.dg_SearchQuality.AllowUserToDeleteRows = false;
            this.dg_SearchQuality.AutoGenerateColumns = false;
            this.dg_SearchQuality.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_SearchQuality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_SearchQuality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.srNoDataGridViewTextBoxColumn,
            this.qualityCodeDataGridViewTextBoxColumn,
            this.productQualityDataGridViewTextBoxColumn});
            this.dg_SearchQuality.DataSource = this.productQualityDBBindingSource;
            this.dg_SearchQuality.Location = new System.Drawing.Point(12, 36);
            this.dg_SearchQuality.Name = "dg_SearchQuality";
            this.dg_SearchQuality.ReadOnly = true;
            this.dg_SearchQuality.Size = new System.Drawing.Size(344, 256);
            this.dg_SearchQuality.TabIndex = 1;
            this.dg_SearchQuality.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SearchQuality_CellDoubleClick);
            this.dg_SearchQuality.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_SearchQuality_RowPostPaint);
            this.dg_SearchQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_SearchQuality_KeyDown);
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
            // qualityCodeDataGridViewTextBoxColumn
            // 
            this.qualityCodeDataGridViewTextBoxColumn.DataPropertyName = "QualityCode";
            this.qualityCodeDataGridViewTextBoxColumn.HeaderText = "Quality Code";
            this.qualityCodeDataGridViewTextBoxColumn.Name = "qualityCodeDataGridViewTextBoxColumn";
            this.qualityCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productQualityDataGridViewTextBoxColumn
            // 
            this.productQualityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuality";
            this.productQualityDataGridViewTextBoxColumn.HeaderText = "Quality";
            this.productQualityDataGridViewTextBoxColumn.Name = "productQualityDataGridViewTextBoxColumn";
            this.productQualityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productQualityDBBindingSource
            // 
            this.productQualityDBBindingSource.DataMember = "ProductQualityDB";
            this.productQualityDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productQualityDBTableAdapter
            // 
            this.productQualityDBTableAdapter.ClearBeforeFill = true;
            // 
            // txt_searchQuality
            // 
            this.txt_searchQuality.Location = new System.Drawing.Point(12, 10);
            this.txt_searchQuality.Name = "txt_searchQuality";
            this.txt_searchQuality.Size = new System.Drawing.Size(344, 20);
            this.txt_searchQuality.TabIndex = 0;
            this.txt_searchQuality.TextChanged += new System.EventHandler(this.txt_searchQuality_TextChanged);
            this.txt_searchQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_searchQuality_KeyDown);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(281, 298);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add New";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // SearchQuality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 333);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_searchQuality);
            this.Controls.Add(this.dg_SearchQuality);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuality";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuality";
            this.Load += new System.EventHandler(this.SearchQuality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_SearchQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQualityDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_SearchQuality;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productQualityDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductQualityDBTableAdapter productQualityDBTableAdapter;
        private System.Windows.Forms.TextBox txt_searchQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Add;
    }
}