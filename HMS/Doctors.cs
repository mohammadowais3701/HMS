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
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EDIT_DOCTOR ed = new EDIT_DOCTOR();
            this.Hide();
            ed.Show();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            REMOVE rem = new REMOVE();
            this.Hide();
            rem.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ADD_DOCTOR doc = new ADD_DOCTOR();
            this.Hide();
            doc.Show();
        }

        private void view_Click(object sender, EventArgs e)
        {
            VIEW view = new VIEW();
            this.Hide();
            view.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Recepitionist rec = new Recepitionist();
            this.Hide();
            rec.Show();
        }
    }
}
