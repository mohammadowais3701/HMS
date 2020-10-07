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
    public partial class addlabpatient : Form

    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public addlabpatient()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            LABPATIENT lp = new LABPATIENT();
            this.Hide();
            lp.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if(nametb.Text!=""&& fathernametb.Text != "" && agetb.Text != "" && phonetb.Text!="") {

                String query = "INSERT INTO tbl_labPatients (name,father_name,phone_number,test_id,age,status,date) values('" + nametb.Text + "','" + fathernametb.Text + "','" + phonetb.Text + "',(Select tid from tbl_lab where test_name='"+comboBox1.Text+"'),'" + agetb.Text + "','New','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd1 = new SqlCommand(query, con);
                //  cmd1.ExecuteNonQuery();
                try
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Inserted");
                    nametb.Text = "";
                    fathernametb.Text = "";
                    agetb.Text = "";
                   
                    phonetb.Text = "";
                    String selectsql = "select * from tbl_labPatients";
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
                                str = (read["pid"].ToString());
                            }
                            int i = Convert.ToInt32(str);
                            i++;
                            idtb.Text = i.ToString();
                        }
                    }
                    finally { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is going wrong");

                }


            }
        }

        private void addlabpatient_Load(object sender, EventArgs e)
        {
            String selectsql = "select * from tbl_labPatients";
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
                        str = (read["pid"].ToString());
                    }
                    int i = Convert.ToInt32(str);
                    i++;
                    idtb.Text = i.ToString();
                }
            }
            finally { }

         

            string st = "SELECT test_name FROM tbl_lab";
           cmd = new SqlCommand(st, con);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void reptgent_Click(object sender, EventArgs e)
        {
            labpatientAdmissionSlip slip = new labpatientAdmissionSlip();
            this.Hide();
            slip.Show();
        }
    }
}
