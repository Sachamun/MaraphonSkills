using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace g463_zaharov_demo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_sponsor_Click(object sender, EventArgs e)
        {
            Sponsor_a_runner open = new Sponsor_a_runner();
            open.Show();

            this.Hide();
            //this.WindowState = FormWindowState.Minimized;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login open = new Login();
            open.Show();
            //this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label4.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void btn_registration_runner_Click(object sender, EventArgs e)
        {
            Register_as_a_runner open = new Register_as_a_runner();
            open.Show();
            this.Hide();
        }
    }
}
