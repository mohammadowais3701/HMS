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
    public partial class Statsform : Form
    {
        string strcon = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMS; Integrated Security = True";
        SqlConnection con;
        public Statsform()
        {
            InitializeComponent();
        }

        private void Statsform_Load(object sender, EventArgs e)
        {
            fillchart();
        }

      private void fillchart()
        {
            DataSet ds = new DataSet();
            con = new SqlConnection(strcon);
            con.Open();
         //   SqlCommand cmd = new SqlCommand("Select department,discharge_date,count (p_id) as p_id from tbl_patientshistory", con);
            SqlDataAdapter adapt = new SqlDataAdapter("usp_discharge", con);
            adapt.Fill(ds);
            dischargepatients.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            dischargepatients.Series["Date"].XValueMember = "discharge_date";

            //set the member columns of the chart data source used to data bind to the X-values of the series  
            dischargepatients.Series["Date"].YValueMembers = "num";
         
            dischargepatients.Titles.Add("DISCHARGE PATIENTS Chart");
            con.Close();

        }

        private void dischargepatients_Click(object sender, EventArgs e)
        {

        }
    }
}
