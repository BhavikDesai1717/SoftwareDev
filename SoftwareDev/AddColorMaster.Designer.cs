namespace SoftwareDev
{
    partial class AddColorMaster
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
            this.dg_ColorDB = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productColorDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.productColorDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ProductColorDBTableAdapter();
            this.btn_CloseColor = new System.Windows.Forms.Button();
            this.btn_DeleteColor = new System.Windows.Forms.Button();
            this.btn_DisplayColor = new System.Windows.Forms.Button();
            this.btn_EditColor = new System.Windows.Forms.Button();
            this.btn_AddColor = new System.Windows.Forms.Button();
            this.btn_ImportColor = new System.Windows.Forms.Button();
            this.btn_ExportColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ColorDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productColorDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_ColorDB
            // 
            this.dg_ColorDB.AllowUserToAddRows = false;
            this.dg_ColorDB.AllowUserToDeleteRows = false;
            this.dg_ColorDB.AutoGenerateColumns = false;
            this.dg_ColorDB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_ColorDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ColorDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.colorCodeDataGridViewTextBoxColumn,
            this.productColorDataGridViewTextBoxColumn,
            this.srNoDataGridViewTextBoxColumn});
            this.dg_ColorDB.DataSource = this.productColorDBBindingSource;
            this.dg_ColorDB.Location = new System.Drawing.Point(12, 12);
            this.dg_ColorDB.Name = "dg_ColorDB";
            this.dg_ColorDB.ReadOnly = true;
            this.dg_ColorDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_ColorDB.Size = new System.Drawing.Size(344, 329);
            this.dg_ColorDB.TabIndex = 0;
            this.dg_ColorDB.TabStop = false;
            this.dg_ColorDB.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_ColorDB_RowPostPaint);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "Sr. No.";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // colorCodeDataGridViewTextBoxColumn
            // 
            this.colorCodeDataGridViewTextBoxColumn.DataPropertyName = "ColorCode";
            this.colorCodeDataGridViewTextBoxColumn.HeaderText = "Color Code";
            this.colorCodeDataGridViewTextBoxColumn.Name = "colorCodeDataGridViewTextBoxColumn";
            this.colorCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productColorDataGridViewTextBoxColumn
            // 
            this.productColorDataGridViewTextBoxColumn.DataPropertyName = "ProductColor";
            this.productColorDataGridViewTextBoxColumn.HeaderText = "Product Color";
            this.productColorDataGridViewTextBoxColumn.Name = "productColorDataGridViewTextBoxColumn";
            this.productColorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // srNoDataGridViewTextBoxColumn
            // 
            this.srNoDataGridViewTextBoxColumn.DataPropertyName = "SrNo";
            this.srNoDataGridViewTextBoxColumn.HeaderText = "SrNo";
            this.srNoDataGridViewTextBoxColumn.Name = "srNoDataGridViewTextBoxColumn";
            this.srNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.srNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // productColorDBBindingSource
            // 
            this.productColorDBBindingSource.DataMember = "ProductColorDB";
            this.productColorDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productColorDBTableAdapter
            // 
            this.productColorDBTableAdapter.ClearBeforeFill = true;
            // 
            // btn_CloseColor
            // 
            this.btn_CloseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseColor.Location = new System.Drawing.Point(361, 318);
            this.btn_CloseColor.Name = "btn_CloseColor";
            this.btn_CloseColor.Size = new System.Drawing.Size(75, 23);
            this.btn_CloseColor.TabIndex = 6;
            this.btn_CloseColor.Text = "&Close";
            this.btn_CloseColor.UseVisualStyleBackColor = true;
            this.btn_CloseColor.Click += new System.EventHandler(this.btn_CloseColor_Click);
            this.btn_CloseColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_CloseColor_KeyDown);
            // 
            // btn_DeleteColor
            // 
            this.btn_DeleteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteColor.Location = new System.Drawing.Point(361, 165);
            this.btn_DeleteColor.Name = "btn_DeleteColor";
            this.btn_DeleteColor.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteColor.TabIndex = 3;
            this.btn_DeleteColor.Text = "&Delete";
            this.btn_DeleteColor.UseVisualStyleBackColor = true;
            this.btn_DeleteColor.Click += new System.EventHandler(this.btn_DeleteColor_Click);
            this.btn_DeleteColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DeleteColor_KeyDown);
            // 
            // btn_DisplayColor
            // 
            this.btn_DisplayColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DisplayColor.Location = new System.Drawing.Point(361, 114);
            this.btn_DisplayColor.Name = "btn_DisplayColor";
            this.btn_DisplayColor.Size = new System.Drawing.Size(75, 23);
            this.btn_DisplayColor.TabIndex = 2;
            this.btn_DisplayColor.Text = "Di&splay";
            this.btn_DisplayColor.UseVisualStyleBackColor = true;
            this.btn_DisplayColor.Click += new System.EventHandler(this.btn_DisplayColor_Click);
            this.btn_DisplayColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DisplayColor_KeyDown);
            // 
            // btn_EditColor
            // 
            this.btn_EditColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditColor.Location = new System.Drawing.Point(361, 63);
            this.btn_EditColor.Name = "btn_EditColor";
            this.btn_EditColor.Size = new System.Drawing.Size(75, 23);
            this.btn_EditColor.TabIndex = 1;
            this.btn_EditColor.Text = "&Edit";
            this.btn_EditColor.UseVisualStyleBackColor = true;
            this.btn_EditColor.Click += new System.EventHandler(this.btn_EditColor_Click);
            this.btn_EditColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_EditColor_KeyDown);
            // 
            // btn_AddColor
            // 
            this.btn_AddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddColor.Location = new System.Drawing.Point(362, 12);
            this.btn_AddColor.Name = "btn_AddColor";
            this.btn_AddColor.Size = new System.Drawing.Size(75, 23);
            this.btn_AddColor.TabIndex = 0;
            this.btn_AddColor.Text = "&Add New";
            this.btn_AddColor.UseVisualStyleBackColor = true;
            this.btn_AddColor.Click += new System.EventHandler(this.btn_AddColor_Click);
            this.btn_AddColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_AddColor_KeyDown);
            // 
            // btn_ImportColor
            // 
            this.btn_ImportColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportColor.Location = new System.Drawing.Point(361, 216);
            this.btn_ImportColor.Name = "btn_ImportColor";
            this.btn_ImportColor.Size = new System.Drawing.Size(75, 23);
            this.btn_ImportColor.TabIndex = 4;
            this.btn_ImportColor.Text = "&Import";
            this.btn_ImportColor.UseVisualStyleBackColor = true;
            this.btn_ImportColor.Click += new System.EventHandler(this.btn_ImportColor_Click);
            // 
            // btn_ExportColor
            // 
            this.btn_ExportColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportColor.Location = new System.Drawing.Point(362, 267);
            this.btn_ExportColor.Name = "btn_ExportColor";
            this.btn_ExportColor.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportColor.TabIndex = 5;
            this.btn_ExportColor.Text = "E&xport";
            this.btn_ExportColor.UseVisualStyleBackColor = true;
            this.btn_ExportColor.Click += new System.EventHandler(this.btn_ExportColor_Click);
            // 
            // AddColorMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 354);
            this.Controls.Add(this.btn_CloseColor);
            this.Controls.Add(this.btn_ExportColor);
            this.Controls.Add(this.btn_ImportColor);
            this.Controls.Add(this.btn_DeleteColor);
            this.Controls.Add(this.btn_DisplayColor);
            this.Controls.Add(this.btn_EditColor);
            this.Controls.Add(this.btn_AddColor);
            this.Controls.Add(this.dg_ColorDB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddColorMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddColorMaster";
            this.Load += new System.EventHandler(this.AddColorMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ColorDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productColorDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ColorDB;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productColorDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductColorDBTableAdapter productColorDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_CloseColor;
        private System.Windows.Forms.Button btn_DeleteColor;
        private System.Windows.Forms.Button btn_DisplayColor;
        private System.Windows.Forms.Button btn_EditColor;
        private System.Windows.Forms.Button btn_AddColor;
        private System.Windows.Forms.Button btn_ImportColor;
        private System.Windows.Forms.Button btn_ExportColor;
    }
}