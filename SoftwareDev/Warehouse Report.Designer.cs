namespace SoftwareDev
{
    partial class Warehouse_Report
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
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.txt_quality = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_WarehouseReport = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inwardQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outwardQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WarehouseDataSet = new SoftwareDev.WarehouseDataSet();
            this.WarehouseTableAdapter = new SoftwareDev.WarehouseDataSetTableAdapters.WarehouseTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_WarehouseReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(12, 12);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(100, 20);
            this.txt_Color.TabIndex = 0;
            this.txt_Color.TextChanged += new System.EventHandler(this.txt_Color_TextChanged);
            // 
            // txt_Size
            // 
            this.txt_Size.Location = new System.Drawing.Point(131, 12);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(100, 20);
            this.txt_Size.TabIndex = 1;
            this.txt_Size.TextChanged += new System.EventHandler(this.txt_Size_TextChanged);
            // 
            // txt_quality
            // 
            this.txt_quality.Location = new System.Drawing.Point(247, 12);
            this.txt_quality.Name = "txt_quality";
            this.txt_quality.Size = new System.Drawing.Size(100, 20);
            this.txt_quality.TabIndex = 2;
            this.txt_quality.TextChanged += new System.EventHandler(this.txt_quality_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dg_WarehouseReport);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 399);
            this.panel1.TabIndex = 2;
            // 
            // dg_WarehouseReport
            // 
            this.dg_WarehouseReport.AllowUserToAddRows = false;
            this.dg_WarehouseReport.AllowUserToDeleteRows = false;
            this.dg_WarehouseReport.AutoGenerateColumns = false;
            this.dg_WarehouseReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_WarehouseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_WarehouseReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.colorDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.qualityDataGridViewTextBoxColumn,
            this.lotDataGridViewTextBoxColumn,
            this.inwardQuantityDataGridViewTextBoxColumn,
            this.outwardQuantityDataGridViewTextBoxColumn,
            this.balanceQuantityDataGridViewTextBoxColumn,
            this.Rate});
            this.dg_WarehouseReport.DataSource = this.WarehouseBindingSource;
            this.dg_WarehouseReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_WarehouseReport.Location = new System.Drawing.Point(0, 0);
            this.dg_WarehouseReport.Name = "dg_WarehouseReport";
            this.dg_WarehouseReport.ReadOnly = true;
            this.dg_WarehouseReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_WarehouseReport.Size = new System.Drawing.Size(1001, 399);
            this.dg_WarehouseReport.TabIndex = 0;
            this.dg_WarehouseReport.TabStop = false;
            this.dg_WarehouseReport.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dg_WarehouseReport_CellFormatting);
            this.dg_WarehouseReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "Sr. No.";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualityDataGridViewTextBoxColumn
            // 
            this.qualityDataGridViewTextBoxColumn.DataPropertyName = "Quality";
            this.qualityDataGridViewTextBoxColumn.HeaderText = "Quality";
            this.qualityDataGridViewTextBoxColumn.Name = "qualityDataGridViewTextBoxColumn";
            this.qualityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lotDataGridViewTextBoxColumn
            // 
            this.lotDataGridViewTextBoxColumn.DataPropertyName = "Lot";
            this.lotDataGridViewTextBoxColumn.HeaderText = "Lot";
            this.lotDataGridViewTextBoxColumn.Name = "lotDataGridViewTextBoxColumn";
            this.lotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inwardQuantityDataGridViewTextBoxColumn
            // 
            this.inwardQuantityDataGridViewTextBoxColumn.DataPropertyName = "Inward_Quantity";
            this.inwardQuantityDataGridViewTextBoxColumn.HeaderText = "Inward Quantity";
            this.inwardQuantityDataGridViewTextBoxColumn.Name = "inwardQuantityDataGridViewTextBoxColumn";
            this.inwardQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.inwardQuantityDataGridViewTextBoxColumn.Width = 120;
            // 
            // outwardQuantityDataGridViewTextBoxColumn
            // 
            this.outwardQuantityDataGridViewTextBoxColumn.DataPropertyName = "Outward_Quantity";
            this.outwardQuantityDataGridViewTextBoxColumn.HeaderText = "Outward Quantity";
            this.outwardQuantityDataGridViewTextBoxColumn.Name = "outwardQuantityDataGridViewTextBoxColumn";
            this.outwardQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.outwardQuantityDataGridViewTextBoxColumn.Width = 120;
            // 
            // balanceQuantityDataGridViewTextBoxColumn
            // 
            this.balanceQuantityDataGridViewTextBoxColumn.DataPropertyName = "Balance_Quantity";
            this.balanceQuantityDataGridViewTextBoxColumn.HeaderText = "Balance Quantity";
            this.balanceQuantityDataGridViewTextBoxColumn.Name = "balanceQuantityDataGridViewTextBoxColumn";
            this.balanceQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceQuantityDataGridViewTextBoxColumn.Width = 120;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // WarehouseBindingSource
            // 
            this.WarehouseBindingSource.DataMember = "Warehouse";
            this.WarehouseBindingSource.DataSource = this.WarehouseDataSet;
            // 
            // WarehouseDataSet
            // 
            this.WarehouseDataSet.DataSetName = "WarehouseDataSet";
            this.WarehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WarehouseTableAdapter
            // 
            this.WarehouseTableAdapter.ClearBeforeFill = true;
            // 
            // Warehouse_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_quality);
            this.Controls.Add(this.txt_Size);
            this.Controls.Add(this.txt_Color);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Warehouse_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Report";
            this.Load += new System.EventHandler(this.Warehouse_Report_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_WarehouseReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.TextBox txt_quality;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource WarehouseBindingSource;
        private WarehouseDataSet WarehouseDataSet;
        private WarehouseDataSetTableAdapters.WarehouseTableAdapter WarehouseTableAdapter;
        private System.Windows.Forms.DataGridView dg_WarehouseReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inwardQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outwardQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
    }
}