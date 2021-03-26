using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;



namespace laba1
{
    public partial class Form2 : Form
    {
        public object dataGridView1 { get; private set; }

        Form1 fgrid;
        public Form2(Form1 fg)

        {
            InitializeComponent();
            this.fgrid = fg;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            fgrid.dataGridView1.Rows.Add(name.Text, name2.Text, login.Text, pass.Text, phone.Text, mail.Text);
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phone_KeyPress(object sender, CancelEventArgs e)
        {

            

        }

       

        private void login_TextChanged_1(object sender, EventArgs e)
        {
            if (login.Text == null)
                MessageBox.Show("Не присвоено значение A", "Ошибка");
        }
    }
}
