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
    public partial class REMOVELABPATIENTS : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public REMOVELABPATIENTS()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            LABPATIENT LP = new LABPATIENT();
            this.Hide();
            LP.Show();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (idtb.Text != "" && nametb.Text != "")
            {
                string query1 = "Delete from tbl_labPatients where pid='" + idtb.Text + "' and name='" + nametb.Text + "'";
                con = new SqlConnection(strcon);
                con.Open();
                try
                {
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Patient Record Removed...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is going wrong!!");
                }
            }
            else
            {
                MessageBox.Show("Somefields are empty!!");
            }

        }
    }
}
