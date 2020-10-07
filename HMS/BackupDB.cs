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
    public partial class BackupDB : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public BackupDB()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backupbtn_Click(object sender, EventArgs e)
        {


            DateTime d = DateTime.Now;
            string dd =d.Day + "-" + d.Month ;


            // string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HMS;Integrated Security=True";

            SqlConnection con =new SqlConnection(strcon);
            con.Open();
            string str = "USE HMS";
            string str1= "BACKUP DATABASE " + "HMS" + " TO DISK = 'C:\\Users\\Owais\\public\\" + " HMS " +"_"+ dd +
                ".Bak';";
            try
            {
               
                SqlCommand cmd1 = new SqlCommand(str, con);
                SqlCommand cmd2 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex+"");
            }
            MessageBox.Show("Successfully Completed Backup . You can find your backup file (DB Name.Bak) in your Disk C:\\Users\\Owais\\public\\ never edit this file");
            con.Close();


        }
       
        private void locationbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "SQL SERVER database backup files|* .bak";
            fd.Title = "DataBase restore";
                 

            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fd.FileName;
                restorebtn.Enabled = true;
            }
        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HMS;Integrated Security=True";

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
           try
            {
                string str1 = string.Format("ALTER DATABASE ["+"HMS"+"] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();
                string str2 = string.Format("USE MASTER RESTORE DATABASE ["+"HMS"+"] FROM DISK ='"+textBox1.Text+"' WITH REPLACE");
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.ExecuteNonQuery();
                string str3 = string.Format("ALTER DATABASE ["+"HMS"+"] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Database Recovered Successful .if you want to get returned ,close this software and run again");
                con.Close();

           }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recepitionist rec = new Recepitionist();
            this.Hide();
            rec.Show();
        }
    }
}
