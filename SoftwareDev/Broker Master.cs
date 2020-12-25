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
    public partial class Broker_Master : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;

        public Broker_Master()
        {
            InitializeComponent();
        }

        private void Broker_Master_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.BrokerDB' table. You can move, or remove it, as needed.
            this.brokerDBTableAdapter.Fill(this.client_DatabaseDataSet.BrokerDB);

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            Add_Broker add_Broker = new Add_Broker();
            ButtonClicked.addBrokerMaster = (sender as Button).Text;
            add_Broker.ShowDialog();
            refreshBrokerGrid();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Add_Broker add_Broker = new Add_Broker();
            ButtonClicked.editBrokerMaster = (sender as Button).Text;
            add_Broker.lbl_ID.Text = dg_Broker.CurrentRow.Cells[7].Value.ToString();
            add_Broker.txt_Name.Text = dg_Broker.CurrentRow.Cells[1].Value.ToString();
            add_Broker.rt_Address.Text = dg_Broker.CurrentRow.Cells[2].Value.ToString();
            add_Broker.txt_ContactNo.Text = dg_Broker.CurrentRow.Cells[3].Value.ToString();
            add_Broker.txt_Country.Text = dg_Broker.CurrentRow.Cells[4].Value.ToString();
            add_Broker.txt_State.Text = dg_Broker.CurrentRow.Cells[5].Value.ToString();
            add_Broker.txt_PostalCode.Text = dg_Broker.CurrentRow.Cells[6].Value.ToString();
            add_Broker.ShowDialog();
            refreshBrokerGrid();
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            Add_Broker add_Broker = new Add_Broker();
            ButtonClicked.displayBrokerMaster = (sender as Button).Text;
            add_Broker.lbl_ID.Text = dg_Broker.CurrentRow.Cells[7].Value.ToString();
            add_Broker.txt_Name.Text = dg_Broker.CurrentRow.Cells[1].Value.ToString();
            add_Broker.rt_Address.Text = dg_Broker.CurrentRow.Cells[2].Value.ToString();
            add_Broker.txt_ContactNo.Text = dg_Broker.CurrentRow.Cells[3].Value.ToString();
            add_Broker.txt_Country.Text = dg_Broker.CurrentRow.Cells[4].Value.ToString();
            add_Broker.txt_State.Text = dg_Broker.CurrentRow.Cells[5].Value.ToString();
            add_Broker.txt_PostalCode.Text = dg_Broker.CurrentRow.Cells[6].Value.ToString();
            add_Broker.ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void deleteBroker()
        {
            if (MessageBox.Show("Delete?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (SqlConnection conColor = new SqlConnection(conClient))
                {
                    conColor.Open();
                    using (SqlCommand cmd = conColor.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM BrokerDB WHERE BrokerID=@bID";
                        cmd.Parameters.AddWithValue("@bID", dg_Broker.CurrentRow.Cells[7].Value);
                        cmd.ExecuteNonQuery();
                    }
                    conColor.Close();
                }
            }
            refreshBrokerGrid();
        }

        private void refreshBrokerGrid()
        {
            SqlConnection conColor = new SqlConnection(conClient);
            conColor.Open();
            SqlCommand cmd;
            string query = "SELECT * FROM BrokerDB";
            cmd = new SqlCommand(query, conColor);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            dg_Broker.DataSource = dt;
            conColor.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            deleteBroker();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            ButtonClicked.brokerImport = (sender as Button).Text;
            Import import = new Import();
            import.ShowDialog();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Export?", "Confirm Export", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dg_Broker.SelectAll();
                DataObject dataObj = dg_Broker.GetClipboardContent();
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

        private void dg_Broker_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_Broker.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
