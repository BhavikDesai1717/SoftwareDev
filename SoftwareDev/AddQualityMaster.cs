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
    public partial class AddQualityMaster : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;

        public AddQualityMaster()
        {
            InitializeComponent();
        }

        private void AddQualityMaster_Load(object sender, EventArgs e)
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
            dg_QualityDB.DataSource = dt;
            conQuality.Close();
        }

        private void dg_QualityDB_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_QualityDB.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void addQuality()
        {
            AddQuality addQuality = new AddQuality();
            addQuality.ShowDialog();
            refreshQualityGrid();
        }

        private void btn_AddQuality_Click(object sender, EventArgs e)
        {
            ButtonClicked.addNewQualityButton = (sender as Button).Text;
            addQuality();
        }

        private void btn_AddQuality_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addNewQualityButton = (sender as Button).Text;
                addQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editQualityButton = (sender as Button).Text;
                editQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displayQualityButton = (sender as Button).Text;
                displayQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }
        private void editQuality()
        {
            AddQuality addQuality = new AddQuality();
            addQuality.lbl_QualityID.Text = dg_QualityDB.CurrentRow.Cells[3].Value.ToString();
            addQuality.txt_QualityCode.Text = dg_QualityDB.CurrentRow.Cells[1].Value.ToString();
            addQuality.txt_Quality.Text = dg_QualityDB.CurrentRow.Cells[2].Value.ToString();
            addQuality.ShowDialog();
            refreshQualityGrid();
        }
        private void btn_EditQuality_Click(object sender, EventArgs e)
        {
            ButtonClicked.editQualityButton = (sender as Button).Text;
            editQuality();
        }

        private void btn_EditQuality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addNewQualityButton = (sender as Button).Text;
                addQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editQualityButton = (sender as Button).Text;
                editQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displayQualityButton = (sender as Button).Text;
                displayQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }
        private void displayQuality()
        {
            AddQuality addQuality = new AddQuality();
            addQuality.lbl_QualityID.Text = dg_QualityDB.CurrentRow.Cells[3].Value.ToString();
            addQuality.txt_QualityCode.Text = dg_QualityDB.CurrentRow.Cells[1].Value.ToString();
            addQuality.txt_Quality.Text = dg_QualityDB.CurrentRow.Cells[2].Value.ToString();
            addQuality.ShowDialog();
        }
        private void btn_DisplayQuality_Click(object sender, EventArgs e)
        {
            ButtonClicked.displayQualityButton = (sender as Button).Text;
            displayQuality();
        }

        private void btn_DisplayQuality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addNewQualityButton = (sender as Button).Text;
                addQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editQualityButton = (sender as Button).Text;
                editQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displayQualityButton = (sender as Button).Text;
                displayQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addNewQualityButton = (sender as Button).Text;
                addQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editQualityButton = (sender as Button).Text;
                editQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displayQualityButton = (sender as Button).Text;
                displayQuality();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            ButtonClicked.qualityImport = (sender as Button).Text;
            import.ShowDialog();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Export?", "Confirm Export", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dg_QualityDB.SelectAll();
                DataObject dataObj = dg_QualityDB.GetClipboardContent();
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
