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
    public partial class Find_out_more_information : Form
    {
        public Find_out_more_information()
        {
            InitializeComponent();
        }

        private void btn_how_long_maraphon_Click(object sender, EventArgs e)
        {
            How_long_is_a_maraphon open = new How_long_is_a_maraphon();
            open.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label17.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About_Maraphon_Skills_2017 open = new About_Maraphon_Skills_2017();
            open.Show();
            this.Close();
        }
    }
}
