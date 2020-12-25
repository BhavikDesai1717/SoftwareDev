using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SoftwareDev
{
    public partial class SearchQuality : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        public string qQuality, qCode;
        public SearchQuality()
        {
            InitializeComponent();
        }

        private void SearchQuality_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ProductQualityDB' table. You can move, or remove it, as needed.
            this.productQualityDBTableAdapter.Fill(this.client_DatabaseDataSet.ProductQualityDB);

        }
        private void refreshQualityGrid()
        {
            SqlConnection conQuality = new SqlConnection(conClient);
            conQuality.Open();
            SqlCommand cmd;
            string query = "SELECT * FROM ProductQualityDB";
            cmd = new SqlCommand(query, conQuality);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            dg_SearchQuality.DataSource = dt;
            conQuality.Close();
        }

        private void txt_searchQuality_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_searchQuality_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ProductQualityDB WHERE ProductQuality like '" + txt_searchQuality.Text + "%'", conC);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dg_SearchQuality.DataSource = dt;
                conC.Close();
            }
        }

        private void dg_SearchQuality_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_SearchQuality.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dg_SearchQuality_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseOrder po = new PurchaseOrder();
            qCode = this.dg_SearchQuality.CurrentRow.Cells[2].Value.ToString();
            qQuality = this.dg_SearchQuality.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
        private void addQuality()
        {
            AddQuality aQ = new AddQuality();
            aQ.ShowDialog();
            refreshQualityGrid();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            ButtonClicked.addNewQualityButton = (sender as Button).Text;
            addQuality();
        }

        private void dg_SearchQuality_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
