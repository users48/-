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

namespace laba1
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1;
        private const int totalRecords = 43;
        private const int pageSize = 10;

        public Form1()
        {
            InitializeComponent();
            

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].ReadOnly = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2(this);
            
            a.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

       

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        
    }
}
