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
using Microsoft.Office.Interop.Excel;

namespace SoftwareDev
{
    public partial class AddAccount : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;

        public AddAccount()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.AccountDB' table. You can move, or remove it, as needed.
            this.accountDBTableAdapter.Fill(this.client_DatabaseDataSet.AccountDB);

        }

        private void refreshAccountGrid()
        {
            SqlConnection conQuality = new SqlConnection(conClient);
            conQuality.Open();
            SqlCommand cmd;
            string query = "SELECT * FROM AccountDB";
            cmd = new SqlCommand(query, conQuality);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            dg_AccountDB.DataSource = dt;
            conQuality.Close();
        }

        private void dg_AccountDB_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_AccountDB.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void addAccount()
        {
            AddAccounts addAccounts = new AddAccounts();
            addAccounts.ShowDialog();
            refreshAccountGrid();
        }
        private void editAccount()
        {
            AddAccounts addAccounts = new AddAccounts();
            addAccounts.lbl_AccountID.Text = dg_AccountDB.CurrentRow.Cells[2].Value.ToString();
            addAccounts.txt_Account.Text = dg_AccountDB.CurrentRow.Cells[1].Value.ToString();
            addAccounts.ShowDialog();
            refreshAccountGrid();
        }
        private void displayAccount()
        {
            AddAccounts addAccounts = new AddAccounts();
            addAccounts.lbl_AccountID.Text = dg_AccountDB.CurrentRow.Cells[2].Value.ToString();
            addAccounts.txt_Account.Text = dg_AccountDB.CurrentRow.Cells[1].Value.ToString();
            addAccounts.ShowDialog();
            refreshAccountGrid();
        }
        private void btn_AddNewAccount_Click(object sender, EventArgs e)
        {
            ButtonClicked.addAccountMaster = (sender as System.Windows.Forms.Button).Text;
            addAccount();
        }

        private void btn_AddNewAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addAccountMaster = (sender as System.Windows.Forms.Button).Text;
                addAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editAccountMaster = (sender as System.Windows.Forms.Button).Text;
                editAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displayAccountMaster = (sender as System.Windows.Forms.Button).Text;
                displayAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D)
            {
                deleteAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.I)
            {

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }

        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            ButtonClicked.editAccountMaster = (sender as System.Windows.Forms.Button).Text;
            editAccount();
        }

        private void btn_DsiplayAccount_Click(object sender, EventArgs e)
        {
            ButtonClicked.displayAccountMaster = (sender as System.Windows.Forms.Button).Text;
            displayAccount();
        }

        private void btn_CloseAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EditAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addAccountMaster = (sender as System.Windows.Forms.Button).Text;
                addAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editAccountMaster = (sender as System.Windows.Forms.Button).Text;
                editAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displayAccountMaster = (sender as System.Windows.Forms.Button).Text;
                displayAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D)
            {
                deleteAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.I)
            {

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }

        private void btn_DsiplayAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addAccountMaster = (sender as System.Windows.Forms.Button).Text;
                addAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editAccountMaster = (sender as System.Windows.Forms.Button).Text;
                editAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displayAccountMaster = (sender as System.Windows.Forms.Button).Text;
                displayAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D)
            {
                deleteAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.I)
            {

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }

        private void btn_CloseAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addAccountMaster = (sender as System.Windows.Forms.Button).Text;
                addAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editAccountMaster = (sender as System.Windows.Forms.Button).Text;
                editAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displayAccountMaster = (sender as System.Windows.Forms.Button).Text;
                displayAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D)
            {
                deleteAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.I)
            {

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }
        private void deleteAccount()
        {
            if (MessageBox.Show("Delete?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (SqlConnection conB = new SqlConnection(conClient))
                {
                    conB.Open();
                    using (SqlCommand cmd = conB.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM AccountDB WHERE SrNo = @bID";
                        cmd.Parameters.AddWithValue("@bID", dg_AccountDB.CurrentRow.Cells[2].Value);
                        cmd.ExecuteNonQuery();
                    }
                    conB.Close();
                }
                refreshAccountGrid();
            }
        }
        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            deleteAccount();
        }

        private void btn_DeleteAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ButtonClicked.addAccountMaster = (sender as System.Windows.Forms.Button).Text;
                addAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                ButtonClicked.editAccountMaster = (sender as System.Windows.Forms.Button).Text;
                editAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                ButtonClicked.displayAccountMaster = (sender as System.Windows.Forms.Button).Text;
                displayAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D)
            {
                deleteAccount();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.I)
            {

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {

            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }

        private void btn_ImportAccount_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            ButtonClicked.accountImport = (sender as System.Windows.Forms.Button).Text;
            import.ShowDialog();
        }
       
        private void btn_ExportAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Export?", "Confirm Export", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dg_AccountDB.SelectAll();
                DataObject dataObj = dg_AccountDB.GetClipboardContent();
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
