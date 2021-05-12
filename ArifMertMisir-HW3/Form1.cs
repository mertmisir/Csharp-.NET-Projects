using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArifMertMisir_HW3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        Form2 mysecondform = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            string username, password, temp_user, temp_pass;
            temp_user = "arifmertmisir";
            temp_pass = "12345";
            username = textBox1.Text;
            password = textBox2.Text;

            if (username != temp_user || password != temp_pass)
            {
                MessageBox.Show("Invalid username or password", "Error");
                counter++;
            }

            else
            {
                mysecondform.Show();
  
            }

            if (counter == 3)
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '?';
            textBox1.MaxLength = 14;
        }
    }
}
