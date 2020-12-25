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
    public partial class Assortment : Form
    {
        public static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        public static string conWarehouse = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.WarehouseConnectionString"].ConnectionString;
        public Assortment()
        {
            InitializeComponent();
        }

        private void Assortment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ProductQualityDB' table. You can move, or remove it, as needed.
            this.productQualityDBTableAdapter.Fill(this.client_DatabaseDataSet.ProductQualityDB);
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ProductSizeDB' table. You can move, or remove it, as needed.
            this.productSizeDBTableAdapter.Fill(this.client_DatabaseDataSet.ProductSizeDB);
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ProductColorDB' table. You can move, or remove it, as needed.
            this.productColorDBTableAdapter.Fill(this.client_DatabaseDataSet.ProductColorDB);
        }
        private void fetch()
        {
            using (SqlConnection conW = new SqlConnection(conWarehouse))
            {
                conW.Open();
                using (SqlCommand cmd = conW.CreateCommand())
                {
                    cmd.CommandText = "select * from Warehouse where Color=@fColor AND Size=@fSize AND Quality=@fQuality AND Lot=@fLot";
                    cmd.Parameters.AddWithValue("@fColor", txt_Color.Text.ToString());
                    cmd.Parameters.AddWithValue("@fSize", txt_Size.Text.ToString());
                    cmd.Parameters.AddWithValue("@fQuality", txt_Quality.Text.ToString());
                    cmd.Parameters.AddWithValue("@fLot", txt_Lot.Text.ToString());
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {

                        txt_Quantity.Text = dt.Rows[0]["Balance_Quantity"].ToString();
                        txt_Rate.Text = dt.Rows[0]["Rate"].ToString();
                        txt_Rate.Text = String.Format("{0:#,##0.00}", double.Parse(txt_Rate.Text));
                    }
                    else
                    {
                        MessageBox.Show("Color: " + txt_Color.Text
                            + " ,Size: " + txt_Size.Text
                            + " ,Quality: " + txt_Quality.Text
                            + " ,Lot: " + txt_Lot.Text
                            + " does not exist in the Warehouse");
                    }
                }
                conW.Close();
            }
        }
        private void btn_Fetch_Click(object sender, EventArgs e)
        {
            fetch();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double quantity = 0.00;
            double rate = 0.00;
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Quantity" || dataGridView1.Columns[e.ColumnIndex].Name == "Rate")
            {
                for(int i = 0; i <dataGridView1.Rows.Count - 1;i++)
                {
                    quantity = quantity + Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
                    txt_FinalQuantity.Text = quantity.ToString();
                    double row_quantity, row_rate;
                    row_quantity = Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
                    row_rate = Convert.ToDouble(dataGridView1.Rows[i].Cells[9].Value);
                    rate = rate + (row_quantity * row_rate);
                }
                rate = rate / Convert.ToDouble(txt_Quantity.Text);
                txt_AvgRate.Text = rate.ToString();
                txt_AvgRate.Text = String.Format("{0:#,##0.00}", double.Parse(txt_AvgRate.Text));
            }
        }

        private void btn_Assort_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Quantity.Text) || !string.IsNullOrEmpty(txt_FinalQuantity.Text) || !string.IsNullOrEmpty(txt_Rate.Text) || !string.IsNullOrEmpty(txt_AvgRate.Text))
            {
                if (txt_Quantity.Text == txt_FinalQuantity.Text && txt_Rate.Text == txt_AvgRate.Text)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        using (SqlConnection conW = new SqlConnection(conWarehouse))
                        {
                            conW.Open();
                            using (SqlCommand cmd = conW.CreateCommand())
                            {
                                cmd.CommandText = "if exists(select * from Warehouse where Color=@wColor AND Size=@wSize AND Quality=@wQuality AND Lot=@wLot) update Warehouse set Rate=((Balance_Quantity*Rate)+(@balQuantity*@wRate))/(Balance_Quantity+@balQuantity),Inward_Quantity=Inward_Quantity+@inQuantity,Balance_Quantity=Balance_Quantity+@balQuantity where Color=@wColor AND Size=@wSize AND Quality=@wQuality AND Lot=@wLot else insert into Warehouse(Color,Size,Quality,Lot,Inward_Quantity,Balance_Quantity,Rate) values(@wColor,@wSize,@wQuality,@wLot,@inQuantity,@balQuantity,@wRate)";
                                cmd.Parameters.AddWithValue("@wColor", Convert.ToString(dataGridView1.Rows[i].Cells[2].Value));
                                cmd.Parameters.AddWithValue("@wSize", Convert.ToString(dataGridView1.Rows[i].Cells[4].Value));
                                cmd.Parameters.AddWithValue("@wQuality", Convert.ToString(dataGridView1.Rows[i].Cells[6].Value));
                                cmd.Parameters.AddWithValue("@wLot", Convert.ToString(dataGridView1.Rows[i].Cells[7].Value));
                                cmd.Parameters.AddWithValue("@inQuantity", Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value));
                                cmd.Parameters.AddWithValue("@balQuantity", Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value));
                                cmd.Parameters.AddWithValue("@wRate", Convert.ToDouble(dataGridView1.Rows[i].Cells[9].Value));
                                cmd.ExecuteNonQuery();
                            }
                            conW.Close();
                        }
                    }
                    dataGridView1.Rows.Clear();
                    txt_ColorCode.Text = String.Empty;
                    txt_Color.Text = String.Empty;
                    txt_SizeCode.Text = String.Empty;
                    txt_Size.Text = String.Empty;
                    txt_QualityCode.Text = String.Empty;
                    txt_Quality.Text = String.Empty;
                    txt_Lot.Text = String.Empty;
                    txt_Quantity.Text = String.Empty;
                    txt_FinalQuantity.Text = String.Empty;
                    txt_Rate.Text = String.Empty;
                    txt_AvgRate.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Avg Rate or Quantity does not match");
                }
            }else
            {
                MessageBox.Show("Quantity Field or Rate Field cannot be empty");
            }
            
        }

        private void txt_ColorCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
            {
                ColorAdd cA = new ColorAdd();
                cA.ShowDialog();
                this.txt_ColorCode.Text = cA.cCode;
                this.txt_Color.Text = cA.cColor;
            }
            if(e.Modifiers == Keys.Alt && e.KeyCode == Keys.F)
            {
                fetch();
            }
        }

        private void txt_SizeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
            {
                SearchSize ss = new SearchSize();
                ss.ShowDialog();
                this.txt_SizeCode.Text = ss.sCode;
                this.txt_Size.Text = ss.sSize;
            }
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F)
            {
                fetch();
            }
        }

        private void txt_QualityCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
            {
                SearchQuality searchQuality = new SearchQuality();
                searchQuality.ShowDialog();
                this.txt_QualityCode.Text = searchQuality.qCode;
                this.txt_Quality.Text = searchQuality.qQuality;
            }
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F)
            {
                fetch();
            }
        }

        private void txt_ColorCode_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                string query = "SELECT ProductColor FROM ProductColorDB WHERE ColorCode='" + txt_ColorCode.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query, conC))
                {
                    SqlDataReader dtaRead;
                    try
                    {
                        dtaRead = cmd.ExecuteReader();
                        while (dtaRead.Read())
                        {
                            txt_Color.Text = dtaRead["ProductColor"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conC.Close();
            }
        }

        private void txt_SizeCode_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                string query = "SELECT ProductSize FROM ProductSizeDB WHERE SizeCode='" + txt_SizeCode.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query, conC))
                {
                    SqlDataReader dtaRead;
                    try
                    {
                        dtaRead = cmd.ExecuteReader();
                        while (dtaRead.Read())
                        {
                           txt_Size.Text = dtaRead["ProductSize"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conC.Close();
            }
        }

        private void txt_QualityCode_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                string query = "SELECT ProductQuality FROM ProductQualityDB WHERE QualityCode='" + txt_QualityCode.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query, conC))
                {
                    SqlDataReader dtaRead;
                    try
                    {
                        dtaRead = cmd.ExecuteReader();
                        while (dtaRead.Read())
                        {
                            txt_Quality.Text = dtaRead["ProductQuality"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conC.Close();
            }
        }

        private void txt_Color_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F)
            {
                fetch();
            }
        }

        private void txt_Size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F)
            {
                fetch();
            }
        }

        private void txt_Quality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F)
            {
                fetch();
            }
        }

        private void txt_Lot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F)
            {
                fetch();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F)
            {
                fetch();
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    ColorAdd cA = new ColorAdd();
                    cA.ShowDialog();
                    this.dataGridView1.CurrentRow.Cells[1].Value = cA.cCode;
                    this.dataGridView1.CurrentRow.Cells[2].Value = cA.cColor;
                }
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    SearchSize ss = new SearchSize();
                    ss.ShowDialog();
                    this.dataGridView1.CurrentRow.Cells[3].Value = ss.sCode;
                    this.dataGridView1.CurrentRow.Cells[4].Value = ss.sSize;
                }
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    SearchQuality searchQuality = new SearchQuality();
                    searchQuality.ShowDialog();
                    this.dataGridView1.CurrentRow.Cells[5].Value = searchQuality.qCode;
                    this.dataGridView1.CurrentRow.Cells[6].Value = searchQuality.qQuality;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "ColorCode")
                {
                    if (dataGridView1.Rows[i].Cells[1].Value == String.Empty)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductColor FROM ProductColorDB WHERE ColorCode='" + dataGridView1.Rows[i].Cells[1].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dataGridView1.Rows[i].Cells[2].Value = dtaRead["ProductColor"].ToString();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        conC.Close();
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "SizeCode")
                {
                    if (dataGridView1.Rows[i].Cells[3].Value == String.Empty)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductSize FROM ProductSizeDB WHERE SizeCode='" + dataGridView1.Rows[i].Cells[3].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dataGridView1.Rows[i].Cells[4].Value = dtaRead["ProductSize"].ToString();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        conC.Close();
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "QualityCode")
                {
                    if (dataGridView1.Rows[i].Cells[5].Value == String.Empty)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductQuality FROM ProductQualityDB WHERE QualityCode='" + dataGridView1.Rows[i].Cells[5].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dataGridView1.Rows[i].Cells[6].Value = dtaRead["ProductQuality"].ToString();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        conC.Close();
                    }
                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }
        }
    }
}
