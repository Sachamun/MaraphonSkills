using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace g463_zaharov_demo
{
    public partial class Sponsor_a_runner : Form
    {
        public static string connection_string = "Data Source=home-pc;Initial Catalog=g463_zaharov_demo;Integrated Security=True";
        private SqlConnection connection;

        public Sponsor_a_runner()
        {
            InitializeComponent();

            connection = new SqlConnection(connection_string);
            connection.Open();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            Main open = new Main();
            open.WindowState = FormWindowState.Normal;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            string sponsor_name = txt_sponsor_name.Text;
            string card = txt_card.Text;
            string card_code = txt_card_code.Text;
            string card_month = txt_month.Text;
            string card_year = txt_year.Text;
            string cvc = txt_cvc.Text;
            string money = txt_money.Text;

            DateTime t = DateTime.Now;

            int y = int.Parse(card_year);
            int m = int.Parse(card_month);

            bool inv = false;
            if (t.Year >= y)
            {
                if (t.Year == y)
                {
                    if (t.Month < m)
                        inv = true;
                }
            }
            if (inv == false)
            {
                MessageBox.Show("Срок действия карты не действителен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sponsor_name == "Ваше имя" || card == "Владелец карты" || card_month == "01" || card_year == "2017" || txt_card_code.MaskFull == false || txt_cvc.MaskFull == false)
            {
                MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "INSERT INTO Sponsorship (SponsorName, [RegistrationId], Amount) VALUES ('" + sponsor_name + "', " + cb_runner.SelectedValue + ", " + money + ")";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                Sponsorship_confirmation open = new Sponsorship_confirmation();
                open.label7.Text = "$ " + money;
                open.label5.Text = cb_runner.Text;
                open.Show();

                this.Close();
            }
        }

        private void txt_sponsor_name_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
            }
            else
            {
                if ((string)t.Tag == t.Text) t.Text = "";
            }
            t.ForeColor = Color.Black;
        }

        private void txt_sponsor_name_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = (string)t.Tag;
                t.ForeColor = Color.Gray;       
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label17.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void Sponsor_a_runner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g463_zaharov_demoDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.g463_zaharov_demoDataSet.DataTable1);
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            string a = txt_money.Text;
            int x = int.Parse(a);
            x += 10;
            txt_money.Text = x.ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            string a = txt_money.Text;
            int x = int.Parse(a);
                if(x >= 10)
                    x -= 10;
            txt_money.Text = x.ToString();
        }

        private void Sponsor_a_runner_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
            Form main = Application.OpenForms[0];
            main.Show();
        }

        private void txt_money_TextChanged(object sender, EventArgs e)
        {
            label16.Text = txt_money.Text;
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
            this.Close();
        }
    }
}
