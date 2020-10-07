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
    public partial class labpatientAdmissionSlip : Form
    {
        public labpatientAdmissionSlip()
        {
            InitializeComponent();
        }

        private void labpatientAdmissionSlip_Load(object sender, EventArgs e)
        {
           

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                Int32 ID = Convert.ToInt32(Idtb.Text);
                // TODO: This line of code loads data into the 'labpatientdataset.DataTable1' table. You can move, or remove it, as needed.
                this.DataTable1TableAdapter.Fill(this.labpatientdataset.DataTable1, ID);
                // TODO: This line of code loads data into the 'HMSDataSet1.tbl_lab' table. You can move, or remove it, as needed.
                this.tbl_labTableAdapter.Fill(this.HMSDataSet1.tbl_lab);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is going wrong!");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            addlabpatient addlab = new addlabpatient();
            this.Hide();
            addlab.Show();
        }
    }
}
