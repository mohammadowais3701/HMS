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
    public partial class ViewReports : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True");

        public ViewReports()
        {
            InitializeComponent();
        }

        private void ViewReports_Load(object sender, EventArgs e)
        {
            strcon.Open();
            string strcon1 = "Select pid,name,father_name,phone_number,(Select test_name from tbl_lab where tid=test_id) as TestName,age,date, testvalues from tbl_labPatients where status='Old'";
            SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            diagnosis dg = new diagnosis();
            this.Hide();
            dg.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string str = "Old";
            string strcon1 = "Select pid,name,father_name,phone_number,(Select test_name from tbl_lab where tid=test_id) as TestName,age,date,testvalues  from tbl_labPatients where pid='" + idtxtbox.Text + "' and status='" + str + "'";
            SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            if (idtxtbox.Text == "")
            {
                strcon1 = "Select pid,name,father_name,phone_number,(Select test_name from tbl_lab where tid=test_id) as TestName,age,date,testvalues  from tbl_labPatients where status='" + str + "' ";
                sda = new SqlDataAdapter(strcon1, strcon);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateFinalReport finalReport = new GenerateFinalReport();
            this.Hide();
            finalReport.Show();
        }
    }
}
