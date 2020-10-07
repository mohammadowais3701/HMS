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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ADDPATIENT add = new ADDPATIENT();
           
            this.Hide();
            add.Show();
        }

        private void view_Click(object sender, EventArgs e)
        {
            VIEWPATIENT vp = new VIEWPATIENT();
            this.Hide();
            vp.Show();

        }

        private void remove_Click(object sender, EventArgs e)
        {
            REMOVEPATIENTS rem = new REMOVEPATIENTS();
            this.Hide();
            rem.Show();
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EDITPATIENT ed = new EDITPATIENT();
            ed.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Recepitionist rep = new Recepitionist();
            rep.Show();
            this.Hide();
        }
    }
}
