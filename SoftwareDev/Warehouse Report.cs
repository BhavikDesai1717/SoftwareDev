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
using Microsoft.Reporting.WinForms;

namespace SoftwareDev
{
    public partial class Warehouse_Report : Form
    {
        static string conWarehouse = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.WarehouseConnectionString"].ConnectionString;
        public Warehouse_Report()
        {
            InitializeComponent();
        }

        private void Warehouse_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'WarehouseDataSet.Warehouse' table. You can move, or remove it, as needed.
            this.WarehouseTableAdapter.Fill(this.WarehouseDataSet.Warehouse);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_WarehouseReport.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void txt_Color_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conW = new SqlConnection(conWarehouse))
            {
                conW.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Warehouse WHERE Color like '" + txt_Color.Text + "' OR Size like '"+txt_Size.Text+ "' OR Quality like '" + txt_quality.Text + "'", conW);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dg_WarehouseReport.DataSource = dt;
                conW.Close();
            }
        }

        private void txt_Size_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conW = new SqlConnection(conWarehouse))
            {
                conW.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Warehouse WHERE Color like '" + txt_Color.Text + "' OR Size like '" + txt_Size.Text + "' OR Quality like '" + txt_quality.Text + "'", conW);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dg_WarehouseReport.DataSource = dt;
                conW.Close();
            }
        }

        private void txt_quality_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conW = new SqlConnection(conWarehouse))
            {
                conW.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Warehouse WHERE Color like '" + txt_Color.Text + "' OR Size like '" + txt_Size.Text + "' OR Quality like '" + txt_quality.Text + "'", conW);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dg_WarehouseReport.DataSource = dt;
                conW.Close();
            }
        }

        private void dg_WarehouseReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dg_WarehouseReport.Rows.Count; i++)
            {
                if (dg_WarehouseReport.Columns[e.ColumnIndex].Name == "Rate")
                {
                    dg_WarehouseReport.Rows[i].Cells[8].Value = String.Format("{0:#,##0.00}", double.Parse(dg_WarehouseReport.Rows[i].Cells[8].Value.ToString()));
                }
                if (dg_WarehouseReport.Columns[e.ColumnIndex].Name == "Inward_Quantity")
                {
                    dg_WarehouseReport.Rows[i].Cells[5].Value = String.Format("{0:#,##0.00}", double.Parse(dg_WarehouseReport.Rows[i].Cells[5].Value.ToString()));
                }
                if (dg_WarehouseReport.Columns[e.ColumnIndex].Name == "Outward_Quantity")
                {
                    dg_WarehouseReport.Rows[i].Cells[6].Value = String.Format("{0:#,##0.00}", double.Parse(dg_WarehouseReport.Rows[i].Cells[6].Value.ToString()));
                }
                if (dg_WarehouseReport.Columns[e.ColumnIndex].Name == "Balance_Quantity")
                {
                    dg_WarehouseReport.Rows[i].Cells[7].Value = String.Format("{0:#,##0.00}", double.Parse(dg_WarehouseReport.Rows[i].Cells[7].Value.ToString()));
                }
            }
        }
    }
}
