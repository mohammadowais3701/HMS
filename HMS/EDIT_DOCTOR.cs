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
    public partial class EDIT_DOCTOR : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public EDIT_DOCTOR()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Doctors dr = new Doctors();
            this.Hide();
            dr.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String str1 = "0",str2="";
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


            if (str1!="0"&& str2!="")
            {
                string str = "";
                if (mon.Checked)
                    str += "Monday,";
                if (tue.Checked)
                    str += "Tuesday,";
                if (wed.Checked)
                    str += "Wednesday,";
                if (thursday.Checked)
                    str += "Thursday,";
                if (friday.Checked)
                    str += "Friday";



                SqlDataAdapter sda = new SqlDataAdapter("usp_edit", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(id.Text);
                sda.SelectCommand.Parameters.Add("@name", SqlDbType.VarChar, (50)).Value = name.Text;
                sda.SelectCommand.Parameters.Add("@father_name", SqlDbType.VarChar, (50)).Value = fathername.Text;
                sda.SelectCommand.Parameters.AddWithValue("@cnic", SqlDbType.VarChar).Value = cnic.Text;
                sda.SelectCommand.Parameters.Add("@speciality", SqlDbType.VarChar, (50)).Value = specaility.Text;
                sda.SelectCommand.Parameters.Add("@timings", SqlDbType.VarChar, (50)).Value = timings.Text;
                sda.SelectCommand.Parameters.Add("@days", SqlDbType.VarChar, (50)).Value = str;
                sda.SelectCommand.Parameters.Add("@dept", SqlDbType.VarChar, (50)).Value = comboBox1.Text;
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Record Update");
                id.Text = "";
                name.Text = "";
                fathername.Text = "";
                cnic.Text = "";
                specaility.Text = "";
                timings.Text = "";
                mon.Checked = false;
                tue.Checked = false;
                wed.Checked = false;
                thursday.Checked = false;
                friday.Checked = false;
                comboBox1.Text = "";
                
            }
            else
            {
                MessageBox.Show("Your ID is not matched in our Records");
            }

        }
    }
}
