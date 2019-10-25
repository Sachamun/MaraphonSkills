using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace g463_zaharov_demo
{
    public partial class Register_as_a_runner_2 : Form
    {
        public Register_as_a_runner_2()
        {
            InitializeComponent();
        }

        Image image;
        DateTime date_now = DateTime.Now;

        public static bool check_email(string email)
        {
            string pattern = "[0-9A-Za-z\\-\\._]+@[0-9A-Za-z]+.[a-z]{2,6}";

            Match match = Regex.Match(email, pattern);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool check_password(string password)
        {
            string pattern = "(?=.*[0-9])(?=.*[a-z])(?=.*[!@#$%^]){6,}";

            Match match = Regex.Match(password, pattern);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Файлы изоброжений | *.bmp; *.jpg; *.png";
            if (opf.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                image = Image.FromFile(opf.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка чтения файла картинки");
                return;
            }
            profile_image.BackgroundImage = image;
            txt_file_image.Text = opf.SafeFileName.ToString();
        }

        private void Register_as_a_runner_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_registration_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;
            string repeat_password = txt_repeat_password.Text;
            string name = txt_name.Text;
            string surname = txt_surname.Text;
            string file_image = txt_file_image.Text;

            if (email == "Email" || password == "Пароль" || repeat_password == "Повторите пароль" || name == "Имя" || surname == "Фамилия")
            {
                MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (file_image == "")
            {
                MessageBox.Show("Загрузите свою фотографию!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (check_email(email) == false)
            {
                MessageBox.Show("Email должен соответствовать следующему формату: x@x.x!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (check_password(password) == false)
            {
                MessageBox.Show("Пароль должен отвечать следующим требованиям: минимум 6 символов, минимум 1 прописная буква, минимум 1 цифра, по крайней мере один из следующих символов !@#$%^", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != repeat_password)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (date_now.Year - dtp_birthday.Value.Year < 10 || dtp_birthday.Value.Year > date_now.Year)
            {
                MessageBox.Show("Дата рождения должна быть правильной и бегуну должно быть не менее 10 лет!", "Дата должна соответствовать следующим требованиям!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Register_for_an_event open = new Register_for_an_event();
                this.Close();
                open.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label17.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void Register_as_a_runner_2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g463_zaharov_demoDataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.g463_zaharov_demoDataSet.Gender);
            // TODO: This line of code loads data into the 'g463_zaharov_demoDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.g463_zaharov_demoDataSet.Country);
        }
    }
}
