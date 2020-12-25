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
    public partial class AddColorMaster : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;

        public AddColorMaster()
        {
            InitializeComponent();
        }

        private void AddColorMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ProductColorDB' table. You can move, or remove it, as needed.
            this.productColorDBTableAdapter.Fill(this.client_DatabaseDataSet.ProductColorDB);
            this.FormBorderStyle = FormBorderStyle.None;
            
        }
        private void refreshColorGrid()
        {
            SqlConnection conColor = new SqlConnection(conClient);
            conColor.Open();
            SqlCommand cmd;
            string query = "SELECT * FROM ProductColorDB";
            cmd = new SqlCommand(query, conColor);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            dg_ColorDB.DataSource = dt;
            conColor.Close();
        }
        private void addColorFields()
        {
            AddNewColor addNewColor = new AddNewColor();
            addNewColor.ShowDialog();
            refreshColorGrid();
        }

        private void btn_AddColor_Click(object sender, EventArgs e)
        {
            ButtonClicked.addNewColorButton = (sender as Button).Text;
            addColorFields();
        }

        private void btn_AddColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addNewColorButton = (sender as Button).Text;
                addColorFields();
            }
        }
        private void editColorData()
        {
            AddNewColor addNewColor = new AddNewColor();
            addNewColor.lbl_ColorID.Text = dg_ColorDB.CurrentRow.Cells[3].Value.ToString();
            addNewColor.txt_ColorCode.Text = dg_ColorDB.CurrentRow.Cells[1].Value.ToString();
            addNewColor.txt_ColorName.Text = dg_ColorDB.CurrentRow.Cells[2].Value.ToString();
            addNewColor.ShowDialog();
            refreshColorGrid();
        }

        private void btn_EditColor_Click(object sender, EventArgs e)
        {
            ButtonClicked.editColorButton = (sender as Button).Text;
            editColorData();
        }

        private void btn_EditColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editColorButton = (sender as Button).Text;
                editColorData();
            }
        }
        private void displayColorData()
        {
            AddNewColor addNewColor = new AddNewColor();
            addNewColor.lbl_ColorID.Text = dg_ColorDB.CurrentRow.Cells[3].Value.ToString();
            addNewColor.txt_ColorCode.Text = dg_ColorDB.CurrentRow.Cells[1].Value.ToString();
            addNewColor.txt_ColorName.Text = dg_ColorDB.CurrentRow.Cells[2].Value.ToString();
            addNewColor.ShowDialog();
        }
        private void btn_DisplayColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displayColorButton = (sender as Button).Text;
                displayColorData();
            }
        }

        private void btn_DisplayColor_Click(object sender, EventArgs e)
        {
            ButtonClicked.displayColorButton = (sender as Button).Text;
            displayColorData();
        }
        private void deleteColorData()
        {
            if (MessageBox.Show("Delete?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (SqlConnection conColor = new SqlConnection(conClient))
                {
                    conColor.Open();
                    using (SqlCommand cmd = conColor.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM ProductColorDB WHERE SrNo=@cID";
                        cmd.Parameters.AddWithValue("@cID", dg_ColorDB.CurrentRow.Cells[3].Value);
                        cmd.ExecuteNonQuery();
                    }
                    conColor.Close();
                }
            }
            refreshColorGrid();
        }
        private void btn_DeleteColor_Click(object sender, EventArgs e)
        {
            deleteColorData();
        }

        private void btn_DeleteColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D)
            {
                deleteColorData();
            }
        }

        private void btn_CloseColor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CloseColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }
        private void dg_ColorDB_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_ColorDB.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btn_ImportColor_Click(object sender, EventArgs e)
        {
            ButtonClicked.colorImport = (sender as Button).Text;
            Import import = new Import();
            import.ShowDialog();
        }

        private void btn_ExportColor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Export?", "Confirm Export", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dg_ColorDB.SelectAll();
                DataObject dataObj = dg_ColorDB.GetClipboardContent();
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
