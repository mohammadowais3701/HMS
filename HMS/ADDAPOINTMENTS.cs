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
    public partial class ADDAPOINTMENTS : Form

    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public ADDAPOINTMENTS()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ADDAPOINTMENTS_Load(object sender, EventArgs e)
        {
            String selectsql = "select * from tbl_appointments";
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
                        str = (read["id"].ToString());
                    }
                    int i = Convert.ToInt32(str);
                    i++;
                   idtb.Text = i.ToString();
                }
            }
            finally { }

            doctorcombo.Items.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select name FROM tbl_doctors where d_id in(Select doctor_id from  tbl_deptdoctors where dept_id in(Select dept_id from tbl_department where name='OPD')) ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                doctorcombo.Items.Add(dr["name"].ToString());
            }
            //
            cmd.Connection.Close();
            //
         /*   dayscombo.Items.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Days from";
            cmd.ExecuteNonQuery();
             dt = new DataTable();
             da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                doctorcombo.Items.Add(dr["name"].ToString());
            }*/


        }

        private void doctorcheck_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_appointments where Doctor_Name='" + doctorcombo.Text + "' AND Date='"+dateTimePicker1.Text+"'", con);
            con.Open();
            Int32 count = (Int32)cmd.ExecuteScalar();
            if (count >=20)
            {
                MessageBox.Show("No Appointments Available");
                doctorcombo.Text = "";
            }
            else
            {
                MessageBox.Show(20-count+" Appointments Available");
               
            }
            con.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            APPOINTMENTS ap = new APPOINTMENTS();
            this.Hide();
            ap.Show();
        }

        private void doctorcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayscombo.Items.Clear();
            string st = "SELECT Days FROM tbl_doctors where name='" + doctorcombo.Text + "'";
          SqlCommand  cmd = new SqlCommand(st, con);
           cmd.Connection.Open();
            SqlDataReader sqlread = cmd.ExecuteReader();
          //  cmd.Connection.Close();
            while (sqlread.Read())
            {
                string[] word = sqlread["Days"].ToString().Split(',');
                for (int count = 0; count < word.Length; count++)
                {
                   dayscombo.Items.Add(word[count]);

                }
            }
            cmd.Connection.Close();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            if (doctorcombo.Text != "" &&dayscombo.Text!=""&& nametb.Text!=""&&phonetb.Text!=""&&nictb.Text!=""&&drfee.Text!="") {
                string[] word =dateTimePicker1.Text.ToString().Split(',');
                //MessageBox.Show(word[0]);
                //MessageBox.Show(dayscombo.Text);
                if (word[0] == dayscombo.Text)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("usp_INSERTAPPOINTMENT", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(idtb.Text);
                    sda.SelectCommand.Parameters.Add("@pname", SqlDbType.VarChar, (50)).Value = nametb.Text;
                    sda.SelectCommand.Parameters.Add("@date", SqlDbType.VarChar, (50)).Value = dateTimePicker1.Text;
                    sda.SelectCommand.Parameters.Add("@number", SqlDbType.VarChar, (50)).Value = phonetb.Text;
                    sda.SelectCommand.Parameters.Add("@dname", SqlDbType.VarChar, (15)).Value = doctorcombo.Text;
                    sda.SelectCommand.Parameters.Add("@CNIC", SqlDbType.VarChar, (50)).Value = nictb.Text;
                    sda.SelectCommand.Parameters.Add("@drfee", SqlDbType.VarChar, (10)).Value = drfee.Text;






                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_appointments where Doctor_Name='" + doctorcombo.Text + "' AND Date='" + dateTimePicker1.Text + "'", con);
                    //con.Open();
                    Int32 count = (Int32)cmd.ExecuteScalar();
                    if (count >= 20)
                    {
                        MessageBox.Show("No Appointments Available");
                        doctorcombo.Text = "";
                    }
                    else
                    {
                        sda.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("Appointment Inserted");
                        nametb.Text = "";

                        nictb.Text = "";
                        phonetb.Text = "";
                        doctorcombo.Text = "";
                        dayscombo.Text = "";

                    }
                    con.Close();


                   
                    String selectsql = "select * from tbl_appointments";
                    con = new SqlConnection(strcon);
                    SqlCommand cmd1 = new SqlCommand(selectsql, con);
                    try
                    {
                        con.Open();
                        using (SqlDataReader read = cmd1.ExecuteReader())
                        {
                            String str = "0";
                            while (read.Read())
                            {
                                str = (read["id"].ToString());
                            }
                            int i = Convert.ToInt32(str);
                            i++;
                            idtb.Text = i.ToString();
                        }
                    }
                    finally { }
                }
                else
                {
                    MessageBox.Show("Your day does not match with your selected date");
                }







            }
            else
            {
                MessageBox.Show("Some fields are empty");
            }
            con.Close();
        }
    }
}
