using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDev
{
    public partial class CompanyStartup : Form
    {
        public CompanyStartup()
        {
            InitializeComponent();
        }

        private void openCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanySelect companySelect = new CompanySelect();
            companySelect.Show();
        }
    }
}
