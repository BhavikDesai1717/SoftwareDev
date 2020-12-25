namespace SoftwareDev
{
    partial class Outstanding
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lt_Clients = new System.Windows.Forms.ListBox();
            this.clientDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.clientDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ClientDBTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outstanding List";
            // 
            // lt_Clients
            // 
            this.lt_Clients.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lt_Clients.DataSource = this.clientDBBindingSource;
            this.lt_Clients.DisplayMember = "Name";
            this.lt_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lt_Clients.FormattingEnabled = true;
            this.lt_Clients.ItemHeight = 20;
            this.lt_Clients.Location = new System.Drawing.Point(310, 92);
            this.lt_Clients.Name = "lt_Clients";
            this.lt_Clients.Size = new System.Drawing.Size(184, 344);
            this.lt_Clients.TabIndex = 1;
            this.lt_Clients.ValueMember = "Name";
            this.lt_Clients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lt_Clients_MouseDoubleClick);
            // 
            // clientDBBindingSource
            // 
            this.clientDBBindingSource.DataMember = "ClientDB";
            this.clientDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientDBTableAdapter
            // 
            this.clientDBTableAdapter.ClearBeforeFill = true;
            // 
            // Outstanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lt_Clients);
            this.Controls.Add(this.panel1);
            this.Name = "Outstanding";
            this.Text = "Outstanding";
            this.Load += new System.EventHandler(this.Outstanding_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lt_Clients;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource clientDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ClientDBTableAdapter clientDBTableAdapter;
    }
}