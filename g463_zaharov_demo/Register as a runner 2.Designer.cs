namespace g463_zaharov_demo
{
    partial class Register_as_a_runner_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_repeat_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g463_zaharov_demoDataSet = new g463_zaharov_demo.g463_zaharov_demoDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_file_image = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_registration = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.profile_image = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.countryTableAdapter = new g463_zaharov_demo.g463_zaharov_demoDataSetTableAdapters.CountryTableAdapter();
            this.genderTableAdapter = new g463_zaharov_demo.g463_zaharov_demoDataSetTableAdapters.GenderTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zaharov_demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 62);
            this.panel2.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(141, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "MARATHON SKILLS 2017";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(12, 10);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(91, 40);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(302, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 34);
            this.label2.TabIndex = 37;
            this.label2.Text = "Регистрация бегуна";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(827, 62);
            this.label3.TabIndex = 38;
            this.label3.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться в качестве бегуна";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_email.ForeColor = System.Drawing.Color.Gray;
            this.txt_email.Location = new System.Drawing.Point(229, 230);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(311, 30);
            this.txt_email.TabIndex = 40;
            this.txt_email.Text = "Email";
            this.txt_email.Enter += new System.EventHandler(this.txt_sponsor_name_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_sponsor_name_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(143, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 26);
            this.label7.TabIndex = 39;
            this.label7.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(121, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 41;
            this.label4.Text = "Пароль:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_password.ForeColor = System.Drawing.Color.Gray;
            this.txt_password.Location = new System.Drawing.Point(229, 265);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(263, 30);
            this.txt_password.TabIndex = 42;
            this.txt_password.Text = "Пароль";
            this.txt_password.Enter += new System.EventHandler(this.txt_sponsor_name_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_sponsor_name_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(4, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 26);
            this.label5.TabIndex = 43;
            this.label5.Text = "Повторите пароль:";
            // 
            // txt_repeat_password
            // 
            this.txt_repeat_password.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_repeat_password.ForeColor = System.Drawing.Color.Gray;
            this.txt_repeat_password.Location = new System.Drawing.Point(229, 300);
            this.txt_repeat_password.Name = "txt_repeat_password";
            this.txt_repeat_password.Size = new System.Drawing.Size(263, 30);
            this.txt_repeat_password.TabIndex = 44;
            this.txt_repeat_password.Text = "Повторите пароль";
            this.txt_repeat_password.Enter += new System.EventHandler(this.txt_sponsor_name_Enter);
            this.txt_repeat_password.Leave += new System.EventHandler(this.txt_sponsor_name_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(157, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 26);
            this.label6.TabIndex = 45;
            this.label6.Text = "Имя:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(104, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 26);
            this.label8.TabIndex = 46;
            this.label8.Text = "Фамилия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(159, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 26);
            this.label9.TabIndex = 47;
            this.label9.Text = "Пол:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_name.ForeColor = System.Drawing.Color.Gray;
            this.txt_name.Location = new System.Drawing.Point(229, 335);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(263, 30);
            this.txt_name.TabIndex = 48;
            this.txt_name.Text = "Имя";
            this.txt_name.Enter += new System.EventHandler(this.txt_sponsor_name_Enter);
            this.txt_name.Leave += new System.EventHandler(this.txt_sponsor_name_Leave);
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_surname.ForeColor = System.Drawing.Color.Gray;
            this.txt_surname.Location = new System.Drawing.Point(229, 370);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(263, 30);
            this.txt_surname.TabIndex = 49;
            this.txt_surname.Text = "Фамилия";
            this.txt_surname.Enter += new System.EventHandler(this.txt_sponsor_name_Enter);
            this.txt_surname.Leave += new System.EventHandler(this.txt_sponsor_name_Leave);
            // 
            // cb_gender
            // 
            this.cb_gender.DataSource = this.genderBindingSource;
            this.cb_gender.DisplayMember = "Gender";
            this.cb_gender.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(229, 405);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(137, 30);
            this.cb_gender.TabIndex = 50;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.g463_zaharov_demoDataSet;
            // 
            // g463_zaharov_demoDataSet
            // 
            this.g463_zaharov_demoDataSet.DataSetName = "g463_zaharov_demoDataSet";
            this.g463_zaharov_demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(524, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 26);
            this.label10.TabIndex = 51;
            this.label10.Text = "Фото файл:";
            // 
            // txt_file_image
            // 
            this.txt_file_image.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_file_image.ForeColor = System.Drawing.Color.Gray;
            this.txt_file_image.Location = new System.Drawing.Point(529, 333);
            this.txt_file_image.Name = "txt_file_image";
            this.txt_file_image.Size = new System.Drawing.Size(231, 30);
            this.txt_file_image.TabIndex = 52;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(461, 471);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 40);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_registration
            // 
            this.btn_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_registration.ForeColor = System.Drawing.Color.Black;
            this.btn_registration.Location = new System.Drawing.Point(295, 471);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(138, 40);
            this.btn_registration.TabIndex = 53;
            this.btn_registration.Text = "Регистрация";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_view.ForeColor = System.Drawing.Color.Black;
            this.btn_view.Location = new System.Drawing.Point(766, 327);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(147, 36);
            this.btn_view.TabIndex = 54;
            this.btn_view.Text = "Просмотр";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // profile_image
            // 
            this.profile_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_image.Location = new System.Drawing.Point(766, 178);
            this.profile_image.Name = "profile_image";
            this.profile_image.Size = new System.Drawing.Size(147, 148);
            this.profile_image.TabIndex = 55;
            this.profile_image.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(524, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 26);
            this.label11.TabIndex = 56;
            this.label11.Text = "Дата рождения:";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_birthday.Location = new System.Drawing.Point(719, 371);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(197, 30);
            this.dtp_birthday.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(614, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 26);
            this.label12.TabIndex = 58;
            this.label12.Text = "Страна:";
            // 
            // cb_country
            // 
            this.cb_country.DataSource = this.countryBindingSource;
            this.cb_country.DisplayMember = "CountryName";
            this.cb_country.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(719, 409);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(197, 30);
            this.cb_country.TabIndex = 59;
            this.cb_country.ValueMember = "CountryCode";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.g463_zaharov_demoDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(0, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 39);
            this.panel1.TabIndex = 60;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(159, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 26);
            this.label17.TabIndex = 61;
            this.label17.Text = "Время";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // Register_as_a_runner_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_country);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.profile_image);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_registration);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_file_image);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_repeat_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register_as_a_runner_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maraphon Skills 2017 - Register as a runner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_as_a_runner_2_FormClosed);
            this.Load += new System.EventHandler(this.Register_as_a_runner_2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zaharov_demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_repeat_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_file_image;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.PictureBox profile_image;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer timer1;
        private g463_zaharov_demoDataSet g463_zaharov_demoDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private g463_zaharov_demoDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private g463_zaharov_demoDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
    }
}