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
    public partial class EDITPATIENT : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public EDITPATIENT()
        {
            InitializeComponent();
        }

        private void EDITPATIENT_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            supervisioncombo.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select name FROM tbl_doctors", con);
            cmd.CommandType = CommandType.Text;
         //   cmd.CommandText = "Select name FROM tbl_doctors";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                supervisioncombo.Items.Add(dr["name"].ToString());
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
            String str1 = "0";
            String selectsql = "select * from tbl_patients";
            con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(selectsql, con);
            try
            {
                con.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        if (read["p_id"].ToString() ==idtb.Text)

                        {
                            
                                str1 = read["p_id"].ToString();
                               
                                break;
                            
                        }
                    }

                }
            }
            finally { }


            if (str1 != "0")
            {
              



                SqlDataAdapter sda = new SqlDataAdapter("usp_EDITPATIENT", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                 sda.SelectCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(idtb.Text);
                sda.SelectCommand.Parameters.Add("@name", SqlDbType.VarChar, (50)).Value = nametb.Text;
                sda.SelectCommand.Parameters.Add("@father_name", SqlDbType.VarChar, (50)).Value = fathernametb.Text;
                sda.SelectCommand.Parameters.Add("@reference", SqlDbType.VarChar, (50)).Value = refertb.Text;
                sda.SelectCommand.Parameters.Add("@CNIC", SqlDbType.VarChar, (15)).Value = NICtb.Text;
                sda.SelectCommand.Parameters.Add("@disease", SqlDbType.VarChar, (50)).Value = diseasetb.Text;
                sda.SelectCommand.Parameters.Add("@age", SqlDbType.Int).Value = Convert.ToInt32(agetb.Text);
          
                sda.SelectCommand.Parameters.Add("@supervision", SqlDbType.VarChar, (50)).Value = supervisioncombo.Text;
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Record Update");
                idtb.Text = "";
                nametb.Text = "";
                fathernametb.Text = "";
                NICtb.Text = "";
                refertb.Text = "";
                diseasetb.Text = "";
                agetb.Text = "";
                supervisioncombo.Text = "";

            }
            else
            {
                MessageBox.Show("Your ID is not matched in our Records");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void supervisioncombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateofadmission_TextChanged(object sender, EventArgs e)
        {

        }

        private void diseasetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void refertb_TextChanged(object sender, EventArgs e)
        {

        }

        private void NICtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void agetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void fathernametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkidbtn_Click(object sender, EventArgs e)
        {
            String str1 = "0", str2 = "";
            String selectsql = "select * from tbl_patients";
            con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(selectsql, con);
            try
            {
               con.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        if (read["p_id"].ToString() == idtb.Text)

                        {
                            str1 = "1";
                            nametb.Text = read["name"].ToString();
                            fathernametb.Text = read["father_name"].ToString();
                            refertb.Text = read["reference"].ToString();
                            diseasetb.Text = read["disease"].ToString();
                            NICtb.Text = read["CNIC"].ToString();
                            agetb.Text = read["age"].ToString();
                            supervisioncombo.Text = read["supervision"].ToString();
                        }
                     
                       
                    }
                    if(str1=="0"){
                        MessageBox.Show("Record Does not exist");
                        nametb.Text = "";
                        fathernametb.Text = "";
                        refertb.Text = "";
                        diseasetb.Text = "";
                        NICtb.Text = "";
                        agetb.Text = "";
                        supervisioncombo.Text = "";
                    }

                }
            }
            finally { }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
