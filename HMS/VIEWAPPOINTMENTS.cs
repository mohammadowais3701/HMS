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
    public partial class VIEWAPPOINTMENTS : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public VIEWAPPOINTMENTS()
        {
            InitializeComponent();
        }

        private void VIEWAPPOINTMENTS_Load(object sender, EventArgs e)
        {
         
            con = new SqlConnection(strcon);
          con.Open();

            string strcon1 = "Select * from tbl_appointments";
            SqlDataAdapter sda = new SqlDataAdapter(strcon1, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            String str = "Select name FROM tbl_doctors where d_id in(Select doctor_id from  tbl_deptdoctors where dept_id in(Select dept_id from tbl_department where name='OPD')) ";
            doctorcombo.Items.Clear();
         
            SqlCommand cmd =new SqlCommand (str,con);
        
            cmd.ExecuteNonQuery();
           dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                doctorcombo.Items.Add(dr["name"].ToString());
            }
            //
            cmd.Connection.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            APPOINTMENTS app = new APPOINTMENTS();
            this.Hide();
            app.Show();
        }

        private void doctorcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string strcon1 = "Select * from tbl_appointments where Doctor_Name='" + doctorcombo.Text + "'";
            con = new SqlConnection(strcon);
            SqlDataAdapter sda = new SqlDataAdapter(strcon1, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
