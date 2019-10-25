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
    public partial class Runner_menu : Form
    {
        public Runner_menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label17.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void btn_contacts_Click(object sender, EventArgs e)
        {
            Contacts open = new Contacts();
            open.Show();
        }
    }
}
