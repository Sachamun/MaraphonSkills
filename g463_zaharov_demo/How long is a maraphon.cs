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
    public partial class How_long_is_a_maraphon : Form
    {
        public How_long_is_a_maraphon()
        {
            InitializeComponent();
        }

        private void pc_car_Click(object sender, EventArgs e)
        {
            label4.Text = label2.Text;
            label5.Text = "Максимальная скорость F1 Car 345 км/ч. Это займет 7 минут, чтобы завершить 42 км марафон";
            pc_main.Image = pc_car.Image;
        }

        private void pc_worm_Click(object sender, EventArgs e)
        {
            label4.Text = label6.Text;
            label5.Text = "Максимальная скорость Worm 0,03 км/ч. Это займет 1400 часов, чтобы завершить 42 км марафон";
            pc_main.Image = pc_worm.Image;
        }

        private void pc_sloth_Click(object sender, EventArgs e)
        {
            label4.Text = label7.Text;
            label5.Text = "Максимальная скорость Sloth 0,12 км/ч. Это займет 350 часов, чтобы завершить 42 км марафон";
            pc_main.Image = pc_sloth.Image;
        }

        private void pc_capybara_Click(object sender, EventArgs e)
        {
            label4.Text = label8.Text;
            label5.Text = "Максимальная скорость Capybara 35 км/ч. Это займет 72 минуты, чтобы завершить 42 км марафон";
            pc_main.Image = pc_capybara.Image;
        }

        private void pc_jaguar_Click(object sender, EventArgs e)
        {
            label4.Text = label9.Text;
            label5.Text = "Максимальная скорость Jaguar 80 км/ч. Это займет 31,5 часа, чтобы завершить 42 км марафон";
            pc_main.Image = pc_jaguar.Image;
        }

        private void pc_airbus_Click(object sender, EventArgs e)
        {
            label4.Text = label14.Text;
            label5.Text = "Длина AirBus A380 73 м. Это займет 575 из них, чтобы покрыть расстояние в 42 км марафона";
            pc_main.Image = pc_airbus.Image;    
        }

        private void pc_havaianas_Click(object sender, EventArgs e)
        {
            label4.Text = label13.Text;
            label5.Text = "Длина Havaianas 0,245 м. Это займет 171428 из них, чтобы покрыть расстояние в 42 км марафона";
            pc_main.Image = pc_havaianas.Image;
        }

        private void pc_footfield_Click(object sender, EventArgs e)
        {
            label4.Text = label12.Text;
            label5.Text = "Длина Football filed 105 м. Это займет 400 из них, чтобы покрыть расстояние в 42 км марафона";
            pc_main.Image = pc_footfield.Image;
        }

        private void pc_ron_Click(object sender, EventArgs e)
        {
            label4.Text = label11.Text;
            label5.Text = "Длина Ronaldinho 1,81 м. Это займет 23204 из них, чтобы покрыть расстояние в 42 км марафона";
            pc_main.Image = pc_ron.Image;
        }

        private void pc_bus_Click(object sender, EventArgs e)
        {
            label4.Text = label10.Text;
            label5.Text = "Длина Bus 10 м. Это займет 4200 из них, чтобы покрыть расстояние в 42 км марафона";
            pc_main.Image = pc_bus.Image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label17.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            How_long_is_a_maraphon open = new How_long_is_a_maraphon();
            open.Show();
            this.Close();
        }
    }
}
