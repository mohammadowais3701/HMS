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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void dischargePatients_Click(object sender, EventArgs e)
        {
            Statsform sf = new Statsform();
            this.Hide();
            sf.Show();
         
        }
    }
}
