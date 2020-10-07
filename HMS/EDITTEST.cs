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
    public partial class EDITTEST : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public EDITTEST()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

            labtest lbtest = new labtest();
            this.Hide();
            lbtest.Show();
        }

        private void EDITTEST_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idtb.Text != "" && nametb.Text != "" && pricetb.Text != "")
            {
                String query = "UPDATE  tbl_lab set test_name='" + nametb.Text + "',price='" + pricetb.Text + "' where tid='" + idtb.Text + "' ";
                con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd1 = new SqlCommand(query, con);
                //  cmd1.ExecuteNonQuery();
                try
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Record Update");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is going wrong");

                }
            }
            else
            {
                MessageBox.Show("Some fields are empty"); 
            }
           
        }
    }
}
