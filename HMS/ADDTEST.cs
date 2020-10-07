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
    public partial class ADDTEST : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public ADDTEST()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            labtest lbtest = new labtest();
            this.Hide();
            lbtest.Show();
        }

        private void ADDTEST_Load(object sender, EventArgs e)
        {
            String selectsql = "select * from tbl_lab";
            con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(selectsql, con);
            try
            {
                con.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    String str = "0";
                    while (read.Read())
                    {
                        str = (read["tid"].ToString());
                    }
                    int i = Convert.ToInt32(str);
                    i++;
                    idtb.Text = i.ToString();
                }
            }
            finally { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idtb.Text != "" && nametb.Text != "" && pricetb.Text != "")
            {
                String query = "INSERT INTO tbl_lab (test_name,price) values('"+nametb.Text+"','"+pricetb.Text+"')";
                con= new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd1 = new SqlCommand(query, con);
              //  cmd1.ExecuteNonQuery();
                try
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Inserted");
                    nametb.Text = "";
                    pricetb.Text = "";
                    String selectsql = "select * from tbl_lab";
                    con = new SqlConnection(strcon);
                    SqlCommand cmd = new SqlCommand(selectsql, con);
                    try
                    {
                        con.Open();
                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            String str = "0";
                            while (read.Read())
                            {
                                str = (read["tid"].ToString());
                            }
                            int i = Convert.ToInt32(str);
                            i++;
                            idtb.Text = i.ToString();
                        }
                    }
                    finally { }
                }
                catch(Exception ex) {
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
