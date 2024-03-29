﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace g463_zaharov_demo
{
    public partial class Register_for_an_event : Form
    {
        public Register_for_an_event()
        {
            InitializeComponent();
        }

        int sum = 0;

        void summerise()
        {
            sum = 0;
                if (chb_full_mar.Checked)
                    sum += 145;
                if (chb_half_mar.Checked)
                    sum += 75;
                if (chb_small_mar.Checked)
                    sum += 20;
                if (rb_var_a.Checked)
                    sum += 0;
                if (rb_var_b.Checked)
                    sum += 20;
                if (rb_var_c.Checked)
                    sum += 45;
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            if (chb_full_mar.Checked || chb_half_mar.Checked || chb_small_mar.Checked)
            {
                if (int.Parse(txt_sum.Text) < 0)
                {
                    MessageBox.Show("Сумма взноса должна быть действительным положительным числом");
                }

                Registration_confirmation open = new Registration_confirmation();
                this.Close();
                open.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста выбирете один из видов марафона!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void Register_for_an_event_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zaharov_demoDataSet.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.g463_zaharov_demoDataSet.Charity);
        }

        private void rb_var_a_CheckedChanged(object sender, EventArgs e)
        {
            summerise();
            label10.Text = "$" + sum.ToString();    
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
