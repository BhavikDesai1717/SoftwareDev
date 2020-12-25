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
    public partial class Client_Master : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        public Client_Master()
        {
            InitializeComponent();
        }

        private void Client_Master_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ClientDB' table. You can move, or remove it, as needed.
            this.clientDBTableAdapter.Fill(this.client_DatabaseDataSet.ClientDB);

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            ButtonClicked.addClientMaster = (sender as Button).Text;
            addClient.ShowDialog();
            refreshClientGrid();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            ButtonClicked.editClientMaster = (sender as Button).Text;
            addClient.lbl_ID.Text = dg_Client.CurrentRow.Cells[5].Value.ToString();
            addClient.txt_Name.Text = dg_Client.CurrentRow.Cells[1].Value.ToString();
            addClient.txt_ShortCode.Text = dg_Client.CurrentRow.Cells[4].Value.ToString();
            addClient.cmb_Account.Text = dg_Client.CurrentRow.Cells[3].Value.ToString();
            addClient.txt_Country.Text = dg_Client.CurrentRow.Cells[2].Value.ToString();
            addClient.ShowDialog();
            refreshClientGrid();
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            ButtonClicked.displayClientMaster = (sender as Button).Text;
            addClient.lbl_ID.Text = dg_Client.CurrentRow.Cells[5].Value.ToString();
            addClient.txt_Name.Text = dg_Client.CurrentRow.Cells[1].Value.ToString();
            addClient.txt_ShortCode.Text = dg_Client.CurrentRow.Cells[4].Value.ToString();
            addClient.cmb_Account.Text = dg_Client.CurrentRow.Cells[3].Value.ToString();
            addClient.txt_Country.Text = dg_Client.CurrentRow.Cells[2].Value.ToString();
            addClient.ShowDialog();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            ButtonClicked.clientImport = (sender as Button).Text;
            Import import = new Import();
            import.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (SqlConnection conColor = new SqlConnection(conClient))
                {
                    conColor.Open();
                    using (SqlCommand cmd = conColor.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM ClientDB WHERE Client_ID=@cID";
                        cmd.Parameters.AddWithValue("@cID", dg_Client.CurrentRow.Cells[5].Value);
                        cmd.ExecuteNonQuery();
                    }
                    conColor.Close();
                }
            }
            refreshClientGrid();
        }

        private void refreshClientGrid()
        {
            SqlConnection conColor = new SqlConnection(conClient);
            conColor.Open();
            SqlCommand cmd;
            string query = "SELECT * FROM ClientDB";
            cmd = new SqlCommand(query, conColor);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            dg_Client.DataSource = dt;
            conColor.Close();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Export?", "Confirm Export", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dg_Client.SelectAll();
                DataObject dataObj = dg_Client.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);

                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_Client_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_Client.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
