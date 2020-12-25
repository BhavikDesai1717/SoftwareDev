namespace SoftwareDev
{
    partial class SaleInvoice
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
            this.lbl_SelectInvoice = new System.Windows.Forms.Label();
            this.lbl_SaleInvoice = new System.Windows.Forms.Label();
            this.lbl_SaleInvoiceDate = new System.Windows.Forms.Label();
            this.lbl_SaleCurrencySI = new System.Windows.Forms.Label();
            this.dt_SaleInvoice = new System.Windows.Forms.DateTimePicker();
            this.cbo_SaleCurrencySI = new System.Windows.Forms.ComboBox();
            this.cbo_SelectInvoice = new System.Windows.Forms.ComboBox();
            this.saleOrderDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sale_OrderDBDataSet = new SoftwareDev.Sale_OrderDBDataSet();
            this.saleOrderDBTableAdapter = new SoftwareDev.Sale_OrderDBDataSetTableAdapters.SaleOrderDBTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_InvoiceSC = new System.Windows.Forms.TextBox();
            this.txt_InvoiceMS = new System.Windows.Forms.TextBox();
            this.btn_SelectMS = new System.Windows.Forms.Button();
            this.lbl_InvoiceNarration = new System.Windows.Forms.Label();
            this.rt_InvoiceNarration = new System.Windows.Forms.RichTextBox();
            this.tb_InvoiceProductDetails = new System.Windows.Forms.TabControl();
            this.tb_ProductDetails = new System.Windows.Forms.TabPage();
            this.dg_InvoiceProductDetails = new System.Windows.Forms.DataGridView();
            this.SNoInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCodeInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCodeInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityCodeInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateConvInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount1Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount1AmountInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount2Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount2AmountInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount3Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount3AmountInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalAmountInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proPrimaryInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_InvoiceReport = new System.Windows.Forms.DataGridView();
            this.SNoSaleInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleInvoiceDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesInvoiceDataSet = new SoftwareDev.SalesInvoiceDataSet();
            this.lbl_TotalAmountSI = new System.Windows.Forms.Label();
            this.txt_TotalAmountSI = new System.Windows.Forms.TextBox();
            this.btn_SubmitSItoDB = new System.Windows.Forms.Button();
            this.btn_AddNewSI = new System.Windows.Forms.Button();
            this.btn_UpdateSI = new System.Windows.Forms.Button();
            this.btn_DisplaySI = new System.Windows.Forms.Button();
            this.btn_CloseSI = new System.Windows.Forms.Button();
            this.btn_ExportSI = new System.Windows.Forms.Button();
            this.btn_ImportSI = new System.Windows.Forms.Button();
            this.btn_DeleteSI = new System.Windows.Forms.Button();
            this.btn_EditSI = new System.Windows.Forms.Button();
            this.saleInvoiceDBTableAdapter = new SoftwareDev.SalesInvoiceDataSetTableAdapters.SaleInvoiceDBTableAdapter();
            this.txt_SINo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale_OrderDBDataSet)).BeginInit();
            this.tb_InvoiceProductDetails.SuspendLayout();
            this.tb_ProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_InvoiceProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_InvoiceReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleInvoiceDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SelectInvoice
            // 
            this.lbl_SelectInvoice.AutoSize = true;
            this.lbl_SelectInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectInvoice.Location = new System.Drawing.Point(27, 13);
            this.lbl_SelectInvoice.Name = "lbl_SelectInvoice";
            this.lbl_SelectInvoice.Size = new System.Drawing.Size(95, 16);
            this.lbl_SelectInvoice.TabIndex = 0;
            this.lbl_SelectInvoice.Text = "Select SO No.:";
            // 
            // lbl_SaleInvoice
            // 
            this.lbl_SaleInvoice.AutoSize = true;
            this.lbl_SaleInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaleInvoice.Location = new System.Drawing.Point(13, 40);
            this.lbl_SaleInvoice.Name = "lbl_SaleInvoice";
            this.lbl_SaleInvoice.Size = new System.Drawing.Size(109, 16);
            this.lbl_SaleInvoice.TabIndex = 0;
            this.lbl_SaleInvoice.Text = "Sale Invoice No.:";
            // 
            // lbl_SaleInvoiceDate
            // 
            this.lbl_SaleInvoiceDate.AutoSize = true;
            this.lbl_SaleInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaleInvoiceDate.Location = new System.Drawing.Point(217, 41);
            this.lbl_SaleInvoiceDate.Name = "lbl_SaleInvoiceDate";
            this.lbl_SaleInvoiceDate.Size = new System.Drawing.Size(89, 16);
            this.lbl_SaleInvoiceDate.TabIndex = 0;
            this.lbl_SaleInvoiceDate.Text = "Invoice Date :";
            // 
            // lbl_SaleCurrencySI
            // 
            this.lbl_SaleCurrencySI.AutoSize = true;
            this.lbl_SaleCurrencySI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaleCurrencySI.Location = new System.Drawing.Point(437, 40);
            this.lbl_SaleCurrencySI.Name = "lbl_SaleCurrencySI";
            this.lbl_SaleCurrencySI.Size = new System.Drawing.Size(98, 16);
            this.lbl_SaleCurrencySI.TabIndex = 0;
            this.lbl_SaleCurrencySI.Text = "Sale Currency :";
            // 
            // dt_SaleInvoice
            // 
            this.dt_SaleInvoice.Location = new System.Drawing.Point(312, 37);
            this.dt_SaleInvoice.Name = "dt_SaleInvoice";
            this.dt_SaleInvoice.Size = new System.Drawing.Size(119, 20);
            this.dt_SaleInvoice.TabIndex = 1;
            // 
            // cbo_SaleCurrencySI
            // 
            this.cbo_SaleCurrencySI.FormattingEnabled = true;
            this.cbo_SaleCurrencySI.Items.AddRange(new object[] {
            "$ Sale",
            "₹ Sale"});
            this.cbo_SaleCurrencySI.Location = new System.Drawing.Point(541, 36);
            this.cbo_SaleCurrencySI.Name = "cbo_SaleCurrencySI";
            this.cbo_SaleCurrencySI.Size = new System.Drawing.Size(88, 21);
            this.cbo_SaleCurrencySI.TabIndex = 2;
            this.cbo_SaleCurrencySI.SelectedIndexChanged += new System.EventHandler(this.cbo_SaleCurrencySI_SelectedIndexChanged);
            // 
            // cbo_SelectInvoice
            // 
            this.cbo_SelectInvoice.DataSource = this.saleOrderDBBindingSource;
            this.cbo_SelectInvoice.FormattingEnabled = true;
            this.cbo_SelectInvoice.Location = new System.Drawing.Point(131, 8);
            this.cbo_SelectInvoice.Name = "cbo_SelectInvoice";
            this.cbo_SelectInvoice.Size = new System.Drawing.Size(121, 21);
            this.cbo_SelectInvoice.TabIndex = 3;
            // 
            // saleOrderDBBindingSource
            // 
            this.saleOrderDBBindingSource.DataMember = "SaleOrderDB";
            this.saleOrderDBBindingSource.DataSource = this.sale_OrderDBDataSet;
            // 
            // sale_OrderDBDataSet
            // 
            this.sale_OrderDBDataSet.DataSetName = "Sale_OrderDBDataSet";
            this.sale_OrderDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleOrderDBTableAdapter
            // 
            this.saleOrderDBTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "M/s :";
            // 
            // txt_InvoiceSC
            // 
            this.txt_InvoiceSC.Location = new System.Drawing.Point(128, 74);
            this.txt_InvoiceSC.Name = "txt_InvoiceSC";
            this.txt_InvoiceSC.Size = new System.Drawing.Size(33, 20);
            this.txt_InvoiceSC.TabIndex = 4;
            this.txt_InvoiceSC.TextChanged += new System.EventHandler(this.txt_InvoiceSC_TextChanged);
            // 
            // txt_InvoiceMS
            // 
            this.txt_InvoiceMS.Location = new System.Drawing.Point(167, 74);
            this.txt_InvoiceMS.Name = "txt_InvoiceMS";
            this.txt_InvoiceMS.Size = new System.Drawing.Size(85, 20);
            this.txt_InvoiceMS.TabIndex = 4;
            // 
            // btn_SelectMS
            // 
            this.btn_SelectMS.Location = new System.Drawing.Point(258, 74);
            this.btn_SelectMS.Name = "btn_SelectMS";
            this.btn_SelectMS.Size = new System.Drawing.Size(30, 20);
            this.btn_SelectMS.TabIndex = 5;
            this.btn_SelectMS.Text = "...";
            this.btn_SelectMS.UseVisualStyleBackColor = true;
            this.btn_SelectMS.Click += new System.EventHandler(this.btn_SelectMS_Click);
            // 
            // lbl_InvoiceNarration
            // 
            this.lbl_InvoiceNarration.AutoSize = true;
            this.lbl_InvoiceNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InvoiceNarration.Location = new System.Drawing.Point(53, 109);
            this.lbl_InvoiceNarration.Name = "lbl_InvoiceNarration";
            this.lbl_InvoiceNarration.Size = new System.Drawing.Size(69, 16);
            this.lbl_InvoiceNarration.TabIndex = 0;
            this.lbl_InvoiceNarration.Text = "Narration :";
            // 
            // rt_InvoiceNarration
            // 
            this.rt_InvoiceNarration.Location = new System.Drawing.Point(129, 109);
            this.rt_InvoiceNarration.Name = "rt_InvoiceNarration";
            this.rt_InvoiceNarration.Size = new System.Drawing.Size(159, 49);
            this.rt_InvoiceNarration.TabIndex = 6;
            this.rt_InvoiceNarration.Text = "";
            // 
            // tb_InvoiceProductDetails
            // 
            this.tb_InvoiceProductDetails.Controls.Add(this.tb_ProductDetails);
            this.tb_InvoiceProductDetails.Location = new System.Drawing.Point(16, 164);
            this.tb_InvoiceProductDetails.Name = "tb_InvoiceProductDetails";
            this.tb_InvoiceProductDetails.SelectedIndex = 0;
            this.tb_InvoiceProductDetails.Size = new System.Drawing.Size(613, 169);
            this.tb_InvoiceProductDetails.TabIndex = 7;
            // 
            // tb_ProductDetails
            // 
            this.tb_ProductDetails.Controls.Add(this.dg_InvoiceProductDetails);
            this.tb_ProductDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_ProductDetails.Name = "tb_ProductDetails";
            this.tb_ProductDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tb_ProductDetails.Size = new System.Drawing.Size(605, 143);
            this.tb_ProductDetails.TabIndex = 0;
            this.tb_ProductDetails.Text = "Product Details";
            this.tb_ProductDetails.UseVisualStyleBackColor = true;
            // 
            // dg_InvoiceProductDetails
            // 
            this.dg_InvoiceProductDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_InvoiceProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_InvoiceProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNoInvoice,
            this.ColorCodeInvoice,
            this.ColorInvoice,
            this.SizeCodeInvoice,
            this.SizeInvoice,
            this.QualityCodeInvoice,
            this.QualityInvoice,
            this.LotInvoice,
            this.QuantityInvoice,
            this.RateInvoice,
            this.RateConvInvoice,
            this.AmountInvoice,
            this.Discount1Invoice,
            this.Discount1AmountInvoice,
            this.Discount2Invoice,
            this.Discount2AmountInvoice,
            this.Discount3Invoice,
            this.Discount3AmountInvoice,
            this.FinalAmountInvoice,
            this.proPrimaryInvoice});
            this.dg_InvoiceProductDetails.Location = new System.Drawing.Point(0, 0);
            this.dg_InvoiceProductDetails.Name = "dg_InvoiceProductDetails";
            this.dg_InvoiceProductDetails.Size = new System.Drawing.Size(605, 142);
            this.dg_InvoiceProductDetails.TabIndex = 0;
            this.dg_InvoiceProductDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_InvoiceProductDetails_CellEndEdit);
            this.dg_InvoiceProductDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dg_InvoiceProductDetails_CellFormatting);
            this.dg_InvoiceProductDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_InvoiceProductDetails_CellValueChanged);
            this.dg_InvoiceProductDetails.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dg_InvoiceProductDetails_EditingControlShowing);
            this.dg_InvoiceProductDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_InvoiceProductDetails_RowPostPaint);
            this.dg_InvoiceProductDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_InvoiceProductDetails_KeyDown);
            // 
            // SNoInvoice
            // 
            this.SNoInvoice.HeaderText = "Sr. No.";
            this.SNoInvoice.Name = "SNoInvoice";
            this.SNoInvoice.ReadOnly = true;
            // 
            // ColorCodeInvoice
            // 
            this.ColorCodeInvoice.HeaderText = "Color Code";
            this.ColorCodeInvoice.Name = "ColorCodeInvoice";
            // 
            // ColorInvoice
            // 
            this.ColorInvoice.HeaderText = "Color";
            this.ColorInvoice.Name = "ColorInvoice";
            // 
            // SizeCodeInvoice
            // 
            this.SizeCodeInvoice.HeaderText = "Size Code";
            this.SizeCodeInvoice.Name = "SizeCodeInvoice";
            // 
            // SizeInvoice
            // 
            this.SizeInvoice.HeaderText = "Size";
            this.SizeInvoice.Name = "SizeInvoice";
            // 
            // QualityCodeInvoice
            // 
            this.QualityCodeInvoice.HeaderText = "Quality Code";
            this.QualityCodeInvoice.Name = "QualityCodeInvoice";
            // 
            // QualityInvoice
            // 
            this.QualityInvoice.HeaderText = "Quality";
            this.QualityInvoice.Name = "QualityInvoice";
            // 
            // LotInvoice
            // 
            this.LotInvoice.HeaderText = "Lot";
            this.LotInvoice.Name = "LotInvoice";
            // 
            // QuantityInvoice
            // 
            this.QuantityInvoice.HeaderText = "Quantity";
            this.QuantityInvoice.Name = "QuantityInvoice";
            // 
            // RateInvoice
            // 
            this.RateInvoice.HeaderText = "Rate";
            this.RateInvoice.Name = "RateInvoice";
            // 
            // RateConvInvoice
            // 
            this.RateConvInvoice.HeaderText = "Rate Conv";
            this.RateConvInvoice.Name = "RateConvInvoice";
            // 
            // AmountInvoice
            // 
            this.AmountInvoice.HeaderText = "Amount";
            this.AmountInvoice.Name = "AmountInvoice";
            // 
            // Discount1Invoice
            // 
            this.Discount1Invoice.HeaderText = "Discount 1";
            this.Discount1Invoice.Name = "Discount1Invoice";
            // 
            // Discount1AmountInvoice
            // 
            this.Discount1AmountInvoice.HeaderText = "Discount 1 Amount";
            this.Discount1AmountInvoice.Name = "Discount1AmountInvoice";
            // 
            // Discount2Invoice
            // 
            this.Discount2Invoice.HeaderText = "Discount 2";
            this.Discount2Invoice.Name = "Discount2Invoice";
            // 
            // Discount2AmountInvoice
            // 
            this.Discount2AmountInvoice.HeaderText = "Discount 2 Amount";
            this.Discount2AmountInvoice.Name = "Discount2AmountInvoice";
            // 
            // Discount3Invoice
            // 
            this.Discount3Invoice.HeaderText = "Discount 3";
            this.Discount3Invoice.Name = "Discount3Invoice";
            // 
            // Discount3AmountInvoice
            // 
            this.Discount3AmountInvoice.HeaderText = "Discount 3 Amount";
            this.Discount3AmountInvoice.Name = "Discount3AmountInvoice";
            // 
            // FinalAmountInvoice
            // 
            this.FinalAmountInvoice.HeaderText = "Final Amount";
            this.FinalAmountInvoice.Name = "FinalAmountInvoice";
            // 
            // proPrimaryInvoice
            // 
            this.proPrimaryInvoice.HeaderText = "proPrimary";
            this.proPrimaryInvoice.Name = "proPrimaryInvoice";
            this.proPrimaryInvoice.ReadOnly = true;
            this.proPrimaryInvoice.Visible = false;
            // 
            // dg_InvoiceReport
            // 
            this.dg_InvoiceReport.AllowUserToAddRows = false;
            this.dg_InvoiceReport.AllowUserToDeleteRows = false;
            this.dg_InvoiceReport.AutoGenerateColumns = false;
            this.dg_InvoiceReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_InvoiceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_InvoiceReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNoSaleInvoice,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.saleCurrencyDataGridViewTextBoxColumn,
            this.mSDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.narrationDataGridViewTextBoxColumn,
            this.shortCodeDataGridViewTextBoxColumn});
            this.dg_InvoiceReport.DataSource = this.saleInvoiceDBBindingSource;
            this.dg_InvoiceReport.Location = new System.Drawing.Point(636, 34);
            this.dg_InvoiceReport.Name = "dg_InvoiceReport";
            this.dg_InvoiceReport.ReadOnly = true;
            this.dg_InvoiceReport.Size = new System.Drawing.Size(732, 294);
            this.dg_InvoiceReport.TabIndex = 8;
            this.dg_InvoiceReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_InvoiceReport_CellDoubleClick);
            this.dg_InvoiceReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_InvoiceReport_RowPostPaint);
            // 
            // SNoSaleInvoice
            // 
            this.SNoSaleInvoice.HeaderText = "Sr. No.";
            this.SNoSaleInvoice.Name = "SNoSaleInvoice";
            this.SNoSaleInvoice.ReadOnly = true;
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
            // saleCurrencyDataGridViewTextBoxColumn
            // 
            this.saleCurrencyDataGridViewTextBoxColumn.DataPropertyName = "SaleCurrency";
            this.saleCurrencyDataGridViewTextBoxColumn.HeaderText = "Sale Currency";
            this.saleCurrencyDataGridViewTextBoxColumn.Name = "saleCurrencyDataGridViewTextBoxColumn";
            this.saleCurrencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mSDataGridViewTextBoxColumn
            // 
            this.mSDataGridViewTextBoxColumn.DataPropertyName = "MS";
            this.mSDataGridViewTextBoxColumn.HeaderText = "MS";
            this.mSDataGridViewTextBoxColumn.Name = "mSDataGridViewTextBoxColumn";
            this.mSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narrationDataGridViewTextBoxColumn
            // 
            this.narrationDataGridViewTextBoxColumn.DataPropertyName = "Narration";
            this.narrationDataGridViewTextBoxColumn.HeaderText = "Narration";
            this.narrationDataGridViewTextBoxColumn.Name = "narrationDataGridViewTextBoxColumn";
            this.narrationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shortCodeDataGridViewTextBoxColumn
            // 
            this.shortCodeDataGridViewTextBoxColumn.DataPropertyName = "ShortCode";
            this.shortCodeDataGridViewTextBoxColumn.HeaderText = "ShortCode";
            this.shortCodeDataGridViewTextBoxColumn.Name = "shortCodeDataGridViewTextBoxColumn";
            this.shortCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.shortCodeDataGridViewTextBoxColumn.Visible = false;
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
            // lbl_TotalAmountSI
            // 
            this.lbl_TotalAmountSI.AutoSize = true;
            this.lbl_TotalAmountSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAmountSI.Location = new System.Drawing.Point(425, 336);
            this.lbl_TotalAmountSI.Name = "lbl_TotalAmountSI";
            this.lbl_TotalAmountSI.Size = new System.Drawing.Size(93, 16);
            this.lbl_TotalAmountSI.TabIndex = 9;
            this.lbl_TotalAmountSI.Text = "Total Amount :";
            // 
            // txt_TotalAmountSI
            // 
            this.txt_TotalAmountSI.Location = new System.Drawing.Point(524, 335);
            this.txt_TotalAmountSI.Name = "txt_TotalAmountSI";
            this.txt_TotalAmountSI.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalAmountSI.TabIndex = 10;
            // 
            // btn_SubmitSItoDB
            // 
            this.btn_SubmitSItoDB.Location = new System.Drawing.Point(153, 362);
            this.btn_SubmitSItoDB.Name = "btn_SubmitSItoDB";
            this.btn_SubmitSItoDB.Size = new System.Drawing.Size(75, 40);
            this.btn_SubmitSItoDB.TabIndex = 11;
            this.btn_SubmitSItoDB.Text = "Submit";
            this.btn_SubmitSItoDB.UseVisualStyleBackColor = true;
            this.btn_SubmitSItoDB.Click += new System.EventHandler(this.btn_SubmitSItoDB_Click);
            // 
            // btn_AddNewSI
            // 
            this.btn_AddNewSI.Location = new System.Drawing.Point(20, 362);
            this.btn_AddNewSI.Name = "btn_AddNewSI";
            this.btn_AddNewSI.Size = new System.Drawing.Size(75, 40);
            this.btn_AddNewSI.TabIndex = 11;
            this.btn_AddNewSI.Text = "Add New";
            this.btn_AddNewSI.UseVisualStyleBackColor = true;
            this.btn_AddNewSI.Click += new System.EventHandler(this.btn_AddNewSI_Click);
            // 
            // btn_UpdateSI
            // 
            this.btn_UpdateSI.Location = new System.Drawing.Point(286, 362);
            this.btn_UpdateSI.Name = "btn_UpdateSI";
            this.btn_UpdateSI.Size = new System.Drawing.Size(75, 40);
            this.btn_UpdateSI.TabIndex = 11;
            this.btn_UpdateSI.Text = "Save";
            this.btn_UpdateSI.UseVisualStyleBackColor = true;
            this.btn_UpdateSI.Click += new System.EventHandler(this.btn_UpdateSI_Click);
            // 
            // btn_DisplaySI
            // 
            this.btn_DisplaySI.Location = new System.Drawing.Point(419, 362);
            this.btn_DisplaySI.Name = "btn_DisplaySI";
            this.btn_DisplaySI.Size = new System.Drawing.Size(75, 40);
            this.btn_DisplaySI.TabIndex = 11;
            this.btn_DisplaySI.Text = "OK";
            this.btn_DisplaySI.UseVisualStyleBackColor = true;
            // 
            // btn_CloseSI
            // 
            this.btn_CloseSI.Location = new System.Drawing.Point(552, 362);
            this.btn_CloseSI.Name = "btn_CloseSI";
            this.btn_CloseSI.Size = new System.Drawing.Size(75, 40);
            this.btn_CloseSI.TabIndex = 11;
            this.btn_CloseSI.Text = "Close";
            this.btn_CloseSI.UseVisualStyleBackColor = true;
            this.btn_CloseSI.Click += new System.EventHandler(this.btn_CloseSI_Click);
            // 
            // btn_ExportSI
            // 
            this.btn_ExportSI.Location = new System.Drawing.Point(636, 362);
            this.btn_ExportSI.Name = "btn_ExportSI";
            this.btn_ExportSI.Size = new System.Drawing.Size(75, 40);
            this.btn_ExportSI.TabIndex = 11;
            this.btn_ExportSI.Text = "Export";
            this.btn_ExportSI.UseVisualStyleBackColor = true;
            // 
            // btn_ImportSI
            // 
            this.btn_ImportSI.Location = new System.Drawing.Point(855, 362);
            this.btn_ImportSI.Name = "btn_ImportSI";
            this.btn_ImportSI.Size = new System.Drawing.Size(75, 40);
            this.btn_ImportSI.TabIndex = 11;
            this.btn_ImportSI.Text = "Import";
            this.btn_ImportSI.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteSI
            // 
            this.btn_DeleteSI.Location = new System.Drawing.Point(1074, 362);
            this.btn_DeleteSI.Name = "btn_DeleteSI";
            this.btn_DeleteSI.Size = new System.Drawing.Size(75, 40);
            this.btn_DeleteSI.TabIndex = 11;
            this.btn_DeleteSI.Text = "Delete";
            this.btn_DeleteSI.UseVisualStyleBackColor = true;
            this.btn_DeleteSI.Click += new System.EventHandler(this.btn_DeleteSI_Click);
            // 
            // btn_EditSI
            // 
            this.btn_EditSI.Location = new System.Drawing.Point(1293, 362);
            this.btn_EditSI.Name = "btn_EditSI";
            this.btn_EditSI.Size = new System.Drawing.Size(75, 40);
            this.btn_EditSI.TabIndex = 11;
            this.btn_EditSI.Text = "Edit";
            this.btn_EditSI.UseVisualStyleBackColor = true;
            this.btn_EditSI.Click += new System.EventHandler(this.btn_EditSI_Click);
            // 
            // saleInvoiceDBTableAdapter
            // 
            this.saleInvoiceDBTableAdapter.ClearBeforeFill = true;
            // 
            // txt_SINo
            // 
            this.txt_SINo.Location = new System.Drawing.Point(128, 39);
            this.txt_SINo.Name = "txt_SINo";
            this.txt_SINo.Size = new System.Drawing.Size(85, 20);
            this.txt_SINo.TabIndex = 4;
            // 
            // SaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.btn_AddNewSI);
            this.Controls.Add(this.btn_EditSI);
            this.Controls.Add(this.btn_DeleteSI);
            this.Controls.Add(this.btn_ImportSI);
            this.Controls.Add(this.btn_ExportSI);
            this.Controls.Add(this.btn_CloseSI);
            this.Controls.Add(this.btn_DisplaySI);
            this.Controls.Add(this.btn_UpdateSI);
            this.Controls.Add(this.btn_SubmitSItoDB);
            this.Controls.Add(this.txt_TotalAmountSI);
            this.Controls.Add(this.lbl_TotalAmountSI);
            this.Controls.Add(this.dg_InvoiceReport);
            this.Controls.Add(this.tb_InvoiceProductDetails);
            this.Controls.Add(this.rt_InvoiceNarration);
            this.Controls.Add(this.btn_SelectMS);
            this.Controls.Add(this.txt_SINo);
            this.Controls.Add(this.txt_InvoiceMS);
            this.Controls.Add(this.txt_InvoiceSC);
            this.Controls.Add(this.cbo_SelectInvoice);
            this.Controls.Add(this.cbo_SaleCurrencySI);
            this.Controls.Add(this.dt_SaleInvoice);
            this.Controls.Add(this.lbl_SaleCurrencySI);
            this.Controls.Add(this.lbl_SaleInvoiceDate);
            this.Controls.Add(this.lbl_InvoiceNarration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SaleInvoice);
            this.Controls.Add(this.lbl_SelectInvoice);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleInvoice";
            this.Load += new System.EventHandler(this.SaleInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale_OrderDBDataSet)).EndInit();
            this.tb_InvoiceProductDetails.ResumeLayout(false);
            this.tb_ProductDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_InvoiceProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_InvoiceReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleInvoiceDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SelectInvoice;
        private System.Windows.Forms.Label lbl_SaleInvoice;
        private System.Windows.Forms.Label lbl_SaleInvoiceDate;
        private System.Windows.Forms.Label lbl_SaleCurrencySI;
        private System.Windows.Forms.DateTimePicker dt_SaleInvoice;
        private System.Windows.Forms.ComboBox cbo_SaleCurrencySI;
        private System.Windows.Forms.ComboBox cbo_SelectInvoice;
        private Sale_OrderDBDataSet sale_OrderDBDataSet;
        private System.Windows.Forms.BindingSource saleOrderDBBindingSource;
        private Sale_OrderDBDataSetTableAdapters.SaleOrderDBTableAdapter saleOrderDBTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SelectMS;
        private System.Windows.Forms.Label lbl_InvoiceNarration;
        private System.Windows.Forms.RichTextBox rt_InvoiceNarration;
        private System.Windows.Forms.TabControl tb_InvoiceProductDetails;
        private System.Windows.Forms.TabPage tb_ProductDetails;
        private System.Windows.Forms.DataGridView dg_InvoiceProductDetails;
        private System.Windows.Forms.DataGridView dg_InvoiceReport;
        private System.Windows.Forms.Label lbl_TotalAmountSI;
        private System.Windows.Forms.TextBox txt_TotalAmountSI;
        private System.Windows.Forms.Button btn_SubmitSItoDB;
        private System.Windows.Forms.Button btn_AddNewSI;
        private System.Windows.Forms.Button btn_UpdateSI;
        private System.Windows.Forms.Button btn_DisplaySI;
        private System.Windows.Forms.Button btn_CloseSI;
        private System.Windows.Forms.Button btn_ExportSI;
        private System.Windows.Forms.Button btn_ImportSI;
        private System.Windows.Forms.Button btn_DeleteSI;
        private System.Windows.Forms.Button btn_EditSI;
        public System.Windows.Forms.TextBox txt_InvoiceSC;
        public System.Windows.Forms.TextBox txt_InvoiceMS;
        private SalesInvoiceDataSet salesInvoiceDataSet;
        private System.Windows.Forms.BindingSource saleInvoiceDBBindingSource;
        private SalesInvoiceDataSetTableAdapters.SaleInvoiceDBTableAdapter saleInvoiceDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNoSaleInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNoInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorCodeInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCodeInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityCodeInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateConvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount1Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount1AmountInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount2Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount2AmountInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount3Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount3AmountInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAmountInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn proPrimaryInvoice;
        public System.Windows.Forms.TextBox txt_SINo;
    }
}