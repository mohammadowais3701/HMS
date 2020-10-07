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
    public partial class editlabpatient : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public editlabpatient()
        {
            InitializeComponent();
        }

        private void editlabpatient_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            LABPATIENT lp = new LABPATIENT();
            this.Hide();
            lp.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (nametb.Text != "" && fathernametb.Text != "" && agetb.Text != "" && phonetb.Text != "")
            {

                String query = "UPDATE tbl_labPatients SET name='" + nametb.Text + "',father_name='" + fathernametb.Text + "',phone_number='" + phonetb.Text + "',age='" + agetb.Text + "' where pid='" + idtb.Text + "'";
                con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd1 = new SqlCommand(query, con);
                //  cmd1.ExecuteNonQuery();
                try
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("UPDATED!");
                    idtb.Text = "";
                    nametb.Text = "";
                    fathernametb.Text = "";
                    agetb.Text = "";

                    phonetb.Text = "";
                    String selectsql = "select * from tbl_labPatients";
                    con = new SqlConnection(strcon);
                    SqlCommand cmd = new SqlCommand(selectsql, con);
            
               }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is going wrong");

                }
            }
        }
    }
}