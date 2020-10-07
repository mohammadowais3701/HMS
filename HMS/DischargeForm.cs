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
    public partial class DischargeForm : Form
    {
        public DischargeForm()
        {
            InitializeComponent();
        }

        private void DischargeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RemovepatientData.tbl_patientshistory' table. You can move, or remove it, as needed.
          
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 id = Convert.ToInt32(textBox1.Text);
                this.tbl_patientshistoryTableAdapter.Fill(this.RemovepatientData.tbl_patientshistory, id);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception Ex)
            {
                MessageBox.Show("something is going wrong");
            }

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            REMOVEPATIENTS rem = new REMOVEPATIENTS();
            this.Hide();
            rem.Show();
        }
    }
}
