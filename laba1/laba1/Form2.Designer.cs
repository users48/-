using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace laba1
{
    partial class Form2
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
            this.pa = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.ph = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.ma = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.nam = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // pa
            // 
            this.pa.AutoSize = true;
            this.pa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pa.Location = new System.Drawing.Point(208, 154);
            this.pa.Name = "pa";
            this.pa.Size = new System.Drawing.Size(68, 20);
            this.pa.TabIndex = 0;
            this.pa.Text = "пароль ";
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(212, 177);
            this.pass.Name = "pass";
            this.pass.PasswordChar = ' ';
            this.pass.Size = new System.Drawing.Size(118, 26);
            this.pass.TabIndex = 1;
            this.pass.UseSystemPasswordChar = true;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(12, 154);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(55, 20);
            this.log.TabIndex = 0;
            this.log.Text = "Логин";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(12, 177);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(118, 26);
            this.login.TabIndex = 1;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged_1);
            // 
            // ph
            // 
            this.ph.AutoSize = true;
            this.ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ph.Location = new System.Drawing.Point(12, 84);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(79, 20);
            this.ph.TabIndex = 0;
            this.ph.Text = "Телефон";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(12, 107);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(118, 26);
            this.phone.TabIndex = 1;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(12, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(118, 26);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // ma
            // 
            this.ma.AutoSize = true;
            this.ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ma.Location = new System.Drawing.Point(208, 84);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(48, 20);
            this.ma.TabIndex = 0;
            this.ma.Text = "Email";
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail.Location = new System.Drawing.Point(212, 107);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(118, 26);
            this.mail.TabIndex = 1;
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nam.Location = new System.Drawing.Point(208, 17);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(81, 20);
            this.nam.TabIndex = 0;
            this.nam.Text = "Фамилия";
            // 
            // name2
            // 
            this.name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name2.Location = new System.Drawing.Point(212, 40);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(118, 26);
            this.name2.TabIndex = 1;
            this.name2.TextChanged += new System.EventHandler(this.name2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(375, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 231);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.ph);
            this.Controls.Add(this.login);
            this.Controls.Add(this.log);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.pa);
            this.MaximumSize = new System.Drawing.Size(600, 270);
            this.MinimumSize = new System.Drawing.Size(600, 270);
            this.Name = "Form2";
            this.Text = "Новый Пользователь ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void name2_TextChanged(object sender, EventArgs e)
        {

        }
        private void mail_TextChanged(object sender, EventArgs e)
            {

            }
        private void name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
           

        }

        #endregion

        private System.Windows.Forms.Label pa;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label ph;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label ma;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label nam;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}