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
    public partial class REMOVEAPPOINTMENT : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public REMOVEAPPOINTMENT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //;
            string query = "Insert into tbl_appointmenthistory (name,Date,CNIC,Doctor_Name,doctor_id,status,fee,Phone#) values((select name from tbl_appointments where CNIC='" + textBox4.Text + "'),(select Date from tbl_appointments where CNIC='" + textBox4.Text + "'),(select CNIC from tbl_appointments where CNIC='" + textBox4.Text + "'),(select Doctor_Name from tbl_appointments where CNIC='" + textBox4.Text + "'),(select doctor_id from tbl_appointments where CNIC='" + textBox4.Text + "'),'" + "Not Completed" + "','0',(select number from tbl_appointments where CNIC='" + textBox4.Text + "'))";
            string query1= "Delete from tbl_appointments where CNIC='" + textBox4.Text+"'";
            con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd1 = new SqlCommand(query, con);
            cmd1.ExecuteNonQuery();
            cmd1 = new SqlCommand(query1, con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Appointment Cancelled");

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            APPOINTMENTS app = new APPOINTMENTS();
            this.Hide();
            app.Show();
        }
    }
}
