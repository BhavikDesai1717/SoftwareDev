namespace SoftwareDev
{
    partial class Import
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
            this.dg_Content = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.cbo_SheetName = new System.Windows.Forms.ComboBox();
            this.btn_Import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Content)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Content
            // 
            this.dg_Content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Content.Location = new System.Drawing.Point(12, 102);
            this.dg_Content.Name = "dg_Content";
            this.dg_Content.Size = new System.Drawing.Size(776, 345);
            this.dg_Content.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "File :";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(462, 30);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(28, 23);
            this.btn_OpenFile.TabIndex = 3;
            this.btn_OpenFile.Text = "...";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sheet :";
            // 
            // tb_FileName
            // 
            this.tb_FileName.Enabled = false;
            this.tb_FileName.Location = new System.Drawing.Point(64, 32);
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(392, 20);
            this.tb_FileName.TabIndex = 2;
            // 
            // cbo_SheetName
            // 
            this.cbo_SheetName.FormattingEnabled = true;
            this.cbo_SheetName.Location = new System.Drawing.Point(64, 63);
            this.cbo_SheetName.Name = "cbo_SheetName";
            this.cbo_SheetName.Size = new System.Drawing.Size(121, 21);
            this.cbo_SheetName.TabIndex = 4;
            this.cbo_SheetName.SelectedIndexChanged += new System.EventHandler(this.cbo_SheetName_SelectedIndexChanged);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(191, 61);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(61, 23);
            this.btn_Import.TabIndex = 3;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_SheetName);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.tb_FileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Content);
            this.Name = "Import";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Content)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_FileName;
        private System.Windows.Forms.ComboBox cbo_SheetName;
        private System.Windows.Forms.Button btn_Import;
    }
}