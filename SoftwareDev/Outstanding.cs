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
    public partial class Outstanding : Form
    {
        
        public Outstanding()
        {
            InitializeComponent();
        }

        private void Outstanding_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ClientDB' table. You can move, or remove it, as needed.
            this.clientDBTableAdapter.Fill(this.client_DatabaseDataSet.ClientDB);

        }

        private void lt_Clients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Outstanding_Report outstanding_Report = new Outstanding_Report();
            outstanding_Report.parameterMS = lt_Clients.SelectedItem.ToString();
            outstanding_Report.ShowDialog();
        }
    }
}
