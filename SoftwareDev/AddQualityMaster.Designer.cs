namespace SoftwareDev
{
    partial class AddQualityMaster
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
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_DeleteQuality = new System.Windows.Forms.Button();
            this.btn_DisplayQuality = new System.Windows.Forms.Button();
            this.btn_EditQuality = new System.Windows.Forms.Button();
            this.btn_AddQuality = new System.Windows.Forms.Button();
            this.dg_QualityDB = new System.Windows.Forms.DataGridView();
            this.SNOQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQualityDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.productQualityDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ProductQualityDBTableAdapter();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_QualityDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQualityDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Import
            // 
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(361, 190);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 4;
            this.btn_Import.Text = "&Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_DeleteQuality
            // 
            this.btn_DeleteQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteQuality.Location = new System.Drawing.Point(363, 148);
            this.btn_DeleteQuality.Name = "btn_DeleteQuality";
            this.btn_DeleteQuality.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteQuality.TabIndex = 3;
            this.btn_DeleteQuality.Text = "&Delete";
            this.btn_DeleteQuality.UseVisualStyleBackColor = true;
            // 
            // btn_DisplayQuality
            // 
            this.btn_DisplayQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DisplayQuality.Location = new System.Drawing.Point(363, 106);
            this.btn_DisplayQuality.Name = "btn_DisplayQuality";
            this.btn_DisplayQuality.Size = new System.Drawing.Size(75, 23);
            this.btn_DisplayQuality.TabIndex = 2;
            this.btn_DisplayQuality.Text = "Di&splay";
            this.btn_DisplayQuality.UseVisualStyleBackColor = true;
            this.btn_DisplayQuality.Click += new System.EventHandler(this.btn_DisplayQuality_Click);
            this.btn_DisplayQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DisplayQuality_KeyDown);
            // 
            // btn_EditQuality
            // 
            this.btn_EditQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditQuality.Location = new System.Drawing.Point(362, 64);
            this.btn_EditQuality.Name = "btn_EditQuality";
            this.btn_EditQuality.Size = new System.Drawing.Size(75, 23);
            this.btn_EditQuality.TabIndex = 1;
            this.btn_EditQuality.Text = "&Edit";
            this.btn_EditQuality.UseVisualStyleBackColor = true;
            this.btn_EditQuality.Click += new System.EventHandler(this.btn_EditQuality_Click);
            this.btn_EditQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_EditQuality_KeyDown);
            // 
            // btn_AddQuality
            // 
            this.btn_AddQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddQuality.Location = new System.Drawing.Point(363, 22);
            this.btn_AddQuality.Name = "btn_AddQuality";
            this.btn_AddQuality.Size = new System.Drawing.Size(75, 23);
            this.btn_AddQuality.TabIndex = 0;
            this.btn_AddQuality.Text = "&Add New";
            this.btn_AddQuality.UseVisualStyleBackColor = true;
            this.btn_AddQuality.Click += new System.EventHandler(this.btn_AddQuality_Click);
            this.btn_AddQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_AddQuality_KeyDown);
            // 
            // dg_QualityDB
            // 
            this.dg_QualityDB.AllowUserToAddRows = false;
            this.dg_QualityDB.AllowUserToDeleteRows = false;
            this.dg_QualityDB.AutoGenerateColumns = false;
            this.dg_QualityDB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_QualityDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_QualityDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNOQuality,
            this.qualityCodeDataGridViewTextBoxColumn,
            this.productQualityDataGridViewTextBoxColumn,
            this.srNoDataGridViewTextBoxColumn});
            this.dg_QualityDB.DataSource = this.productQualityDBBindingSource;
            this.dg_QualityDB.Location = new System.Drawing.Point(12, 12);
            this.dg_QualityDB.Name = "dg_QualityDB";
            this.dg_QualityDB.ReadOnly = true;
            this.dg_QualityDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_QualityDB.Size = new System.Drawing.Size(345, 285);
            this.dg_QualityDB.TabIndex = 9;
            this.dg_QualityDB.TabStop = false;
            this.dg_QualityDB.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_QualityDB_RowPostPaint);
            // 
            // SNOQuality
            // 
            this.SNOQuality.HeaderText = "Sr. No.";
            this.SNOQuality.Name = "SNOQuality";
            this.SNOQuality.ReadOnly = true;
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
            // srNoDataGridViewTextBoxColumn
            // 
            this.srNoDataGridViewTextBoxColumn.DataPropertyName = "SrNo";
            this.srNoDataGridViewTextBoxColumn.HeaderText = "SrNo";
            this.srNoDataGridViewTextBoxColumn.Name = "srNoDataGridViewTextBoxColumn";
            this.srNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.srNoDataGridViewTextBoxColumn.Visible = false;
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
            // btn_Export
            // 
            this.btn_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.Location = new System.Drawing.Point(361, 232);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 5;
            this.btn_Export.Text = "E&xport";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(363, 274);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "&Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Close_KeyDown);
            // 
            // AddQualityMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 306);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_DeleteQuality);
            this.Controls.Add(this.btn_DisplayQuality);
            this.Controls.Add(this.btn_EditQuality);
            this.Controls.Add(this.btn_AddQuality);
            this.Controls.Add(this.dg_QualityDB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQualityMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQualityMaster";
            this.Load += new System.EventHandler(this.AddQualityMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_QualityDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQualityDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_DeleteQuality;
        private System.Windows.Forms.Button btn_DisplayQuality;
        private System.Windows.Forms.Button btn_EditQuality;
        private System.Windows.Forms.Button btn_AddQuality;
        private System.Windows.Forms.DataGridView dg_QualityDB;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productQualityDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductQualityDBTableAdapter productQualityDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Close;
    }
}