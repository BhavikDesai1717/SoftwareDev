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

    public partial class AddSizeMaster : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;

        public AddSizeMaster()
        {
            InitializeComponent();
        }

        private void AddSizeMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ProductSizeDB' table. You can move, or remove it, as needed.
            this.productSizeDBTableAdapter.Fill(this.client_DatabaseDataSet.ProductSizeDB);

        }
        private void refreshGridSize()
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
            dg_SizeDB.DataSource = dt;
            conSize.Close();
        }

        private void dg_SizeDB_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_SizeDB.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void addSize()
        {
            AddSize addSize = new AddSize();
            addSize.ShowDialog();
            refreshGridSize();
        }
        private void btn_AddSize_Click(object sender, EventArgs e)
        {
            ButtonClicked.addNewSizeButton = (sender as Button).Text;
            addSize();
        }

        private void btn_AddSize_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addNewSizeButton = (sender as Button).Text;
                addSize();
            }
        }
        private void editSize()
        {
            AddSize addSize = new AddSize();
            addSize.lbl_SizeID.Text = dg_SizeDB.CurrentRow.Cells[3].Value.ToString();
            addSize.txt_SizeCode.Text = dg_SizeDB.CurrentRow.Cells[1].Value.ToString();
            addSize.txt_Size.Text = dg_SizeDB.CurrentRow.Cells[2].Value.ToString();
            addSize.ShowDialog();
            refreshGridSize();
        }
        private void btn_EditSize_Click(object sender, EventArgs e)
        {
            ButtonClicked.editSizeButton = (sender as Button).Text;
            editSize();
        }

        private void btn_EditSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editSizeButton = (sender as Button).Text;
                editSize();
            }
        }
        private void displaySize()
        {
            AddSize addSize = new AddSize();
            addSize.lbl_SizeID.Text = dg_SizeDB.CurrentRow.Cells[3].Value.ToString();
            addSize.txt_SizeCode.Text = dg_SizeDB.CurrentRow.Cells[1].Value.ToString();
            addSize.txt_Size.Text = dg_SizeDB.CurrentRow.Cells[2].Value.ToString();
            addSize.ShowDialog();
        }

        private void btn_DisplaySize_Click(object sender, EventArgs e)
        {
            ButtonClicked.displaySizeButton = (sender as Button).Text;
            displaySize();
        }

        private void btn_DisplaySize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displaySizeButton = (sender as Button).Text;
                displaySize();
            }
        }

        private void btn_CloseSize_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CloseSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D)
            {
                this.Close();
            }
        }
        private void btn_Import_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            ButtonClicked.sizeImport = (sender as Button).Text;
            import.ShowDialog();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Export?", "Confirm Export", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dg_SizeDB.SelectAll();
                DataObject dataObj = dg_SizeDB.GetClipboardContent();
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
    }
}
