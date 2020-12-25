using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SoftwareDev
{
    public partial class Outstanding_Report : Form
    {
        public string parameterMS;
        public Outstanding_Report()
        {
            InitializeComponent();
        }

        private void Outstanding_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LedgersOutstandingsDataSet.LedgerOutstanding' table. You can move, or remove it, as needed.
            this.LedgerOutstandingTableAdapter.Fill(this.LedgersOutstandingsDataSet.LedgerOutstanding);
            ReportParameter[] pMS = new ReportParameter[1]; 
            pMS[0] = new ReportParameter("MS", parameterMS); 
            //params[1] = new ReportParameter("EndDate", dtEndDate, false);
            this.rp_Outstanding.ServerReport.SetParameters(pMS);
            this.rp_Outstanding.RefreshReport();
        }
    }
}
