namespace SoftwareDev
{
    partial class AddNewColor
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
            this.btn_AddColor = new System.Windows.Forms.Button();
            this.lbl_ColorName = new System.Windows.Forms.Label();
            this.txt_ColorName = new System.Windows.Forms.TextBox();
            this.lbl_ColorCode = new System.Windows.Forms.Label();
            this.txt_ColorCode = new System.Windows.Forms.TextBox();
            this.lbl_ColorID = new System.Windows.Forms.Label();
            this.btn_SaveDataToDB = new System.Windows.Forms.Button();
            this.btn_DisplayDataToDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddColor
            // 
            this.btn_AddColor.Location = new System.Drawing.Point(116, 82);
            this.btn_AddColor.Name = "btn_AddColor";
            this.btn_AddColor.Size = new System.Drawing.Size(75, 23);
            this.btn_AddColor.TabIndex = 0;
            this.btn_AddColor.Text = "Add Color";
            this.btn_AddColor.UseVisualStyleBackColor = true;
            this.btn_AddColor.Click += new System.EventHandler(this.btn_AddColor_Click);
            // 
            // lbl_ColorName
            // 
            this.lbl_ColorName.AutoSize = true;
            this.lbl_ColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorName.Location = new System.Drawing.Point(12, 41);
            this.lbl_ColorName.Name = "lbl_ColorName";
            this.lbl_ColorName.Size = new System.Drawing.Size(98, 16);
            this.lbl_ColorName.TabIndex = 1;
            this.lbl_ColorName.Text = "Color Name :";
            // 
            // txt_ColorName
            // 
            this.txt_ColorName.Location = new System.Drawing.Point(116, 40);
            this.txt_ColorName.Name = "txt_ColorName";
            this.txt_ColorName.Size = new System.Drawing.Size(126, 20);
            this.txt_ColorName.TabIndex = 2;
            // 
            // lbl_ColorCode
            // 
            this.lbl_ColorCode.AutoSize = true;
            this.lbl_ColorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorCode.Location = new System.Drawing.Point(12, 9);
            this.lbl_ColorCode.Name = "lbl_ColorCode";
            this.lbl_ColorCode.Size = new System.Drawing.Size(94, 16);
            this.lbl_ColorCode.TabIndex = 1;
            this.lbl_ColorCode.Text = "Color Code :";
            // 
            // txt_ColorCode
            // 
            this.txt_ColorCode.Location = new System.Drawing.Point(116, 8);
            this.txt_ColorCode.Name = "txt_ColorCode";
            this.txt_ColorCode.Size = new System.Drawing.Size(126, 20);
            this.txt_ColorCode.TabIndex = 2;
            // 
            // lbl_ColorID
            // 
            this.lbl_ColorID.AutoSize = true;
            this.lbl_ColorID.Location = new System.Drawing.Point(15, 91);
            this.lbl_ColorID.Name = "lbl_ColorID";
            this.lbl_ColorID.Size = new System.Drawing.Size(0, 13);
            this.lbl_ColorID.TabIndex = 3;
            this.lbl_ColorID.Visible = false;
            // 
            // btn_SaveDataToDB
            // 
            this.btn_SaveDataToDB.Location = new System.Drawing.Point(116, 84);
            this.btn_SaveDataToDB.Name = "btn_SaveDataToDB";
            this.btn_SaveDataToDB.Size = new System.Drawing.Size(57, 21);
            this.btn_SaveDataToDB.TabIndex = 4;
            this.btn_SaveDataToDB.Text = "Save";
            this.btn_SaveDataToDB.UseVisualStyleBackColor = true;
            this.btn_SaveDataToDB.Click += new System.EventHandler(this.btn_SaveDataToDB_Click);
            // 
            // btn_DisplayDataToDB
            // 
            this.btn_DisplayDataToDB.Location = new System.Drawing.Point(116, 83);
            this.btn_DisplayDataToDB.Name = "btn_DisplayDataToDB";
            this.btn_DisplayDataToDB.Size = new System.Drawing.Size(39, 23);
            this.btn_DisplayDataToDB.TabIndex = 5;
            this.btn_DisplayDataToDB.Text = "OK";
            this.btn_DisplayDataToDB.UseVisualStyleBackColor = true;
            this.btn_DisplayDataToDB.Click += new System.EventHandler(this.btn_DisplayDataToDB_Click);
            // 
            // AddNewColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 139);
            this.Controls.Add(this.btn_DisplayDataToDB);
            this.Controls.Add(this.btn_SaveDataToDB);
            this.Controls.Add(this.lbl_ColorID);
            this.Controls.Add(this.txt_ColorCode);
            this.Controls.Add(this.txt_ColorName);
            this.Controls.Add(this.lbl_ColorCode);
            this.Controls.Add(this.lbl_ColorName);
            this.Controls.Add(this.btn_AddColor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewColor";
            this.Load += new System.EventHandler(this.AddNewColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddColor;
        private System.Windows.Forms.Label lbl_ColorName;
        private System.Windows.Forms.Label lbl_ColorCode;
        public System.Windows.Forms.Label lbl_ColorID;
        public System.Windows.Forms.TextBox txt_ColorName;
        public System.Windows.Forms.TextBox txt_ColorCode;
        private System.Windows.Forms.Button btn_SaveDataToDB;
        private System.Windows.Forms.Button btn_DisplayDataToDB;
    }
}