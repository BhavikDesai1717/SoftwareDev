using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace SoftwareDev
{
    public partial class ColorAdd : Form
    {
        public string cCode,cColor;
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        public ColorAdd()
        {
            InitializeComponent();
        }

       

        private void ColorAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ProductColorDB' table. You can move, or remove it, as needed.
            this.productColorDBTableAdapter.Fill(this.client_DatabaseDataSet.ProductColorDB);

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
            dgColorSelect.DataSource = dt;
            conColor.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cCode = this.dgColorSelect.CurrentRow.Cells[1].Value.ToString();
            cColor = this.dgColorSelect.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void ColorAdd_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dgColorSelect_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.A)
            {
                ButtonClicked.addNewColorButton = (sender as Button).Text;
                addColor();
            }
        }
        private void addColor()
        {
            AddNewColor aNC = new AddNewColor();
            aNC.ShowDialog();
            refreshColorGrid();
        }
        private void btn_AddNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.A)
            {
                AddNewColor aNC = new AddNewColor();
                ButtonClicked.addNewColorButton = (sender as Button).Text;
                aNC.ShowDialog();
                refreshColorGrid();
            }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            ButtonClicked.addNewColorButton = (sender as Button).Text;
            addColor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ProductColorDB WHERE ProductColor like '" + textBox1.Text + "%'", conC);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgColorSelect.DataSource = dt;
                conC.Close();
            }
        }
    }
}
