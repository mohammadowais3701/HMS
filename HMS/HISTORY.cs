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
using Microsoft.VisualBasic;

namespace HMS
{
    public partial class HISTORY : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True");
        SqlConnection con;
        public HISTORY()
        {
            InitializeComponent();
        }

        private void HISTORY_Load(object sender, EventArgs e)
        {
            strcon.Open();
            string strcon1 = "Select * from tbl_patientshistory";
            SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (nametb.Text == "")
            {

                string strcon1 = "Select * from tbl_patientshistory";
                SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else
            {
                string strcon1 = "Select * from tbl_patientshistory where name='" + nametb.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Recepitionist res = new Recepitionist();
            this.Hide();
            res.Show();
        }

        private void historydelete_Click(object sender, EventArgs e)
        {
            string str=Interaction.InputBox("Enter ID Id", " Delete History", "All", -1, -1);
          
            if (str == "All")
            {
                string query = "Delete from tbl_patientshistory";
                SqlCommand cmd = new SqlCommand(query, strcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
            }
            else if(str=="")
                MessageBox.Show("No Record Select");
            else
            {
                try
                {
                    string query = "Delete from tbl_patientshistory where p_id=" + Convert.ToInt32(str) + "";
                    SqlCommand cmd = new SqlCommand(query, strcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Selected Record Deleted");

                }
                catch(Exception ex)
                {
                    MessageBox.Show("You select invalid Record");
                }
            }
            string strcon1 = "Select * from tbl_patientshistory";
                SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

        }
    }
}
