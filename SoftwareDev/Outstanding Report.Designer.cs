namespace SoftwareDev
{
    partial class Outstanding_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LedgerOutstandingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LedgersOutstandingsDataSet = new SoftwareDev.LedgersOutstandingsDataSet();
            this.rp_Outstanding = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LedgerOutstandingTableAdapter = new SoftwareDev.LedgersOutstandingsDataSetTableAdapters.LedgerOutstandingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerOutstandingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedgersOutstandingsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LedgerOutstandingBindingSource
            // 
            this.LedgerOutstandingBindingSource.DataMember = "LedgerOutstanding";
            this.LedgerOutstandingBindingSource.DataSource = this.LedgersOutstandingsDataSet;
            // 
            // LedgersOutstandingsDataSet
            // 
            this.LedgersOutstandingsDataSet.DataSetName = "LedgersOutstandingsDataSet";
            this.LedgersOutstandingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rp_Outstanding
            // 
            reportDataSource1.Name = "Outstanding";
            reportDataSource1.Value = this.LedgerOutstandingBindingSource;
            this.rp_Outstanding.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_Outstanding.LocalReport.ReportEmbeddedResource = "SoftwareDev.Report2.rdlc";
            this.rp_Outstanding.Location = new System.Drawing.Point(12, 12);
            this.rp_Outstanding.Name = "rp_Outstanding";
            this.rp_Outstanding.ServerReport.BearerToken = null;
            this.rp_Outstanding.Size = new System.Drawing.Size(673, 426);
            this.rp_Outstanding.TabIndex = 0;
            // 
            // LedgerOutstandingTableAdapter
            // 
            this.LedgerOutstandingTableAdapter.ClearBeforeFill = true;
            // 
            // Outstanding_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.rp_Outstanding);
            this.Name = "Outstanding_Report";
            this.Text = "Outstanding Report";
            this.Load += new System.EventHandler(this.Outstanding_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LedgerOutstandingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedgersOutstandingsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource LedgerOutstandingBindingSource;
        private LedgersOutstandingsDataSet LedgersOutstandingsDataSet;
        private LedgersOutstandingsDataSetTableAdapters.LedgerOutstandingTableAdapter LedgerOutstandingTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer rp_Outstanding;
    }
}