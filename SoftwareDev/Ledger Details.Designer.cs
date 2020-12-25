namespace SoftwareDev
{
    partial class Ledger_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salesInvoiceDataSet = new SoftwareDev.SalesInvoiceDataSet();
            this.saleInvoiceDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleInvoiceDBTableAdapter = new SoftwareDev.SalesInvoiceDataSetTableAdapters.SaleInvoiceDBTableAdapter();
            this.lbl_ClientName = new System.Windows.Forms.Label();
            this.dg_LedgerDetails = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleInvoiceDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_LedgerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_ClientName);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 74);
            this.panel1.TabIndex = 0;
            // 
            // salesInvoiceDataSet
            // 
            this.salesInvoiceDataSet.DataSetName = "SalesInvoiceDataSet";
            this.salesInvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleInvoiceDBBindingSource
            // 
            this.saleInvoiceDBBindingSource.DataMember = "SaleInvoiceDB";
            this.saleInvoiceDBBindingSource.DataSource = this.salesInvoiceDataSet;
            // 
            // saleInvoiceDBTableAdapter
            // 
            this.saleInvoiceDBTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_ClientName
            // 
            this.lbl_ClientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ClientName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientName.Location = new System.Drawing.Point(0, 0);
            this.lbl_ClientName.Name = "lbl_ClientName";
            this.lbl_ClientName.Size = new System.Drawing.Size(747, 72);
            this.lbl_ClientName.TabIndex = 2;
            this.lbl_ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dg_LedgerDetails
            // 
            this.dg_LedgerDetails.AllowUserToAddRows = false;
            this.dg_LedgerDetails.AllowUserToDeleteRows = false;
            this.dg_LedgerDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_LedgerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_LedgerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.Debit,
            this.Credit,
            this.ClosingBalance});
            this.dg_LedgerDetails.Location = new System.Drawing.Point(5, 82);
            this.dg_LedgerDetails.Name = "dg_LedgerDetails";
            this.dg_LedgerDetails.ReadOnly = true;
            this.dg_LedgerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_LedgerDetails.Size = new System.Drawing.Size(744, 356);
            this.dg_LedgerDetails.TabIndex = 1;
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Width = 250;
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            this.Debit.Width = 150;
            // 
            // Credit
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.Credit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Width = 150;
            // 
            // ClosingBalance
            // 
            dataGridViewCellStyle2.NullValue = "Nil...";
            this.ClosingBalance.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClosingBalance.HeaderText = "Closing Balance";
            this.ClosingBalance.Name = "ClosingBalance";
            this.ClosingBalance.ReadOnly = true;
            this.ClosingBalance.Width = 150;
            // 
            // Ledger_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.dg_LedgerDetails);
            this.Controls.Add(this.panel1);
            this.Name = "Ledger_Details";
            this.Text = "Ledger Details";
            this.Load += new System.EventHandler(this.Ledger_Details_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleInvoiceDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_LedgerDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private SalesInvoiceDataSet salesInvoiceDataSet;
        private System.Windows.Forms.BindingSource saleInvoiceDBBindingSource;
        private SalesInvoiceDataSetTableAdapters.SaleInvoiceDBTableAdapter saleInvoiceDBTableAdapter;
        private System.Windows.Forms.Label lbl_ClientName;
        private System.Windows.Forms.DataGridView dg_LedgerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosingBalance;
    }
}