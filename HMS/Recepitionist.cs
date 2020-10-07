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
    public partial class Recepitionist : Form
    {
        int pwidth;
        bool Hidden;

        public Recepitionist()
        {
            InitializeComponent();
            pwidth = panel2.Width;
           // panel2.Width = panel2.Width - 10;
            panel2.Width =0;
            Hidden = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctors dr = new Doctors();
            this.Hide();
            dr.Show();
        }

        private void admission_Click(object sender, EventArgs e)
        {
            Patients pat = new Patients();
            pat.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Hsstory_Click(object sender, EventArgs e)
        {
            HISTORY his = new HISTORY();
            this.Hide();
            his.Show();
        }

        private void appointments_Click(object sender, EventArgs e)
        {
            APPOINTMENTS app = new APPOINTMENTS();
            this.Hide();
            app.Show();
        }

        private void doctor_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panel2.Width = panel2.Width + 10;
                if (panel2.Width>=pwidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Width = panel2.Width - 10;
                if (panel2.Width <=0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }

            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           BackupDB db = new BackupDB();
            this.Hide();
            db.Show();
        }
    }
}
