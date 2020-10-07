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
    public partial class diagnosis : Form
    {
        public diagnosis()
        {
            InitializeComponent();
        }

        private void testlistbtn_Click(object sender, EventArgs e)
        {
            labtest lt = new labtest();
            this.Hide();
            lt.Show();
        }

        private void viewreportbtn_Click(object sender, EventArgs e)
        {
            ViewReports vR = new ViewReports();
            this.Hide();
            vR.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LAB lab = new LAB();
            this.Hide();
            lab.Show();
        }
    }
}
