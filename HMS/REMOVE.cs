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
    public partial class REMOVE : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public REMOVE()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String str1 = "0", str2 = "";
            String selectsql = "select * from tbl_doctors";
            con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(selectsql, con);
            try
            {
                con.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        if (read["d_id"].ToString() == id.Text)

                        {
                            if (read["CNIC"].ToString() == cnic.Text)
                            {
                                str1 = read["d_id"].ToString();
                                str2 = read["CNIC"].ToString();
                                break;
                            }
                        }
                    }

                }
            }
            finally { }

            if (str1 != "0" && str2 != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("usp_delete", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(id.Text);
                sda.SelectCommand.Parameters.AddWithValue("@cnic", SqlDbType.VarChar).Value = cnic.Text;
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
            }
            else
            {
                MessageBox.Show("Your ID or CNIC is not matched with our records ");
            }


        }

        private void back_Click(object sender, EventArgs e)
        {
            Doctors dr = new Doctors();
            this.Hide();
            dr.Show();
        }

        private void cnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
