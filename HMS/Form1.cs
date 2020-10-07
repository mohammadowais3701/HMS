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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
           
            SqlDataAdapter sda=new SqlDataAdapter("Select Count(*) From tbl_Admin where id='"+username.Text+"'and department='"+comboBox1.Text+"'and password='"+password.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {

                this.Hide();
                if (comboBox1.Text == "Recepitionist")
                {
                    Recepitionist rec = new Recepitionist();

                    rec.Show();
                }
                else if (comboBox1.Text == "Laboratory")
                {
                    LAB lab = new LAB();
                    lab.Show();
                }

            }
            else
            {
                MessageBox.Show("Check ID or PASSWORD!");
            }


           /* if (username.Text == "1")
            {
                Recepitionist rec = new Recepitionist();
                
                rec.Show();
            }
           else if (username.Text == "2")
            {
                LAB lab = new LAB();
                lab.Show();
            }*/

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
