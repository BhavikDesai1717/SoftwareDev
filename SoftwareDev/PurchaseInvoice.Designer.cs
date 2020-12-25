namespace SoftwareDev
{
    partial class PurchaseInvoice
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
            this.cbo_SelectPO = new System.Windows.Forms.ComboBox();
            this.purchaseOrderDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_OrderDBDataSet = new SoftwareDev.Purchase_OrderDBDataSet();
            this.lbl_SelectPO = new System.Windows.Forms.Label();
            this.purchaseOrderDBTableAdapter = new SoftwareDev.Purchase_OrderDBDataSetTableAdapters.PurchaseOrderDBTableAdapter();
            this.lbl_InvoiceNo = new System.Windows.Forms.Label();
            this.lbl_MS = new System.Windows.Forms.Label();
            this.txt_InvSC = new System.Windows.Forms.TextBox();
            this.txt_InvMS = new System.Windows.Forms.TextBox();
            this.btn_SelectMSInvoice = new System.Windows.Forms.Button();
            this.lbl_InvoiceDate = new System.Windows.Forms.Label();
            this.dt_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_InvoiceCurrency = new System.Windows.Forms.Label();
            this.cbo_InvoiceCurrency = new System.Windows.Forms.ComboBox();
            this.rt_InvoiceNarration = new System.Windows.Forms.RichTextBox();
            this.lbl_Narration = new System.Windows.Forms.Label();
            this.tb_Details = new System.Windows.Forms.TabControl();
            this.tb_ProductDetails = new System.Windows.Forms.TabPage();
            this.dg_ProductDetails = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.discount1Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount1AmountInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount2Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount2AmountInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount3Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount3AmountInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalAmountInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrimaryInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddNewInvoice = new System.Windows.Forms.Button();
            this.btn_InsertNewInvoice = new System.Windows.Forms.Button();
            this.btn_SaveInvoiceData = new System.Windows.Forms.Button();
            this.btn_OKInvoice = new System.Windows.Forms.Button();
            this.btn_CloseInvoice = new System.Windows.Forms.Button();
            this.dg_InvoiceReport = new System.Windows.Forms.DataGridView();
            this.SrNoInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseInvoiceDBDataSet = new SoftwareDev.PurchaseInvoiceDBDataSet();
            this.btn_ExportInvoice = new System.Windows.Forms.Button();
            this.btn_ImportInvoice = new System.Windows.Forms.Button();
            this.btn_DeleteInvoice = new System.Windows.Forms.Button();
            this.btn_EditInvoice = new System.Windows.Forms.Button();
            this.lbl_InvoiceTotalAmount = new System.Windows.Forms.Label();
            this.txt_InvoiceTotalAmount = new System.Windows.Forms.TextBox();
            this.invoiceDBTableAdapter = new SoftwareDev.PurchaseInvoiceDBDataSetTableAdapters.InvoiceDBTableAdapter();
            this.purchaseOrderDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Invoice_No = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_OrderDBDataSet)).BeginInit();
            this.tb_Details.SuspendLayout();
            this.tb_ProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_InvoiceReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDBBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_SelectPO
            // 
            this.cbo_SelectPO.DataSource = this.purchaseOrderDBBindingSource;
            this.cbo_SelectPO.DisplayMember = "PO_No";
            this.cbo_SelectPO.FormattingEnabled = true;
            this.cbo_SelectPO.Location = new System.Drawing.Point(93, 12);
            this.cbo_SelectPO.Name = "cbo_SelectPO";
            this.cbo_SelectPO.Size = new System.Drawing.Size(121, 21);
            this.cbo_SelectPO.TabIndex = 0;
            this.cbo_SelectPO.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectPO_SelectedIndexChanged);
            // 
            // purchaseOrderDBBindingSource
            // 
            this.purchaseOrderDBBindingSource.DataMember = "PurchaseOrderDB";
            this.purchaseOrderDBBindingSource.DataSource = this.purchase_OrderDBDataSet;
            // 
            // purchase_OrderDBDataSet
            // 
            this.purchase_OrderDBDataSet.DataSetName = "Purchase_OrderDBDataSet";
            this.purchase_OrderDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_SelectPO
            // 
            this.lbl_SelectPO.AutoSize = true;
            this.lbl_SelectPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectPO.Location = new System.Drawing.Point(13, 13);
            this.lbl_SelectPO.Name = "lbl_SelectPO";
            this.lbl_SelectPO.Size = new System.Drawing.Size(74, 16);
            this.lbl_SelectPO.TabIndex = 1;
            this.lbl_SelectPO.Text = "Select PO :";
            // 
            // purchaseOrderDBTableAdapter
            // 
            this.purchaseOrderDBTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_InvoiceNo
            // 
            this.lbl_InvoiceNo.AutoSize = true;
            this.lbl_InvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InvoiceNo.Location = new System.Drawing.Point(9, 42);
            this.lbl_InvoiceNo.Name = "lbl_InvoiceNo";
            this.lbl_InvoiceNo.Size = new System.Drawing.Size(78, 16);
            this.lbl_InvoiceNo.TabIndex = 2;
            this.lbl_InvoiceNo.Text = "Invoice No.:";
            // 
            // lbl_MS
            // 
            this.lbl_MS.AutoSize = true;
            this.lbl_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MS.Location = new System.Drawing.Point(51, 73);
            this.lbl_MS.Name = "lbl_MS";
            this.lbl_MS.Size = new System.Drawing.Size(36, 16);
            this.lbl_MS.TabIndex = 4;
            this.lbl_MS.Text = "M/s :";
            // 
            // txt_InvSC
            // 
            this.txt_InvSC.Location = new System.Drawing.Point(93, 72);
            this.txt_InvSC.Name = "txt_InvSC";
            this.txt_InvSC.Size = new System.Drawing.Size(37, 20);
            this.txt_InvSC.TabIndex = 5;
            this.txt_InvSC.TextChanged += new System.EventHandler(this.txt_InvSC_TextChanged);
            // 
            // txt_InvMS
            // 
            this.txt_InvMS.Location = new System.Drawing.Point(136, 72);
            this.txt_InvMS.Name = "txt_InvMS";
            this.txt_InvMS.Size = new System.Drawing.Size(78, 20);
            this.txt_InvMS.TabIndex = 6;
            // 
            // btn_SelectMSInvoice
            // 
            this.btn_SelectMSInvoice.Location = new System.Drawing.Point(220, 72);
            this.btn_SelectMSInvoice.Name = "btn_SelectMSInvoice";
            this.btn_SelectMSInvoice.Size = new System.Drawing.Size(24, 20);
            this.btn_SelectMSInvoice.TabIndex = 7;
            this.btn_SelectMSInvoice.Text = "...";
            this.btn_SelectMSInvoice.UseVisualStyleBackColor = true;
            this.btn_SelectMSInvoice.Click += new System.EventHandler(this.btn_SelectMSInvoice_Click);
            // 
            // lbl_InvoiceDate
            // 
            this.lbl_InvoiceDate.AutoSize = true;
            this.lbl_InvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InvoiceDate.Location = new System.Drawing.Point(220, 44);
            this.lbl_InvoiceDate.Name = "lbl_InvoiceDate";
            this.lbl_InvoiceDate.Size = new System.Drawing.Size(89, 16);
            this.lbl_InvoiceDate.TabIndex = 8;
            this.lbl_InvoiceDate.Text = "Invoice Date :";
            // 
            // dt_InvoiceDate
            // 
            this.dt_InvoiceDate.Location = new System.Drawing.Point(316, 44);
            this.dt_InvoiceDate.Name = "dt_InvoiceDate";
            this.dt_InvoiceDate.Size = new System.Drawing.Size(115, 20);
            this.dt_InvoiceDate.TabIndex = 9;
            this.dt_InvoiceDate.Value = new System.DateTime(2020, 10, 14, 14, 4, 19, 0);
            // 
            // lbl_InvoiceCurrency
            // 
            this.lbl_InvoiceCurrency.AutoSize = true;
            this.lbl_InvoiceCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InvoiceCurrency.Location = new System.Drawing.Point(437, 48);
            this.lbl_InvoiceCurrency.Name = "lbl_InvoiceCurrency";
            this.lbl_InvoiceCurrency.Size = new System.Drawing.Size(113, 16);
            this.lbl_InvoiceCurrency.TabIndex = 10;
            this.lbl_InvoiceCurrency.Text = "Invoice Currency :";
            // 
            // cbo_InvoiceCurrency
            // 
            this.cbo_InvoiceCurrency.FormattingEnabled = true;
            this.cbo_InvoiceCurrency.Items.AddRange(new object[] {
            "₹ Purchase",
            "$ Purchase"});
            this.cbo_InvoiceCurrency.Location = new System.Drawing.Point(556, 43);
            this.cbo_InvoiceCurrency.Name = "cbo_InvoiceCurrency";
            this.cbo_InvoiceCurrency.Size = new System.Drawing.Size(110, 21);
            this.cbo_InvoiceCurrency.TabIndex = 11;
            this.cbo_InvoiceCurrency.SelectedIndexChanged += new System.EventHandler(this.cbo_InvoiceCurrency_SelectedIndexChanged);
            // 
            // rt_InvoiceNarration
            // 
            this.rt_InvoiceNarration.Location = new System.Drawing.Point(93, 99);
            this.rt_InvoiceNarration.Name = "rt_InvoiceNarration";
            this.rt_InvoiceNarration.Size = new System.Drawing.Size(151, 49);
            this.rt_InvoiceNarration.TabIndex = 12;
            this.rt_InvoiceNarration.Text = "";
            // 
            // lbl_Narration
            // 
            this.lbl_Narration.AutoSize = true;
            this.lbl_Narration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Narration.Location = new System.Drawing.Point(18, 100);
            this.lbl_Narration.Name = "lbl_Narration";
            this.lbl_Narration.Size = new System.Drawing.Size(69, 16);
            this.lbl_Narration.TabIndex = 13;
            this.lbl_Narration.Text = "Narration :";
            // 
            // tb_Details
            // 
            this.tb_Details.Controls.Add(this.tb_ProductDetails);
            this.tb_Details.Location = new System.Drawing.Point(12, 162);
            this.tb_Details.Name = "tb_Details";
            this.tb_Details.SelectedIndex = 0;
            this.tb_Details.Size = new System.Drawing.Size(654, 159);
            this.tb_Details.TabIndex = 14;
            // 
            // tb_ProductDetails
            // 
            this.tb_ProductDetails.Controls.Add(this.dg_ProductDetails);
            this.tb_ProductDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_ProductDetails.Name = "tb_ProductDetails";
            this.tb_ProductDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tb_ProductDetails.Size = new System.Drawing.Size(646, 133);
            this.tb_ProductDetails.TabIndex = 0;
            this.tb_ProductDetails.Text = "Product Details";
            this.tb_ProductDetails.UseVisualStyleBackColor = true;
            // 
            // dg_ProductDetails
            // 
            this.dg_ProductDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_ProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
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
            this.discount1Invoice,
            this.discount1AmountInvoice,
            this.discount2Invoice,
            this.discount2AmountInvoice,
            this.discount3Invoice,
            this.discount3AmountInvoice,
            this.finalAmountInvoice,
            this.productPrimaryInvoice});
            this.dg_ProductDetails.Location = new System.Drawing.Point(0, 0);
            this.dg_ProductDetails.Name = "dg_ProductDetails";
            this.dg_ProductDetails.Size = new System.Drawing.Size(643, 133);
            this.dg_ProductDetails.TabIndex = 0;
            this.dg_ProductDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ProductDetails_CellEndEdit);
            this.dg_ProductDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dg_ProductDetails_CellFormatting);
            this.dg_ProductDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ProductDetails_CellValueChanged);
            this.dg_ProductDetails.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dg_ProductDetails_EditingControlShowing);
            this.dg_ProductDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_ProductDetails_RowPostPaint);
            this.dg_ProductDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_ProductDetails_KeyDown);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "Sr. No.";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
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
            this.RateConvInvoice.HeaderText = "Rate Conv.";
            this.RateConvInvoice.Name = "RateConvInvoice";
            // 
            // AmountInvoice
            // 
            this.AmountInvoice.HeaderText = "Amount";
            this.AmountInvoice.Name = "AmountInvoice";
            // 
            // discount1Invoice
            // 
            this.discount1Invoice.HeaderText = "Discount 1";
            this.discount1Invoice.Name = "discount1Invoice";
            // 
            // discount1AmountInvoice
            // 
            this.discount1AmountInvoice.HeaderText = "Discount 1 Amount";
            this.discount1AmountInvoice.Name = "discount1AmountInvoice";
            // 
            // discount2Invoice
            // 
            this.discount2Invoice.HeaderText = "Discount 2";
            this.discount2Invoice.Name = "discount2Invoice";
            // 
            // discount2AmountInvoice
            // 
            this.discount2AmountInvoice.HeaderText = "Discount 2 Amount";
            this.discount2AmountInvoice.Name = "discount2AmountInvoice";
            // 
            // discount3Invoice
            // 
            this.discount3Invoice.HeaderText = "Discount 3";
            this.discount3Invoice.Name = "discount3Invoice";
            // 
            // discount3AmountInvoice
            // 
            this.discount3AmountInvoice.HeaderText = "Discount 3 Amount";
            this.discount3AmountInvoice.Name = "discount3AmountInvoice";
            // 
            // finalAmountInvoice
            // 
            this.finalAmountInvoice.HeaderText = "Final Amount";
            this.finalAmountInvoice.Name = "finalAmountInvoice";
            // 
            // productPrimaryInvoice
            // 
            this.productPrimaryInvoice.HeaderText = "ProPri";
            this.productPrimaryInvoice.Name = "productPrimaryInvoice";
            this.productPrimaryInvoice.Visible = false;
            // 
            // btn_AddNewInvoice
            // 
            this.btn_AddNewInvoice.Location = new System.Drawing.Point(12, 363);
            this.btn_AddNewInvoice.Name = "btn_AddNewInvoice";
            this.btn_AddNewInvoice.Size = new System.Drawing.Size(75, 40);
            this.btn_AddNewInvoice.TabIndex = 15;
            this.btn_AddNewInvoice.Text = "Add New";
            this.btn_AddNewInvoice.UseVisualStyleBackColor = true;
            this.btn_AddNewInvoice.Click += new System.EventHandler(this.btn_AddNewInvoice_Click);
            // 
            // btn_InsertNewInvoice
            // 
            this.btn_InsertNewInvoice.Location = new System.Drawing.Point(154, 363);
            this.btn_InsertNewInvoice.Name = "btn_InsertNewInvoice";
            this.btn_InsertNewInvoice.Size = new System.Drawing.Size(75, 40);
            this.btn_InsertNewInvoice.TabIndex = 15;
            this.btn_InsertNewInvoice.Text = "Submit";
            this.btn_InsertNewInvoice.UseVisualStyleBackColor = true;
            this.btn_InsertNewInvoice.Click += new System.EventHandler(this.btn_InsertNewInvoice_Click);
            // 
            // btn_SaveInvoiceData
            // 
            this.btn_SaveInvoiceData.Location = new System.Drawing.Point(296, 363);
            this.btn_SaveInvoiceData.Name = "btn_SaveInvoiceData";
            this.btn_SaveInvoiceData.Size = new System.Drawing.Size(75, 40);
            this.btn_SaveInvoiceData.TabIndex = 15;
            this.btn_SaveInvoiceData.Text = "Save";
            this.btn_SaveInvoiceData.UseVisualStyleBackColor = true;
            this.btn_SaveInvoiceData.Click += new System.EventHandler(this.btn_SaveInvoiceData_Click);
            // 
            // btn_OKInvoice
            // 
            this.btn_OKInvoice.Location = new System.Drawing.Point(438, 363);
            this.btn_OKInvoice.Name = "btn_OKInvoice";
            this.btn_OKInvoice.Size = new System.Drawing.Size(75, 40);
            this.btn_OKInvoice.TabIndex = 15;
            this.btn_OKInvoice.Text = "OK";
            this.btn_OKInvoice.UseVisualStyleBackColor = true;
            this.btn_OKInvoice.Click += new System.EventHandler(this.btn_OKInvoice_Click);
            // 
            // btn_CloseInvoice
            // 
            this.btn_CloseInvoice.Location = new System.Drawing.Point(580, 363);
            this.btn_CloseInvoice.Name = "btn_CloseInvoice";
            this.btn_CloseInvoice.Size = new System.Drawing.Size(75, 40);
            this.btn_CloseInvoice.TabIndex = 15;
            this.btn_CloseInvoice.Text = "Close";
            this.btn_CloseInvoice.UseVisualStyleBackColor = true;
            this.btn_CloseInvoice.Click += new System.EventHandler(this.btn_CloseInvoice_Click);
            // 
            // dg_InvoiceReport
            // 
            this.dg_InvoiceReport.AllowUserToAddRows = false;
            this.dg_InvoiceReport.AllowUserToDeleteRows = false;
            this.dg_InvoiceReport.AutoGenerateColumns = false;
            this.dg_InvoiceReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_InvoiceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_InvoiceReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNoInvoice,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.invoiceCurrencyDataGridViewTextBoxColumn,
            this.mSDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.narrationDataGridViewTextBoxColumn,
            this.shortCodeDataGridViewTextBoxColumn});
            this.dg_InvoiceReport.DataSource = this.invoiceDBBindingSource;
            this.dg_InvoiceReport.Location = new System.Drawing.Point(673, 42);
            this.dg_InvoiceReport.MultiSelect = false;
            this.dg_InvoiceReport.Name = "dg_InvoiceReport";
            this.dg_InvoiceReport.ReadOnly = true;
            this.dg_InvoiceReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_InvoiceReport.Size = new System.Drawing.Size(643, 279);
            this.dg_InvoiceReport.TabIndex = 16;
            this.dg_InvoiceReport.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_InvoiceReport_CellContentDoubleClick);
            this.dg_InvoiceReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_InvoiceReport_RowPostPaint);
            // 
            // SrNoInvoice
            // 
            this.SrNoInvoice.HeaderText = "Sr. No.";
            this.SrNoInvoice.Name = "SrNoInvoice";
            this.SrNoInvoice.ReadOnly = true;
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
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "Invoice Date";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceCurrencyDataGridViewTextBoxColumn
            // 
            this.invoiceCurrencyDataGridViewTextBoxColumn.DataPropertyName = "InvoiceCurrency";
            this.invoiceCurrencyDataGridViewTextBoxColumn.HeaderText = "Invoice Currency";
            this.invoiceCurrencyDataGridViewTextBoxColumn.Name = "invoiceCurrencyDataGridViewTextBoxColumn";
            this.invoiceCurrencyDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
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
            // invoiceDBBindingSource
            // 
            this.invoiceDBBindingSource.DataMember = "InvoiceDB";
            this.invoiceDBBindingSource.DataSource = this.purchaseInvoiceDBDataSet;
            // 
            // purchaseInvoiceDBDataSet
            // 
            this.purchaseInvoiceDBDataSet.DataSetName = "PurchaseInvoiceDBDataSet";
            this.purchaseInvoiceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ExportInvoice
            // 
            this.btn_ExportInvoice.Location = new System.Drawing.Point(673, 363);
            this.btn_ExportInvoice.Name = "btn_ExportInvoice";
            this.btn_ExportInvoice.Size = new System.Drawing.Size(75, 40);
            this.btn_ExportInvoice.TabIndex = 15;
            this.btn_ExportInvoice.Text = "Export";
            this.btn_ExportInvoice.UseVisualStyleBackColor = true;
            // 
            // btn_ImportInvoice
            // 
            this.btn_ImportInvoice.Location = new System.Drawing.Point(862, 363);
            this.btn_ImportInvoice.Name = "btn_ImportInvoice";
            this.btn_ImportInvoice.Size = new System.Drawing.Size(75, 40);
            this.btn_ImportInvoice.TabIndex = 15;
            this.btn_ImportInvoice.Text = "Import";
            this.btn_ImportInvoice.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteInvoice
            // 
            this.btn_DeleteInvoice.Location = new System.Drawing.Point(1051, 363);
            this.btn_DeleteInvoice.Name = "btn_DeleteInvoice";
            this.btn_DeleteInvoice.Size = new System.Drawing.Size(75, 40);
            this.btn_DeleteInvoice.TabIndex = 15;
            this.btn_DeleteInvoice.Text = "Delete";
            this.btn_DeleteInvoice.UseVisualStyleBackColor = true;
            this.btn_DeleteInvoice.Click += new System.EventHandler(this.btn_DeleteInvoice_Click);
            // 
            // btn_EditInvoice
            // 
            this.btn_EditInvoice.Location = new System.Drawing.Point(1240, 363);
            this.btn_EditInvoice.Name = "btn_EditInvoice";
            this.btn_EditInvoice.Size = new System.Drawing.Size(75, 40);
            this.btn_EditInvoice.TabIndex = 15;
            this.btn_EditInvoice.Text = "Edit";
            this.btn_EditInvoice.UseVisualStyleBackColor = true;
            this.btn_EditInvoice.Click += new System.EventHandler(this.btn_EditInvoice_Click);
            // 
            // lbl_InvoiceTotalAmount
            // 
            this.lbl_InvoiceTotalAmount.AutoSize = true;
            this.lbl_InvoiceTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InvoiceTotalAmount.Location = new System.Drawing.Point(462, 329);
            this.lbl_InvoiceTotalAmount.Name = "lbl_InvoiceTotalAmount";
            this.lbl_InvoiceTotalAmount.Size = new System.Drawing.Size(93, 16);
            this.lbl_InvoiceTotalAmount.TabIndex = 17;
            this.lbl_InvoiceTotalAmount.Text = "Total Amount :";
            // 
            // txt_InvoiceTotalAmount
            // 
            this.txt_InvoiceTotalAmount.Location = new System.Drawing.Point(561, 328);
            this.txt_InvoiceTotalAmount.Name = "txt_InvoiceTotalAmount";
            this.txt_InvoiceTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_InvoiceTotalAmount.TabIndex = 18;
            // 
            // invoiceDBTableAdapter
            // 
            this.invoiceDBTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseOrderDBBindingSource1
            // 
            this.purchaseOrderDBBindingSource1.DataMember = "PurchaseOrderDB";
            this.purchaseOrderDBBindingSource1.DataSource = this.purchase_OrderDBDataSet;
            // 
            // txt_Invoice_No
            // 
            this.txt_Invoice_No.Location = new System.Drawing.Point(93, 40);
            this.txt_Invoice_No.Name = "txt_Invoice_No";
            this.txt_Invoice_No.Size = new System.Drawing.Size(121, 20);
            this.txt_Invoice_No.TabIndex = 19;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.txt_Invoice_No);
            this.Controls.Add(this.txt_InvoiceTotalAmount);
            this.Controls.Add(this.lbl_InvoiceTotalAmount);
            this.Controls.Add(this.dg_InvoiceReport);
            this.Controls.Add(this.btn_EditInvoice);
            this.Controls.Add(this.btn_DeleteInvoice);
            this.Controls.Add(this.btn_ImportInvoice);
            this.Controls.Add(this.btn_ExportInvoice);
            this.Controls.Add(this.btn_CloseInvoice);
            this.Controls.Add(this.btn_OKInvoice);
            this.Controls.Add(this.btn_SaveInvoiceData);
            this.Controls.Add(this.btn_InsertNewInvoice);
            this.Controls.Add(this.btn_AddNewInvoice);
            this.Controls.Add(this.tb_Details);
            this.Controls.Add(this.lbl_Narration);
            this.Controls.Add(this.rt_InvoiceNarration);
            this.Controls.Add(this.cbo_InvoiceCurrency);
            this.Controls.Add(this.lbl_InvoiceCurrency);
            this.Controls.Add(this.dt_InvoiceDate);
            this.Controls.Add(this.lbl_InvoiceDate);
            this.Controls.Add(this.btn_SelectMSInvoice);
            this.Controls.Add(this.txt_InvMS);
            this.Controls.Add(this.txt_InvSC);
            this.Controls.Add(this.lbl_MS);
            this.Controls.Add(this.lbl_InvoiceNo);
            this.Controls.Add(this.lbl_SelectPO);
            this.Controls.Add(this.cbo_SelectPO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Invoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_OrderDBDataSet)).EndInit();
            this.tb_Details.ResumeLayout(false);
            this.tb_ProductDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_InvoiceReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDBBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_SelectPO;
        private System.Windows.Forms.Label lbl_SelectPO;
        private Purchase_OrderDBDataSet purchase_OrderDBDataSet;
        private System.Windows.Forms.BindingSource purchaseOrderDBBindingSource;
        private Purchase_OrderDBDataSetTableAdapters.PurchaseOrderDBTableAdapter purchaseOrderDBTableAdapter;
        private System.Windows.Forms.Label lbl_InvoiceNo;
        private System.Windows.Forms.Label lbl_MS;
        private System.Windows.Forms.Label lbl_InvoiceDate;
        private System.Windows.Forms.DateTimePicker dt_InvoiceDate;
        private System.Windows.Forms.Label lbl_InvoiceCurrency;
        private System.Windows.Forms.ComboBox cbo_InvoiceCurrency;
        private System.Windows.Forms.RichTextBox rt_InvoiceNarration;
        private System.Windows.Forms.Label lbl_Narration;
        private System.Windows.Forms.TabControl tb_Details;
        private System.Windows.Forms.TabPage tb_ProductDetails;
        private System.Windows.Forms.DataGridView dg_ProductDetails;
        private System.Windows.Forms.Button btn_AddNewInvoice;
        private System.Windows.Forms.Button btn_InsertNewInvoice;
        private System.Windows.Forms.Button btn_SaveInvoiceData;
        private System.Windows.Forms.Button btn_OKInvoice;
        private System.Windows.Forms.Button btn_CloseInvoice;
        private System.Windows.Forms.DataGridView dg_InvoiceReport;
        private System.Windows.Forms.Button btn_ExportInvoice;
        private System.Windows.Forms.Button btn_ImportInvoice;
        private System.Windows.Forms.Button btn_DeleteInvoice;
        private System.Windows.Forms.Button btn_EditInvoice;
        public System.Windows.Forms.Button btn_SelectMSInvoice;
        public System.Windows.Forms.TextBox txt_InvSC;
        public System.Windows.Forms.TextBox txt_InvMS;
        private System.Windows.Forms.Label lbl_InvoiceTotalAmount;
        private System.Windows.Forms.TextBox txt_InvoiceTotalAmount;
        private PurchaseInvoiceDBDataSet purchaseInvoiceDBDataSet;
        private System.Windows.Forms.BindingSource invoiceDBBindingSource;
        private PurchaseInvoiceDBDataSetTableAdapters.InvoiceDBTableAdapter invoiceDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNoInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaseOrderDBBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn discount1Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount1AmountInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount2Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount2AmountInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount3Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount3AmountInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalAmountInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrimaryInvoice;
        private System.Windows.Forms.TextBox txt_Invoice_No;
    }
}