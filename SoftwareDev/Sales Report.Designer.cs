namespace SoftwareDev
{
    partial class Sales_Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_SalesReport = new System.Windows.Forms.Label();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.dg_InvoiceReport = new System.Windows.Forms.DataGridView();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleInvoiceDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesInvoiceDataSet = new SoftwareDev.SalesInvoiceDataSet();
            this.saleInvoiceDBTableAdapter = new SoftwareDev.SalesInvoiceDataSetTableAdapters.SaleInvoiceDBTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_InvoiceReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleInvoiceDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_SalesReport);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 68);
            this.panel1.TabIndex = 0;
            // 
            // lbl_SalesReport
            // 
            this.lbl_SalesReport.AutoSize = true;
            this.lbl_SalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesReport.Location = new System.Drawing.Point(258, 22);
            this.lbl_SalesReport.Name = "lbl_SalesReport";
            this.lbl_SalesReport.Size = new System.Drawing.Size(144, 24);
            this.lbl_SalesReport.TabIndex = 0;
            this.lbl_SalesReport.Text = "Sales Register";
            // 
            // cmb_Month
            // 
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_Month.Location = new System.Drawing.Point(59, 75);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(84, 21);
            this.cmb_Month.TabIndex = 1;
            // 
            // dg_InvoiceReport
            // 
            this.dg_InvoiceReport.AllowUserToAddRows = false;
            this.dg_InvoiceReport.AllowUserToDeleteRows = false;
            this.dg_InvoiceReport.AutoGenerateColumns = false;
            this.dg_InvoiceReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_InvoiceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_InvoiceReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNoDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.shortCodeDataGridViewTextBoxColumn,
            this.mSDataGridViewTextBoxColumn,
            this.narrationDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.saleCurrencyDataGridViewTextBoxColumn});
            this.dg_InvoiceReport.DataSource = this.saleInvoiceDBBindingSource;
            this.dg_InvoiceReport.Location = new System.Drawing.Point(6, 106);
            this.dg_InvoiceReport.Name = "dg_InvoiceReport";
            this.dg_InvoiceReport.ReadOnly = true;
            this.dg_InvoiceReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_InvoiceReport.Size = new System.Drawing.Size(645, 397);
            this.dg_InvoiceReport.TabIndex = 2;
            this.dg_InvoiceReport.TabStop = false;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "Invoice No";
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "Invoice_Date";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "Invoice Date";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shortCodeDataGridViewTextBoxColumn
            // 
            this.shortCodeDataGridViewTextBoxColumn.DataPropertyName = "ShortCode";
            this.shortCodeDataGridViewTextBoxColumn.HeaderText = "ShortCode";
            this.shortCodeDataGridViewTextBoxColumn.Name = "shortCodeDataGridViewTextBoxColumn";
            this.shortCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.shortCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // mSDataGridViewTextBoxColumn
            // 
            this.mSDataGridViewTextBoxColumn.DataPropertyName = "MS";
            this.mSDataGridViewTextBoxColumn.HeaderText = "M/S";
            this.mSDataGridViewTextBoxColumn.Name = "mSDataGridViewTextBoxColumn";
            this.mSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narrationDataGridViewTextBoxColumn
            // 
            this.narrationDataGridViewTextBoxColumn.DataPropertyName = "Narration";
            this.narrationDataGridViewTextBoxColumn.HeaderText = "Narration";
            this.narrationDataGridViewTextBoxColumn.Name = "narrationDataGridViewTextBoxColumn";
            this.narrationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleCurrencyDataGridViewTextBoxColumn
            // 
            this.saleCurrencyDataGridViewTextBoxColumn.DataPropertyName = "SaleCurrency";
            this.saleCurrencyDataGridViewTextBoxColumn.HeaderText = "Sale Currency";
            this.saleCurrencyDataGridViewTextBoxColumn.Name = "saleCurrencyDataGridViewTextBoxColumn";
            this.saleCurrencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleInvoiceDBBindingSource
            // 
            this.saleInvoiceDBBindingSource.DataMember = "SaleInvoiceDB";
            this.saleInvoiceDBBindingSource.DataSource = this.salesInvoiceDataSet;
            // 
            // salesInvoiceDataSet
            // 
            this.salesInvoiceDataSet.DataSetName = "SalesInvoiceDataSet";
            this.salesInvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleInvoiceDBTableAdapter
            // 
            this.saleInvoiceDBTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(2, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 405);
            this.panel2.TabIndex = 3;
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Month.Location = new System.Drawing.Point(3, 76);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(50, 16);
            this.lbl_Month.TabIndex = 4;
            this.lbl_Month.Text = "Month :";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(166, 76);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(43, 16);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "Date :";
            // 
            // dt_Date
            // 
            this.dt_Date.Location = new System.Drawing.Point(216, 75);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Size = new System.Drawing.Size(117, 20);
            this.dt_Date.TabIndex = 5;
            this.dt_Date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dt_Date_KeyDown);
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 508);
            this.Controls.Add(this.dt_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Month);
            this.Controls.Add(this.dg_InvoiceReport);
            this.Controls.Add(this.cmb_Month);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Sales_Report";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.Sales_Report_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sales_Report_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_InvoiceReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleInvoiceDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_SalesReport;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.DataGridView dg_InvoiceReport;
        private SalesInvoiceDataSet salesInvoiceDataSet;
        private System.Windows.Forms.BindingSource saleInvoiceDBBindingSource;
        private SalesInvoiceDataSetTableAdapters.SaleInvoiceDBTableAdapter saleInvoiceDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dt_Date;
    }
}