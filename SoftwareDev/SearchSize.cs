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
    public partial class SearchSize : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        public string sSize, sCode;
        public SearchSize()
        {
            InitializeComponent();
        }

        private void SearchSize_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ProductSizeDB' table. You can move, or remove it, as needed.
            this.productSizeDBTableAdapter.Fill(this.client_DatabaseDataSet.ProductSizeDB);

        }
        private void refreshSizeGrid()
        {
            SqlConnection conSize = new SqlConnection(conClient);
            conSize.Open();
            SqlCommand cmd;
            string query = "SELECT * FROM ProductSizeDB";
            cmd = new SqlCommand(query, conSize);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            dg_sizeSearch.DataSource = dt;
            conSize.Close();
        }

        private void SearchSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.C)
            {
                AddSize aS = new AddSize();
                aS.ShowDialog();
                refreshSizeGrid();
            }
        }

        private void txt_sizeSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ProductSizeDB WHERE ProductSize like '" + txt_sizeSearch.Text + "%'", conC);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dg_sizeSearch.DataSource = dt;
                conC.Close();
            }

        }

        private void dg_sizeSearch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_sizeSearch.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dg_sizeSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_sizeSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void addSize()
        {
            AddSize aS = new AddSize();
            aS.ShowDialog();
            refreshSizeGrid();
        }
        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            ButtonClicked.addNewSizeButton = (sender as Button).Text;
            addSize();
        }

        private void dg_sizeSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseOrder po = new PurchaseOrder();
            sCode = this.dg_sizeSearch.CurrentRow.Cells[2].Value.ToString();
            sSize = this.dg_sizeSearch.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}
