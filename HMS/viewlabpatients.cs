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
    public partial class viewlabpatients : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True");
        public viewlabpatients()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            LABPATIENT lp = new LABPATIENT();
            this.Hide();
            lp.Show();
        }

        private void viewlabpatients_Load(object sender, EventArgs e)
        {
            strcon.Open();
            string strcon1 = "Select pid,name,father_name,phone_number,(Select test_name from tbl_lab where tid=test_id) as TestName,age,date from tbl_labPatients where status='New'";
            SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void search_Click(object sender, EventArgs e)
        {
            string str = "New";
            string strcon1 = "Select pid,name,father_name,phone_number,(Select test_name from tbl_lab where tid=test_id) as TestName,age,date from tbl_labPatients where pid='" + idtb.Text + "' and status='"+str+"'";
            SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            if (idtb.Text == "")
            {
                strcon1 = "Select pid,name,father_name,phone_number,(Select test_name from tbl_lab where tid=test_id) as TestName,age,date from tbl_labPatients where status='"+str+"' ";
                sda = new SqlDataAdapter(strcon1, strcon);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        }
    }

