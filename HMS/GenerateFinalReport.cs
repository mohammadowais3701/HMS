using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class GenerateFinalReport : Form
    {
        public GenerateFinalReport()
        {
            InitializeComponent();
        }

        private void GenerateFinalReport_Load(object sender, EventArgs e)
        {
           
        }

        private void Generatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 ID = Convert.ToInt32(IDtb.Text);
                this.DataTable1TableAdapter.Fill(this.ViewReportDataset.DataTable1, ID);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something is going wrong");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ViewReports Vr = new ViewReports();
            this.Hide();
            Vr.Show();
        }
    }
}
