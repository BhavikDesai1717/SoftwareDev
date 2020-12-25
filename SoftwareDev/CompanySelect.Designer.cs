namespace SoftwareDev
{
    partial class CompanySelect
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
            this.dg_CompanySelect = new System.Windows.Forms.DataGridView();
            this.companyProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_FinancialYearSelect = new System.Windows.Forms.DataGridView();
            this.btn_Start_Company = new System.Windows.Forms.Button();
            this.finanialYearStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financialYearEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financialYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialYearDataSet = new SoftwareDev.FinancialYearDataSet();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyProfileDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyProfileDataSet = new SoftwareDev.CompanyProfileDataSet();
            this.companyProfileTableAdapter = new SoftwareDev.CompanyProfileDataSetTableAdapters.CompanyProfileTableAdapter();
            this.financialYearTableAdapter = new SoftwareDev.FinancialYearDataSetTableAdapters.FinancialYearTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CompanySelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_FinancialYearSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialYearDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProfileDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProfileDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_CompanySelect
            // 
            this.dg_CompanySelect.AllowUserToAddRows = false;
            this.dg_CompanySelect.AllowUserToDeleteRows = false;
            this.dg_CompanySelect.AutoGenerateColumns = false;
            this.dg_CompanySelect.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_CompanySelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_CompanySelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn});
            this.dg_CompanySelect.DataSource = this.companyProfileBindingSource;
            this.dg_CompanySelect.Location = new System.Drawing.Point(12, 60);
            this.dg_CompanySelect.Name = "dg_CompanySelect";
            this.dg_CompanySelect.ReadOnly = true;
            this.dg_CompanySelect.Size = new System.Drawing.Size(237, 150);
            this.dg_CompanySelect.TabIndex = 1;
            this.dg_CompanySelect.TabStop = false;
            // 
            // companyProfileBindingSource
            // 
            this.companyProfileBindingSource.DataMember = "CompanyProfile";
            this.companyProfileBindingSource.DataSource = this.companyProfileDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Financial Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Company";
            this.label2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.label2_PreviewKeyDown);
            // 
            // dg_FinancialYearSelect
            // 
            this.dg_FinancialYearSelect.AllowUserToAddRows = false;
            this.dg_FinancialYearSelect.AllowUserToDeleteRows = false;
            this.dg_FinancialYearSelect.AutoGenerateColumns = false;
            this.dg_FinancialYearSelect.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_FinancialYearSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_FinancialYearSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.finanialYearStartDataGridViewTextBoxColumn,
            this.financialYearEndDataGridViewTextBoxColumn});
            this.dg_FinancialYearSelect.DataSource = this.financialYearBindingSource;
            this.dg_FinancialYearSelect.Location = new System.Drawing.Point(12, 256);
            this.dg_FinancialYearSelect.Name = "dg_FinancialYearSelect";
            this.dg_FinancialYearSelect.ReadOnly = true;
            this.dg_FinancialYearSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_FinancialYearSelect.Size = new System.Drawing.Size(240, 150);
            this.dg_FinancialYearSelect.TabIndex = 2;
            this.dg_FinancialYearSelect.TabStop = false;
            // 
            // btn_Start_Company
            // 
            this.btn_Start_Company.Location = new System.Drawing.Point(174, 415);
            this.btn_Start_Company.Name = "btn_Start_Company";
            this.btn_Start_Company.Size = new System.Drawing.Size(75, 23);
            this.btn_Start_Company.TabIndex = 0;
            this.btn_Start_Company.Text = "OK";
            this.btn_Start_Company.UseVisualStyleBackColor = true;
            this.btn_Start_Company.Click += new System.EventHandler(this.btn_Start_Company_Click);
            // 
            // finanialYearStartDataGridViewTextBoxColumn
            // 
            this.finanialYearStartDataGridViewTextBoxColumn.DataPropertyName = "finanialYearStart";
            this.finanialYearStartDataGridViewTextBoxColumn.HeaderText = "Finanial Year Start";
            this.finanialYearStartDataGridViewTextBoxColumn.Name = "finanialYearStartDataGridViewTextBoxColumn";
            this.finanialYearStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // financialYearEndDataGridViewTextBoxColumn
            // 
            this.financialYearEndDataGridViewTextBoxColumn.DataPropertyName = "financialYearEnd";
            this.financialYearEndDataGridViewTextBoxColumn.HeaderText = "Financial Year End";
            this.financialYearEndDataGridViewTextBoxColumn.Name = "financialYearEndDataGridViewTextBoxColumn";
            this.financialYearEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // financialYearBindingSource
            // 
            this.financialYearBindingSource.DataMember = "FinancialYear";
            this.financialYearBindingSource.DataSource = this.financialYearDataSet;
            // 
            // financialYearDataSet
            // 
            this.financialYearDataSet.DataSetName = "FinancialYearDataSet";
            this.financialYearDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyNameDataGridViewTextBoxColumn.Width = 190;
            // 
            // companyProfileDataSetBindingSource
            // 
            this.companyProfileDataSetBindingSource.DataSource = this.companyProfileDataSet;
            this.companyProfileDataSetBindingSource.Position = 0;
            // 
            // companyProfileDataSet
            // 
            this.companyProfileDataSet.DataSetName = "CompanyProfileDataSet";
            this.companyProfileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyProfileTableAdapter
            // 
            this.companyProfileTableAdapter.ClearBeforeFill = true;
            // 
            // financialYearTableAdapter
            // 
            this.financialYearTableAdapter.ClearBeforeFill = true;
            // 
            // CompanySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 450);
            this.Controls.Add(this.btn_Start_Company);
            this.Controls.Add(this.dg_FinancialYearSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_CompanySelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanySelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Select";
            this.Load += new System.EventHandler(this.CompanySelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanySelect_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dg_CompanySelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_FinancialYearSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialYearDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProfileDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProfileDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_CompanySelect;
        private System.Windows.Forms.BindingSource companyProfileDataSetBindingSource;
        private CompanyProfileDataSet companyProfileDataSet;
        private System.Windows.Forms.BindingSource companyProfileBindingSource;
        private CompanyProfileDataSetTableAdapters.CompanyProfileTableAdapter companyProfileTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_FinancialYearSelect;
        private FinancialYearDataSet financialYearDataSet;
        private System.Windows.Forms.BindingSource financialYearBindingSource;
        private FinancialYearDataSetTableAdapters.FinancialYearTableAdapter financialYearTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn finanialYearStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn financialYearEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Start_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
    }
}