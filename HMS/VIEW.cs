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

namespace HMS
{
    public partial class VIEW : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True");
  
        public VIEW()
        {
            InitializeComponent();
        }

        private void VIEW_Load(object sender, EventArgs e)
        {
            strcon.Open();
            string strcon1 = "Select * from view_doctors";
            SqlDataAdapter sda = new SqlDataAdapter(strcon1,strcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void search_Click(object sender, EventArgs e)
        {

           
            string strcon1 = "Select * from view_doctors where speciality='"+comboBox1.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Doctors dr = new Doctors();
            this.Hide();
            dr.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
