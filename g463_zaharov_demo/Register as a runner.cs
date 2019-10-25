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
    public partial class Register_as_a_runner : Form
    {
        public Register_as_a_runner()
        {
            InitializeComponent();
        }

        private void btn_old_runner_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_new_runner_Click(object sender, EventArgs e)
        {
            Register_as_a_runner_2 open = new Register_as_a_runner_2();
            open.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label17.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void Register_as_a_runner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
        }
    }
}
