using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace g463_zaharov_demo
{
    public partial class Edit_runner_profile : Form
    {
        public static string connection_string = "Data Source=home-pc;Initial Catalog=g463_zaharov_demo;Integrated Security=True";
        private SqlConnection connection;

        string country;
        string gender;
        DateTime birthday;
        Image image;

        DateTime date_now = DateTime.Now;

        void LoadData()
        {
            label14.Text = Login.login;

            string name = txt_name.Text;
            string surname = txt_surname.Text;
            string file_image = txt_file_image.Text;
            string password = txt_password.Text;
            string repeat_password = txt_repeat_password.Text;
            string prof_img = txt_file_image.Text;

            string query = "select FirstName, LastName, Gender, DateOfBirth, CountryCode, ProfileImage from [User] inner join Runner on [User].Email = Runner.Email where [User].Email = '" + label14.Text + "';";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                name = (string)reader[0];
                surname = (string)reader[1];
                gender = (string)reader[2];
                birthday = (DateTime)reader[3];
                country = (string)reader[4];
                prof_img = (string)reader[5];

            }

            txt_name.Text = name.ToString();
            txt_surname.Text = surname.ToString();
            dtp_birthday.Value = birthday;
            cb_gender.SelectedValue = gender;
            cb_country.SelectedValue = country;
            txt_file_image.Text = prof_img.ToString();

            if(prof_img != "")
            {
                profile_image.BackgroundImage = Image.FromFile("C:\\Users\\Евгений\\Documents\\Конспекты\\4 курс\\Демо экзамен\\Image\\" + txt_file_image.Text);
            }

            reader.Close();
        }

        public Edit_runner_profile()
        {
            InitializeComponent();

            connection = new SqlConnection(connection_string);
            connection.Open();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label17.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Runner_menu open = new Runner_menu();
            this.Close();
            open.Show();
        }

        private void txt_name_Enter(object sender, EventArgs e)
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

        private void txt_name_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = (string)t.Tag;
                t.ForeColor = Color.Gray;
            }
        }

        private void Edit_runner_profile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zaharov_demoDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.g463_zaharov_demoDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zaharov_demoDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.g463_zaharov_demoDataSet.Gender);

            LoadData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string surname = txt_surname.Text;
            string file_image = txt_file_image.Text;
            string password = txt_password.Text;
            string repeat_password = txt_repeat_password.Text;
            string email = label14.Text;
            birthday = dtp_birthday.Value;
            gender = cb_gender.SelectedValue.ToString();
            country = cb_country.SelectedValue.ToString();
            

            if (name == "Имя" || surname == "Фамилия")
            {
                MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(file_image == "")
            {
                MessageBox.Show("Загрузите свою фотографию!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (date_now.Year - dtp_birthday.Value.Year < 10 || dtp_birthday.Value.Year> date_now.Year)
            {
                MessageBox.Show("Дата рождения должна быть правильной и бегуну должно быть не менее 10 лет!", "Дата должна соответствовать следующим требованиям!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(password == "Пароль")
            {
                string query = "update [User] set FirstName = '"+ name +"', LastName = '"+ surname +"', ProfileImage = '"+ file_image +"' where Email = '"+ email +"'";
                string query2 = "update [Runner] set Gender = '"+ gender + "', DateOfBirth = '" + birthday + "', CountryCode = '" + country +"'";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                SqlCommand command2 = new SqlCommand(query2, connection);
                command2.ExecuteNonQuery();
            }
            else if(password != "Пароль")
            {
                if (check_password(password) == false)
                {
                    MessageBox.Show("Пароль должен отвечать следующим требованиям: минимум 6 символов, минимум 1 прописная буква, минимум 1 цифра, по крайней мере один из следующих символов !@#$%^", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (repeat_password != password)
                {
                    MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {     
                    string query = "update [User] set FirstName = '" + name + "', LastName = '" + surname + "', ProfileImage = '" + file_image + "', Password = '" + password +"' where Email = '" + email + "'";
                    string query2 = "update [Runner] set Gender = '" + gender + "', DateOfBirth = '" + birthday + "', CountryCode = '" + country + "' where Email = '"+ email +"'";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.ExecuteNonQuery();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

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
    }
}
