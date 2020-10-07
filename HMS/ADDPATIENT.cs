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
    public partial class ADDPATIENT : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public ADDPATIENT()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ADDPATIENT_Load(object sender, EventArgs e)

        {
        //    SqlCommand cmd = new SqlCommand(); ;
         String selectsql = "select * from tbl_patients";
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
                          str = (read["p_id"].ToString());
                      }
                      int i = Convert.ToInt32(str);
                      i++;
                      p_id.Text = i.ToString();
                  }
              }
              finally { }
       /*     try
            {
                String selectsql = "select * from tbl_patients;" + "Select Scope_Identity()";
                con = new SqlConnection(strcon);
             cmd= new SqlCommand(selectsql, con);
                con.Open();

                Int32 i = (Int32)cmd.ExecuteScalar();

                p_id.Text = i.ToString(); }
            catch(Exception ex)
            {
                p_id.Text = "1";
            }
            */






            supervisioncombo.Items.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select name FROM tbl_doctors ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach  (DataRow dr in dt.Rows )
            {
                supervisioncombo.Items.Add(dr["name"].ToString());
            }


            //  con.Close();


            cmd = new SqlCommand("Select * FROM tbl_department where NOT name='OPD'", con);
            deptcombo.Items.Clear();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select name FROM tbl_rooms where status!=" + "'Occupied'" + "AND type="+statuscombo.Text+"";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
           da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                deptcombo.Items.Add(dr["name"].ToString());
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Patients pat = new Patients();
            pat.Show();
            this.Hide();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
           
            con = new SqlConnection(strcon);
            con.Open();
            if ( nametb.Text != "" && fathernametb.Text != "" && refertb.Text != "" && diseasetb.Text != "" && NICtb.Text != "" || statuscombo.Text != ""||supervisioncombo.Text!=""||roomcombo.Text!="")
            {
                if (deptcombo.Text == "OPD")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From tbl_appointments where CNIC='" +NICtb.Text + "' AND Doctor_Name='"+supervisioncombo.Text+"' AND name='"+nametb.Text+"'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        SqlCommand cmd2 = new SqlCommand("SELECT Date FROM tbl_appointments WHERE CNIC='"+NICtb.Text+"'", con);

                        SqlDataReader usernameRdr = null;

                        usernameRdr = cmd2.ExecuteReader();
                        string Date="";
                        while (usernameRdr.Read())
                        {
                            Date= usernameRdr["Date"].ToString();
                        }
                        //   String[] str = Date.Split(',');
                     //   MessageBox.Show(Date);
                       // MessageBox.Show(dateTimePicker1.Text);
                        
                        if (dateTimePicker1.Text==Date){
                            SqlConnection con1;
                            string query = "Insert into tbl_appointmenthistory (name,Date,CNIC,Doctor_Name,doctor_id,status,fee,Phone#) values((select name from tbl_appointments where CNIC='" + NICtb.Text + "'),(select Date from tbl_appointments where CNIC='" + NICtb.Text + "'),(select CNIC from tbl_appointments where CNIC='" + NICtb.Text + "'),(select Doctor_Name from tbl_appointments where CNIC='" + NICtb.Text + "'),(select doctor_id from tbl_appointments where CNIC='" + NICtb.Text + "'),'" + "Completed" + "',(select fee from tbl_appointments where CNIC='" + NICtb.Text + "'),(select number from tbl_appointments where CNIC='" + NICtb.Text + "'))";
                            string query1 = "Delete from tbl_appointments where CNIC='" + NICtb.Text + "'";
                            con1 = new SqlConnection(strcon);
                            con1.Open();
                            SqlCommand cmd1 = new SqlCommand(query, con1);
                            cmd1.ExecuteNonQuery();
                            cmd1 = new SqlCommand(query1, con1);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Appointment Patient Inserted");
                        }
                        else{
                            MessageBox.Show("Your Appointment Date and Time is "+Date);
                        }

                    }
                    else
                    {
                        MessageBox.Show("YOU DID NOT TAKE AN APPOINTMENT");
                    }

                }
                else
                {

                    SqlDataAdapter sda = new SqlDataAdapter("usp_INSERTPATIENT", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    // sda.SelectCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(p_id.Text);
                    sda.SelectCommand.Parameters.Add("@name", SqlDbType.VarChar, (50)).Value = nametb.Text;
                    sda.SelectCommand.Parameters.Add("@father_name", SqlDbType.VarChar, (50)).Value = fathernametb.Text;
                    sda.SelectCommand.Parameters.Add("@reference", SqlDbType.VarChar, (50)).Value = refertb.Text;
                    sda.SelectCommand.Parameters.Add("@cnic", SqlDbType.VarChar, (15)).Value = NICtb.Text;
                    sda.SelectCommand.Parameters.Add("@disease", SqlDbType.VarChar, (50)).Value = diseasetb.Text;
                    sda.SelectCommand.Parameters.Add("@age", SqlDbType.Int).Value = Convert.ToInt32(agetb.Text);
                    sda.SelectCommand.Parameters.Add("@dept", SqlDbType.VarChar, (30)).Value = deptcombo.Text;
                    sda.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar, (50)).Value = statuscombo.Text;
                    sda.SelectCommand.Parameters.Add("@room", SqlDbType.VarChar, (50)).Value = roomcombo.Text;
                    sda.SelectCommand.Parameters.Add("@supervision", SqlDbType.VarChar, (50)).Value = supervisioncombo.Text;
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted");
                }
                nametb.Text = "";
                fathernametb.Text = "";
                NICtb.Text = "";
                diseasetb.Text = "";
                agetb.Text = "";
                statuscombo.Text = "";
                refertb.Text = "";
                roomcombo.Items.Clear();
                roomcombo.Text = "";
                supervisioncombo.Text = "";
                deptcombo.Text = "";
                String selectsql = "select * from tbl_patients";
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
                            str = (read["p_id"].ToString());
                        }
                        int i = Convert.ToInt32(str);
                        i++;
                        p_id.Text = i.ToString();
                    }
                }
                finally { }


            }
            else
            {
                MessageBox.Show("Some fields are empty!");
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void statuscombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con.Open();
        //    SqlCommand cmd=new SqlCommand();
            SqlCommand cmd = new SqlCommand("Select name FROM tbl_rooms where status!=" + "'Occupied'" + "AND type='" + statuscombo.Text + "'", con);
            roomcombo.Items.Clear();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "Select name FROM tbl_rooms where status!=" + "'Occupied'" + "AND type="+statuscombo.Text+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    roomcombo.Items.Add(dr["name"].ToString());
                }
            
        }

        private void supervisioncombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deptcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(deptcombo.Text=="EMERGENCY"|| deptcombo.Text == "OPD")
            {
                roomcombo.Items.Clear();
                roomcombo.Text = "";
                statuscombo.Text = "";
            }

        }
    }
}
