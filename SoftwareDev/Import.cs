using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SoftwareDev
{
    public partial class Import : Form
    {
        static string conColor = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;

        DataTableCollection tableCollection;
        public Import()
        {
            InitializeComponent();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog() { Filter="Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"})
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb_FileName.Text = openFileDialog.FileName;
                    using(var stream = File.Open(openFileDialog.FileName,FileMode.Open,FileAccess.Read))
                    {
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable=(_)=>new ExcelDataTableConfiguration() { UseHeaderRow = true}
                            });
                            tableCollection = result.Tables;
                            cbo_SheetName.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbo_SheetName.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void cbo_SheetName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbo_SheetName.SelectedItem.ToString()];
            dg_Content.DataSource = dt;
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.colorImport))
            {
                for (int i = 0; i < dg_Content.Rows.Count - 1; i++)
                {

                    using (SqlConnection conC = new SqlConnection(conColor))
                    {
                        conC.Open();
                        using (SqlCommand cmd = conC.CreateCommand())
                        {
                            cmd.CommandText = "insert into ProductColorDB(ProductColor,ColorCode) values(@color,@cCode)";
                            cmd.Parameters.AddWithValue("@color", dg_Content.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@cCode", dg_Content.Rows[i].Cells[1].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        conC.Close();
                    }
                }
                ButtonClicked.colorImport = String.Empty;
            }
            if(!string.IsNullOrEmpty(ButtonClicked.sizeImport))
            {
                for (int i = 0; i < dg_Content.Rows.Count - 1; i++)
                {

                    using (SqlConnection conS = new SqlConnection(conColor))
                    {
                        conS.Open();
                        using (SqlCommand cmd = conS.CreateCommand())
                        {
                            cmd.CommandText = "insert into ProductSizeDB(ProductSize,SizeCode) values(@size,@sCode)";
                            cmd.Parameters.AddWithValue("@size", dg_Content.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@sCode", dg_Content.Rows[i].Cells[1].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        conS.Close();
                    }
                }
                ButtonClicked.sizeImport = String.Empty;
            }
            if (!string.IsNullOrEmpty(ButtonClicked.qualityImport))
            {
                for (int i = 0; i < dg_Content.Rows.Count - 1; i++)
                {

                    using (SqlConnection conQ = new SqlConnection(conColor))
                    {
                        conQ.Open();
                        using (SqlCommand cmd = conQ.CreateCommand())
                        {
                            cmd.CommandText = "insert into ProductQualityDB(ProductQuality,QualityCode) values(@quality,@qCode)";
                            cmd.Parameters.AddWithValue("@quality", dg_Content.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@qCode", dg_Content.Rows[i].Cells[1].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        conQ.Close();
                    }
                }
                ButtonClicked.qualityImport = String.Empty;
            }
            if (!string.IsNullOrEmpty(ButtonClicked.clientImport))
            {
                for (int i = 0; i < dg_Content.Rows.Count - 1; i++)
                {

                    using (SqlConnection conClient = new SqlConnection(conColor))
                    {
                        conClient.Open();
                        using (SqlCommand cmd = conClient.CreateCommand())
                        {
                            cmd.CommandText = "insert into ClientDB(Name,Country,ShortCode,Account) values(@name,@country,@sc,@acc)";
                            cmd.Parameters.AddWithValue("@sc", dg_Content.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@name", dg_Content.Rows[i].Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@country", dg_Content.Rows[i].Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@acc", dg_Content.Rows[i].Cells[3].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        conClient.Close();
                    }
                }
                ButtonClicked.clientImport = String.Empty;
            }
            if (!string.IsNullOrEmpty(ButtonClicked.brokerImport))
            {
                for (int i = 0; i < dg_Content.Rows.Count - 1; i++)
                {

                    using (SqlConnection conB = new SqlConnection(conColor))
                    {
                        conB.Open();
                        using (SqlCommand cmd = conB.CreateCommand())
                        {
                            cmd.CommandText = "insert into BrokerDB(Name,Address_Line_1,Country,State,Postal_Code,Contact_No) values(@name,@address,@country,@state,@postal,@contact)";
                            cmd.Parameters.AddWithValue("@name", dg_Content.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@address", dg_Content.Rows[i].Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@country", dg_Content.Rows[i].Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@state", dg_Content.Rows[i].Cells[3].Value.ToString());
                            cmd.Parameters.AddWithValue("@Postal_Code", dg_Content.Rows[i].Cells[4].Value.ToString());
                            cmd.Parameters.AddWithValue("@Contact_No", dg_Content.Rows[i].Cells[5].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        conB.Close();
                    }
                }
                ButtonClicked.brokerImport = String.Empty;
            }
            if (!string.IsNullOrEmpty(ButtonClicked.accountImport))
            {
                for (int i = 0; i < dg_Content.Rows.Count - 1; i++)
                {

                    using (SqlConnection conA = new SqlConnection(conColor))
                    {
                        conA.Open();
                        using (SqlCommand cmd = conA.CreateCommand())
                        {
                            cmd.CommandText = "insert into AccountDB(Account) values(@acc)";
                            cmd.Parameters.AddWithValue("@acc", dg_Content.Rows[i].Cells[0].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        conA.Close();
                    }
                }
                ButtonClicked.accountImport = String.Empty;
            }
            
        }

        private void Import_Load(object sender, EventArgs e)
        {

        }
    }
}
