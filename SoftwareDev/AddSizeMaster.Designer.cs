namespace SoftwareDev
{
    partial class AddSizeMaster
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
            this.btn_CloseSize = new System.Windows.Forms.Button();
            this.btn_DeleteSize = new System.Windows.Forms.Button();
            this.btn_DisplaySize = new System.Windows.Forms.Button();
            this.btn_EditSize = new System.Windows.Forms.Button();
            this.btn_AddSize = new System.Windows.Forms.Button();
            this.dg_SizeDB = new System.Windows.Forms.DataGridView();
            this.productSizeDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.productSizeDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ProductSizeDBTableAdapter();
            this.SNOSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SizeDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CloseSize
            // 
            this.btn_CloseSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseSize.Location = new System.Drawing.Point(363, 334);
            this.btn_CloseSize.Name = "btn_CloseSize";
            this.btn_CloseSize.Size = new System.Drawing.Size(75, 23);
            this.btn_CloseSize.TabIndex = 10;
            this.btn_CloseSize.Text = "&Close";
            this.btn_CloseSize.UseVisualStyleBackColor = true;
            this.btn_CloseSize.Click += new System.EventHandler(this.btn_CloseSize_Click);
            this.btn_CloseSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_CloseSize_KeyDown);
            // 
            // btn_DeleteSize
            // 
            this.btn_DeleteSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteSize.Location = new System.Drawing.Point(363, 178);
            this.btn_DeleteSize.Name = "btn_DeleteSize";
            this.btn_DeleteSize.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteSize.TabIndex = 9;
            this.btn_DeleteSize.Text = "&Delete";
            this.btn_DeleteSize.UseVisualStyleBackColor = true;
            // 
            // btn_DisplaySize
            // 
            this.btn_DisplaySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DisplaySize.Location = new System.Drawing.Point(364, 126);
            this.btn_DisplaySize.Name = "btn_DisplaySize";
            this.btn_DisplaySize.Size = new System.Drawing.Size(75, 23);
            this.btn_DisplaySize.TabIndex = 8;
            this.btn_DisplaySize.Text = "Di&splay";
            this.btn_DisplaySize.UseVisualStyleBackColor = true;
            this.btn_DisplaySize.Click += new System.EventHandler(this.btn_DisplaySize_Click);
            this.btn_DisplaySize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DisplaySize_KeyDown);
            // 
            // btn_EditSize
            // 
            this.btn_EditSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditSize.Location = new System.Drawing.Point(365, 74);
            this.btn_EditSize.Name = "btn_EditSize";
            this.btn_EditSize.Size = new System.Drawing.Size(75, 23);
            this.btn_EditSize.TabIndex = 7;
            this.btn_EditSize.Text = "&Edit";
            this.btn_EditSize.UseVisualStyleBackColor = true;
            this.btn_EditSize.Click += new System.EventHandler(this.btn_EditSize_Click);
            this.btn_EditSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_EditSize_KeyDown);
            // 
            // btn_AddSize
            // 
            this.btn_AddSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSize.Location = new System.Drawing.Point(365, 22);
            this.btn_AddSize.Name = "btn_AddSize";
            this.btn_AddSize.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSize.TabIndex = 5;
            this.btn_AddSize.Text = "&Add New";
            this.btn_AddSize.UseVisualStyleBackColor = true;
            this.btn_AddSize.Click += new System.EventHandler(this.btn_AddSize_Click);
            this.btn_AddSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_AddSize_KeyDown);
            // 
            // dg_SizeDB
            // 
            this.dg_SizeDB.AllowUserToAddRows = false;
            this.dg_SizeDB.AllowUserToDeleteRows = false;
            this.dg_SizeDB.AutoGenerateColumns = false;
            this.dg_SizeDB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_SizeDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_SizeDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNOSize,
            this.SizeCode,
            this.ProductSize,
            this.SrNo});
            this.dg_SizeDB.DataSource = this.productSizeDBBindingSource;
            this.dg_SizeDB.Location = new System.Drawing.Point(12, 12);
            this.dg_SizeDB.Name = "dg_SizeDB";
            this.dg_SizeDB.ReadOnly = true;
            this.dg_SizeDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_SizeDB.Size = new System.Drawing.Size(345, 350);
            this.dg_SizeDB.TabIndex = 6;
            this.dg_SizeDB.TabStop = false;
            this.dg_SizeDB.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_SizeDB_RowPostPaint);
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
            // btn_Import
            // 
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(363, 230);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 9;
            this.btn_Import.Text = "&Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.Location = new System.Drawing.Point(363, 282);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 9;
            this.btn_Export.Text = "E&xport";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // productSizeDBTableAdapter
            // 
            this.productSizeDBTableAdapter.ClearBeforeFill = true;
            // 
            // SNOSize
            // 
            this.SNOSize.HeaderText = "Sr. No.";
            this.SNOSize.Name = "SNOSize";
            this.SNOSize.ReadOnly = true;
            // 
            // SizeCode
            // 
            this.SizeCode.DataPropertyName = "SizeCode";
            this.SizeCode.HeaderText = "Size Code";
            this.SizeCode.Name = "SizeCode";
            this.SizeCode.ReadOnly = true;
            // 
            // ProductSize
            // 
            this.ProductSize.DataPropertyName = "ProductSize";
            this.ProductSize.HeaderText = "Product Size";
            this.ProductSize.Name = "ProductSize";
            this.ProductSize.ReadOnly = true;
            // 
            // SrNo
            // 
            this.SrNo.DataPropertyName = "SrNo";
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            this.SrNo.Visible = false;
            // 
            // AddSizeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 377);
            this.Controls.Add(this.btn_CloseSize);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_DeleteSize);
            this.Controls.Add(this.btn_DisplaySize);
            this.Controls.Add(this.btn_EditSize);
            this.Controls.Add(this.btn_AddSize);
            this.Controls.Add(this.dg_SizeDB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSizeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSizeMaster";
            this.Load += new System.EventHandler(this.AddSizeMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_SizeDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CloseSize;
        private System.Windows.Forms.Button btn_DeleteSize;
        private System.Windows.Forms.Button btn_DisplaySize;
        private System.Windows.Forms.Button btn_EditSize;
        private System.Windows.Forms.Button btn_AddSize;
        private System.Windows.Forms.DataGridView dg_SizeDB;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Export;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productSizeDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductSizeDBTableAdapter productSizeDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
    }
}