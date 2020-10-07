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
    public partial class VIEWPATIENT : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True");
        public VIEWPATIENT()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Patients pat = new Patients();
            pat.Show();
            this.Hide();
        }

        private void VIEWPATIENT_Load(object sender, EventArgs e)
        {
            strcon.Open();
            string strcon1 = "Select * from view_patients";
            SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametb.Text == "")
            {
                string strcon1 = "Select * from view_patients";
                SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else{
                string strcon1 = "Select * from view_patients where name='" + nametb.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt; }
        }
    }
}
