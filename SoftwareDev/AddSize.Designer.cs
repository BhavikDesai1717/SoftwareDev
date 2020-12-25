namespace SoftwareDev
{
    partial class AddSize
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
            this.lbl_SizeCode = new System.Windows.Forms.Label();
            this.txt_SizeCode = new System.Windows.Forms.TextBox();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_SizeID = new System.Windows.Forms.Label();
            this.btn_SaveSize = new System.Windows.Forms.Button();
            this.btn_DisplaySize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SizeCode
            // 
            this.lbl_SizeCode.AutoSize = true;
            this.lbl_SizeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeCode.Location = new System.Drawing.Point(13, 34);
            this.lbl_SizeCode.Name = "lbl_SizeCode";
            this.lbl_SizeCode.Size = new System.Drawing.Size(87, 16);
            this.lbl_SizeCode.TabIndex = 0;
            this.lbl_SizeCode.Text = "Size Code :";
            // 
            // txt_SizeCode
            // 
            this.txt_SizeCode.Location = new System.Drawing.Point(106, 33);
            this.txt_SizeCode.Name = "txt_SizeCode";
            this.txt_SizeCode.Size = new System.Drawing.Size(100, 20);
            this.txt_SizeCode.TabIndex = 0;
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.Location = new System.Drawing.Point(54, 63);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(46, 16);
            this.lbl_Size.TabIndex = 0;
            this.lbl_Size.Text = "Size :";
            // 
            // txt_Size
            // 
            this.txt_Size.Location = new System.Drawing.Point(106, 62);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(100, 20);
            this.txt_Size.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(69, 88);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            this.btn_Submit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Submit_KeyDown);
            // 
            // lbl_SizeID
            // 
            this.lbl_SizeID.AutoSize = true;
            this.lbl_SizeID.Location = new System.Drawing.Point(64, 14);
            this.lbl_SizeID.Name = "lbl_SizeID";
            this.lbl_SizeID.Size = new System.Drawing.Size(0, 13);
            this.lbl_SizeID.TabIndex = 3;
            // 
            // btn_SaveSize
            // 
            this.btn_SaveSize.Location = new System.Drawing.Point(67, 89);
            this.btn_SaveSize.Name = "btn_SaveSize";
            this.btn_SaveSize.Size = new System.Drawing.Size(62, 23);
            this.btn_SaveSize.TabIndex = 4;
            this.btn_SaveSize.Text = "Save";
            this.btn_SaveSize.UseVisualStyleBackColor = true;
            this.btn_SaveSize.Click += new System.EventHandler(this.btn_SaveSize_Click);
            this.btn_SaveSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SaveSize_KeyDown);
            // 
            // btn_DisplaySize
            // 
            this.btn_DisplaySize.Location = new System.Drawing.Point(67, 89);
            this.btn_DisplaySize.Name = "btn_DisplaySize";
            this.btn_DisplaySize.Size = new System.Drawing.Size(45, 23);
            this.btn_DisplaySize.TabIndex = 5;
            this.btn_DisplaySize.Text = "OK";
            this.btn_DisplaySize.UseVisualStyleBackColor = true;
            this.btn_DisplaySize.Click += new System.EventHandler(this.btn_DisplaySize_Click);
            this.btn_DisplaySize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DisplaySize_KeyDown);
            // 
            // AddSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 124);
            this.Controls.Add(this.btn_DisplaySize);
            this.Controls.Add(this.btn_SaveSize);
            this.Controls.Add(this.lbl_SizeID);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Size);
            this.Controls.Add(this.txt_SizeCode);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.lbl_SizeCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSize";
            this.Load += new System.EventHandler(this.AddSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SizeCode;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_SaveSize;
        private System.Windows.Forms.Button btn_DisplaySize;
        public System.Windows.Forms.Label lbl_SizeID;
        public System.Windows.Forms.TextBox txt_SizeCode;
        public System.Windows.Forms.TextBox txt_Size;
    }
}