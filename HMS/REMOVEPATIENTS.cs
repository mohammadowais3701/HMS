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
    public partial class REMOVEPATIENTS : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public REMOVEPATIENTS()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Patients pat = new Patients();
            pat.Show();
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(id.Text!="" && cnic.Text != "")

            {
                con = new SqlConnection(strcon);
                con.Open();
                String selectsql = " Delete from tbl_patients where p_id="+id.Text+" AND CNIC="+cnic.Text+" ";
                SqlCommand cmd = new SqlCommand(selectsql, con);
              
                SqlDataAdapter sda = new SqlDataAdapter("usp_DELETEPATIENT", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(id.Text);
                sda.SelectCommand.Parameters.Add("@CNIC", SqlDbType.VarChar, (15)).Value = cnic.Text;
                try
                {
                    sda.SelectCommand.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted");
                    DischargeForm DF = new DischargeForm();
                    this.Hide();
                    DF.Show();
                }
                catch (Exception ex) { MessageBox.Show("Record is not present"); }
             
                id.Text = "";
                cnic.Text = "";


            }
            else
            {
                MessageBox.Show("ID or NIC fields are empty");
            }
        }
    }
}
