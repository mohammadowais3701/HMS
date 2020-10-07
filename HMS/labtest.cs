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
    public partial class labtest : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True");
        SqlConnection con;
        public labtest()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            diagnosis dg = new diagnosis();
            this.Hide();
            dg.Show();
        }

        private void removetest_Click(object sender, EventArgs e)
        {
            REMOVETEST rem = new REMOVETEST();
            this.Hide();
            rem.Show();
        }

        private void addtest_Click(object sender, EventArgs e)
        {
            ADDTEST Add = new ADDTEST();
            this.Hide();
            Add.Show();
        }

        private void edittest_Click(object sender, EventArgs e)
        {
            EDITTEST ed = new EDITTEST();
            this.Hide();
            ed.Show();
        }

        private void labtest_Load(object sender, EventArgs e)
        {
            strcon.Open();
            string strcon1 = "Select * from tbl_lab order by test_name ASC";
            SqlDataAdapter sda = new SqlDataAdapter(strcon1, strcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            labtestgrid.DataSource = dt;
        }
    }
}
