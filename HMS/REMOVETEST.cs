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
    public partial class REMOVETEST : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public REMOVETEST()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            labtest lbtest = new labtest();
            this.Hide();
            lbtest.Show();
        }

        private void REMOVETEST_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            
            string st = "SELECT test_name FROM tbl_lab";
               SqlCommand cmd = new SqlCommand(st, con);
            comboBox1.Items.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["test_name"].ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                string query1 = "Delete from tbl_lab where test_name='" + comboBox1.Text + "'";
                con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Test Removed");
            }

            else
            {
                MessageBox.Show("Select Test Name..!!");
            }
        }
    }
}
