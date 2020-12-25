using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SoftwareDev
{
    public partial class Ledger : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        public Ledger()
        {
            InitializeComponent();
        }

        private void Ledger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ClientDB' table. You can move, or remove it, as needed.
            this.clientDBTableAdapter.Fill(this.client_DatabaseDataSet.ClientDB);

        }

        private void txt_SearchbyName_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ClientDB WHERE Name like '" + txt_SearchbyName.Text + "%'", conC);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dg_ClientLedger.DataSource = dt;
                conC.Close();
            }
        }

        private void dg_ClientLedger_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dg_ClientLedger_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Ledger_Details ledger_Details = new Ledger_Details();
            ButtonClicked.clientName = dg_ClientLedger.CurrentRow.Cells[0].Value.ToString();
            ledger_Details.ShowDialog();
        }
    }
}
