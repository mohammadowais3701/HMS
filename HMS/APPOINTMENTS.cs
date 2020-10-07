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
    public partial class APPOINTMENTS : Form

    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public APPOINTMENTS()
        {
            InitializeComponent();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            REMOVEAPPOINTMENT remapp = new REMOVEAPPOINTMENT();
            this.Hide();
            remapp.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ADDAPOINTMENTS addapp = new ADDAPOINTMENTS();
            this.Hide();
            addapp.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Recepitionist res = new Recepitionist();
            this.Hide();
            res.Show();
        }

        private void APPOINTMENTS_Load(object sender, EventArgs e)
        {
            string dat= DateTime.Now.ToString("yyyy-MM-dd");
            string[] word = dat.ToString().Split('-');
            string query;
          //  MessageBox.Show(word[0]);
           // MessageBox.Show(word[1]);
            //MessageBox.Show(word[2]);
            String selectsql = "select * from tbl_appointments";
            con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(selectsql, con);
            try
            {
                con.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    Int32 day, month=1, year,flag=0;
                    String str = "0",str1="0";
                    while (read.Read())
                    {
                        str = (read["Date"].ToString());
                        str1= (read["id"].ToString());
                        Int32 i = Convert.ToInt32(str1);
                        string[] appdate1 = str.ToString().Split(',');
                        string[] appdate2 = appdate1[1].ToString().Split(' ');

                       day = Convert.ToInt32(appdate2[1]);
                         year = Convert.ToInt32(appdate2[3]);

                         if (appdate2[2] == "Jan")
                         {
                             month = 1;
                         }
                      else  if (appdate2[2] == "Feb")
                         {
                             month = 2;
                         }
                         else if (appdate2[2] == "Mar")
                         {
                             month = 3;
                         }
                         else if (appdate2[2] == "April")
                         {
                             month = 4;
                         }
                         else if (appdate2[2]== "May")
                         {
                             month = 5;
                         }
                         else if (appdate2[2] == "June")
                         {
                             month =6 ;
                         }
                         else if (appdate2[2] == "July")
                         {
                             month = 7;
                         }
                         else if (appdate2[2] == "Aug")
                         {
                             month = 8;
                         }
                         else if (appdate2[2] == "Sep")
                         {
                             month =9 ;
                         }
                         else if (appdate2[2] == "Oct")
                         {
                             month = 10;
                         }
                         else if (appdate2[2] == "Nov")
                         {
                             month = 11;
                         }
                         else if (appdate2[2] == "Dec")
                         {
                             month =12 ;
                         }

                        // MessageBox.Show(""+day);
                        //MessageBox.Show("" + month);
                        //MessageBox.Show("" + year);
                        // MessageBox.Show(appdate2[1]);
                        // MessageBox.Show(appdate2[2]);
                        //MessageBox.Show(appdate2[3]);
                       
                        if (Convert.ToInt32(word[0]) > year) {
                            flag = 1;

                        }
                        else if (Convert.ToInt32(word[1]) > month)
                        {
                            flag = 1;
                        }
                        else if (Convert.ToInt32(word[2]) > day)
                        {
                            flag = 1;

                        }
                       
                        if (flag == 1)
                        {
                          
                            SqlConnection con1;
                            query = "Insert into tbl_appointmenthistory (name,Date,CNIC,Doctor_Name,doctor_id,status,fee,Phone#) values((select name from tbl_appointments where id='" + i + "'),(select Date from tbl_appointments where id='" + i + "'),(select CNIC from tbl_appointments where id='" + i + "'),(select Doctor_Name from tbl_appointments where id='" + i + "'),(select doctor_id from tbl_appointments where id='" + i + "'),'" + "Not Completed" + "','0',(select number from tbl_appointments where id='" + i + "'))";
                            string que1    ="Delete from tbl_appointments where id=" + i+"";
                            con1 = new SqlConnection(strcon);
                            con1.Open();
                          SqlCommand  cmd1 = new SqlCommand(query,con1);
                            cmd1.ExecuteNonQuery();
                          cmd1 = new SqlCommand(que1, con1);
                            cmd1.ExecuteNonQuery();

                        }

                    }
                   
                }
            }
            finally { }
           




        }

        private void view_Click(object sender, EventArgs e)
        {
            VIEWAPPOINTMENTS va = new VIEWAPPOINTMENTS();
            this.Hide();
            va.Show();
        }

        private void apphistory_Click(object sender, EventArgs e)
        {
            APPOINTMENTHISTORY apphis = new APPOINTMENTHISTORY();
            this.Hide();
            apphis.Show();

        }
    }
}
