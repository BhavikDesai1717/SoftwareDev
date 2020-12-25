namespace SoftwareDev
{
    partial class AddQuality
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
            this.txt_QualityCode = new System.Windows.Forms.TextBox();
            this.lbl_QualityCode = new System.Windows.Forms.Label();
            this.txt_Quality = new System.Windows.Forms.TextBox();
            this.lbl_Quality = new System.Windows.Forms.Label();
            this.btn_SubmitQuality = new System.Windows.Forms.Button();
            this.lbl_QualityID = new System.Windows.Forms.Label();
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_QualityCode
            // 
            this.txt_QualityCode.Location = new System.Drawing.Point(123, 8);
            this.txt_QualityCode.Name = "txt_QualityCode";
            this.txt_QualityCode.Size = new System.Drawing.Size(100, 20);
            this.txt_QualityCode.TabIndex = 0;
            this.txt_QualityCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_QualityCode_KeyDown);
            // 
            // lbl_QualityCode
            // 
            this.lbl_QualityCode.AutoSize = true;
            this.lbl_QualityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QualityCode.Location = new System.Drawing.Point(12, 9);
            this.lbl_QualityCode.Name = "lbl_QualityCode";
            this.lbl_QualityCode.Size = new System.Drawing.Size(105, 16);
            this.lbl_QualityCode.TabIndex = 1;
            this.lbl_QualityCode.Text = "Quality Code :";
            // 
            // txt_Quality
            // 
            this.txt_Quality.Location = new System.Drawing.Point(123, 42);
            this.txt_Quality.Name = "txt_Quality";
            this.txt_Quality.Size = new System.Drawing.Size(100, 20);
            this.txt_Quality.TabIndex = 1;
            this.txt_Quality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Quality_KeyDown);
            // 
            // lbl_Quality
            // 
            this.lbl_Quality.AutoSize = true;
            this.lbl_Quality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quality.Location = new System.Drawing.Point(53, 43);
            this.lbl_Quality.Name = "lbl_Quality";
            this.lbl_Quality.Size = new System.Drawing.Size(64, 16);
            this.lbl_Quality.TabIndex = 1;
            this.lbl_Quality.Text = "Quality :";
            // 
            // btn_SubmitQuality
            // 
            this.btn_SubmitQuality.Location = new System.Drawing.Point(108, 68);
            this.btn_SubmitQuality.Name = "btn_SubmitQuality";
            this.btn_SubmitQuality.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitQuality.TabIndex = 4;
            this.btn_SubmitQuality.Text = "Submit";
            this.btn_SubmitQuality.UseVisualStyleBackColor = true;
            this.btn_SubmitQuality.Click += new System.EventHandler(this.btn_SubmitQuality_Click);
            this.btn_SubmitQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SubmitQuality_KeyDown);
            // 
            // lbl_QualityID
            // 
            this.lbl_QualityID.AutoSize = true;
            this.lbl_QualityID.Location = new System.Drawing.Point(12, 68);
            this.lbl_QualityID.Name = "lbl_QualityID";
            this.lbl_QualityID.Size = new System.Drawing.Size(0, 13);
            this.lbl_QualityID.TabIndex = 3;
            this.lbl_QualityID.Visible = false;
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(108, 68);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(40, 23);
            this.btn_Display.TabIndex = 2;
            this.btn_Display.Text = "OK";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            this.btn_Display.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Display_KeyDown);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(108, 68);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(55, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Save_KeyDown);
            // 
            // AddQuality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 103);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_QualityID);
            this.Controls.Add(this.btn_SubmitQuality);
            this.Controls.Add(this.lbl_Quality);
            this.Controls.Add(this.txt_Quality);
            this.Controls.Add(this.lbl_QualityCode);
            this.Controls.Add(this.txt_QualityCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuality";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuality";
            this.Load += new System.EventHandler(this.AddQuality_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_QualityCode;
        private System.Windows.Forms.Label lbl_Quality;
        private System.Windows.Forms.Button btn_SubmitQuality;
        public System.Windows.Forms.Label lbl_QualityID;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.TextBox txt_QualityCode;
        public System.Windows.Forms.TextBox txt_Quality;
    }
}