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
    public partial class LabReports : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public LabReports()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            LABPATIENT lp = new LABPATIENT();
            this.Hide();
            lp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(idtxt.Text!="" && valuestxt.Text != "")
            {
                string str = "New";
                string query1 = "Update tbl_labPatients SET testvalues='" + valuestxt.Text + "',status='Old'  where pid='" + idtxt.Text + "' and status='"+ str +"'";
                con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd1 = new SqlCommand(query1, con);
                try
                {
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Report Ready!!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Something is going wrong!!");
                }
            }
            else
            {
                MessageBox.Show("Some fields are empty!!!");
            }
        }
    }
}
