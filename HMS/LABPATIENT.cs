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
    public partial class LABPATIENT : Form
    {
        public LABPATIENT()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            addlabpatient add = new addlabpatient();
            this.Hide();
            add.Show();

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            editlabpatient edit = new editlabpatient();
            this.Hide();
            edit.Show();
        }

        private void createreport_Click(object sender, EventArgs e)
        {
            LabReports LR = new LabReports();
            this.Hide();
            LR.Show();
        }

        private void view_Click(object sender, EventArgs e)
        {
            viewlabpatients vlp = new viewlabpatients();
            this.Hide();
            vlp.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            LAB lab = new LAB();
            this.Hide();
            lab.Show();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            REMOVELABPATIENTS remlp = new REMOVELABPATIENTS();
            this.Hide();
            remlp.Show();
        }
    }
}
