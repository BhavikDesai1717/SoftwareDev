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
    public partial class Journals : Form
    {
        static string chartOfAccounts = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.AccountsConnectionString"].ConnectionString;
        public Journals()
        {
            InitializeComponent();
        }
        private void jvNo()
        {
            String query = "SELECT max (SrNo)+1 FROM JV";
            using (SqlConnection cons = new SqlConnection(chartOfAccounts))
            {
                using (SqlCommand cmd_Auto = new SqlCommand(query, cons))
                {
                    SqlDataReader dtr;
                    try
                    {
                        cons.Open();
                        dtr = cmd_Auto.ExecuteReader();
                        if (dtr.HasRows)
                        {
                            while (dtr.Read())
                            {
                                lbl_JournalAutoNo.Text = dtr[0].ToString();
                                if (lbl_JournalAutoNo.Text == "")
                                {
                                    lbl_JournalAutoNo.Text = "1";
                                }
                            }
                        }
                        else
                        {
                            lbl_JournalAutoNo.Text = "1";
                        }
                        cons.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void submitJournal()
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Submit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conAccount = new SqlConnection(chartOfAccounts))
                {
                    conAccount.Open();
                    using (SqlCommand cmd = conAccount.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO JV(jvNo,jvDate,notes) Values(@jvNo,@jvDate,@jvNotes)";
                        cmd.Parameters.AddWithValue("@jvNo", lbl_JournalAutoNo.Text);
                        cmd.Parameters.AddWithValue("@jvDate", dt_JVDate.Value.Date);
                        cmd.Parameters.AddWithValue("@jvNotes", rt_Notes.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    conAccount.Close();
                }
                for (int i = 0; i < dg_JVDetails.Rows.Count - 1; i++)
                {
                    using (SqlConnection conDGAccount = new SqlConnection(chartOfAccounts))
                    {
                        conDGAccount.Open();
                        using (SqlCommand cmdDG = conDGAccount.CreateCommand())
                        {
                            cmdDG.CommandText = "INSERT INTO JVEntries(jvNo,accountName,description,client,debit,credit) VALUES(@jvN,@jvAccount,@jvDescription,@jvClient,@jvDebit,@jvCredit)";
                            cmdDG.Parameters.AddWithValue("@jvN", lbl_JournalAutoNo.Text);
                            cmdDG.Parameters.AddWithValue("@jvAccount", Convert.ToString(dg_JVDetails.Rows[i].Cells[0].Value));
                            cmdDG.Parameters.AddWithValue("@jvDescription", Convert.ToString(dg_JVDetails.Rows[i].Cells[1].Value));
                            cmdDG.Parameters.AddWithValue("@jvClient", Convert.ToString(dg_JVDetails.Rows[i].Cells[2].Value));
                            cmdDG.Parameters.AddWithValue("@jvDebit", Convert.ToString(dg_JVDetails.Rows[i].Cells[3].Value));
                            cmdDG.Parameters.AddWithValue("@jvCredit", Convert.ToString(dg_JVDetails.Rows[i].Cells[4].Value));
                        }
                        conDGAccount.Close();
                    }
                }
            }
        }
        private void btn_SubmitJV_Click(object sender, EventArgs e)
        {
            submitJournal();
        }

        private void Journals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsDataSet.ChartOfAccounts' table. You can move, or remove it, as needed.
            this.chartOfAccountsTableAdapter.Fill(this.accountsDataSet.ChartOfAccounts);
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ClientDB' table. You can move, or remove it, as needed.
            this.clientDBTableAdapter.Fill(this.client_DatabaseDataSet.ClientDB);
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.AccountDB' table. You can move, or remove it, as needed.
            this.accountDBTableAdapter.Fill(this.client_DatabaseDataSet.AccountDB);
            jvNo();
        }
    }
}
