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
    public partial class CompanySelect : Form
    {
        public CompanySelect()
        {
            InitializeComponent();
        }

        private void CompanySelect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialYearDataSet.FinancialYear' table. You can move, or remove it, as needed.
            this.financialYearTableAdapter.Fill(this.financialYearDataSet.FinancialYear);
            // TODO: This line of code loads data into the 'companyProfileDataSet.CompanyProfile' table. You can move, or remove it, as needed.
            this.companyProfileTableAdapter.Fill(this.companyProfileDataSet.CompanyProfile);
            
        }

        private void btn_Start_Company_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            ButtonClicked.softwareStart = (sender as Button).Text;
            ButtonClicked.companySelect = dg_CompanySelect.CurrentRow.Cells[0].Value.ToString();
            ButtonClicked.financialYearStart = Convert.ToDateTime(dg_FinancialYearSelect.CurrentRow.Cells[0].Value.ToString());
            ButtonClicked.financialYearEnd = Convert.ToDateTime(dg_FinancialYearSelect.CurrentRow.Cells[1].Value.ToString());
            this.Close();
        }

        private void CompanySelect_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control && e.KeyCode == Keys.O)
            {
                MainWindow mainWindow = new MainWindow();
                ButtonClicked.softwareStart = (sender as Button).Text;
                ButtonClicked.companySelect = dg_CompanySelect.CurrentRow.Cells[0].Value.ToString();
                ButtonClicked.financialYearStart = Convert.ToDateTime(dg_FinancialYearSelect.CurrentRow.Cells[0].Value.ToString());
                ButtonClicked.financialYearEnd = Convert.ToDateTime(dg_FinancialYearSelect.CurrentRow.Cells[1].Value.ToString());
                this.Close();
            }
        }

        private void label2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.O)
            {
                MainWindow mainWindow = new MainWindow();
                ButtonClicked.softwareStart = (sender as Button).Text;
                ButtonClicked.companySelect = dg_CompanySelect.CurrentRow.Cells[0].Value.ToString();
                ButtonClicked.financialYearStart = Convert.ToDateTime(dg_FinancialYearSelect.CurrentRow.Cells[0].Value.ToString());
                ButtonClicked.financialYearEnd = Convert.ToDateTime(dg_FinancialYearSelect.CurrentRow.Cells[1].Value.ToString());
                this.Close();
            }
        }
    }
}
