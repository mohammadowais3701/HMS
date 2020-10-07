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
    public partial class LAB : Form
    {
        public LAB()
        {
            InitializeComponent();
        }

        private void patientbtn_Click(object sender, EventArgs e)
        {
            LABPATIENT labp = new LABPATIENT();
            this.Hide();
            labp.Show();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            diagnosis dg = new diagnosis();
            this.Hide();
            dg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void medtestbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
