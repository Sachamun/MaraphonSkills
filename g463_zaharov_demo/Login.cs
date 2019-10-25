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
    public partial class Login : Form
    {
        public static string connection_string = "Data Source=home-pc;Initial Catalog=g463_zaharov_demo;Integrated Security=True";
        private SqlConnection connection;

        public Login()
        {
            InitializeComponent();

            connection = new SqlConnection(connection_string);
            connection.Open();
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = txt_login.Text;
            string password = txt_password.Text;

            string query = "select RoleId from [User] where [Email] = '" + login + "'";
            SqlCommand role = new SqlCommand(query, connection);
            string user_role = ((string)role.ExecuteScalar());

            string query2 = "select [Password] from [User] where [Email] = '" + login + "'";
            SqlCommand pass = new SqlCommand(query2, connection);
            string user_pass = ((string)pass.ExecuteScalar());

            if (login == "Enter your email address" || password == "Enter your password")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != user_pass)
            {
                MessageBox.Show("Введен неверный логин или пароль! Попробуйте еще раз!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (user_role == "R")
            {
                Runner_menu open = new Runner_menu();
                open.Show();
            }
            else if (user_role == "C")
            {
                Coordinator_menu open = new Coordinator_menu();
                open.Show();
            }
            else if (user_role == "A")
            {
                MessageBox.Show("Вы админ!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label17.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";       
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }
    }
}
