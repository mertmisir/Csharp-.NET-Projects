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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";
            openFD.InitialDirectory = "C:";
            openFD.FileName = "";
            openFD.Filter = "JPEG Images|*.jpg|GIF Images|*.gif";

            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled");
            }
            else
            {
                Chosen_File = openFD.FileName;
                pictureBox1.Image = Image.FromFile(Chosen_File);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname, email;

            name = textBox1.Text;
            surname = textBox2.Text;
            email = textBox3.Text;
            string temp;
            temp = name + "\n" + surname + "\n" + email;
            MessageBox.Show(temp,"Your changes has been recorded");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";
            openFD.InitialDirectory = "C:";
            openFD.Title = "Open a Text File";
            openFD.FileName = "";
            openFD.Filter = "Text Files|*.txt|WordDocuments|*.doc";

            if (openFD.ShowDialog() != DialogResult.Cancel)
            {
                Chosen_File = openFD.FileName;
                richTextBox1.LoadFile(Chosen_File, RichTextBoxStreamType.PlainText);
            }
            else
            {
                MessageBox.Show("Operation Cancelled");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string interests = "";
            if (checkBox1.Checked)
            {
                interests = interests + checkBox1.Text + "\r\n";
                ;
            }
            if (checkBox2.Checked)
            {
                interests = interests + checkBox2.Text + "\r\n";

            }
            if (checkBox3.Checked)
            {
                interests = interests + checkBox3.Text + "\r\n";

            }
            if (checkBox4.Checked)
            {
                interests = interests + checkBox4.Text + "\r\n";

            }
            if (checkBox5.Checked)
            {
                interests = interests + checkBox5.Text + "\r\n";

            }
            if (checkBox6.Checked)
            {
                interests = interests + checkBox6.Text + "\r\n";

            }


            MessageBox.Show(interests, "Your Interests");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ChosenActivity = "";

            if (radioButton1.Checked)
            {
                ChosenActivity = radioButton1.Text + "\r\n";

            }
            else if (radioButton2.Checked)
            {
                ChosenActivity = radioButton2.Text + "\r\n";

            }
            else if (radioButton3.Checked)
            {
                ChosenActivity = radioButton3.Text + "\r\n";

            }
            else if (radioButton4.Checked)
            {
                ChosenActivity = radioButton4.Text + "\r\n";

            }
            else if (radioButton5.Checked)
            {
                ChosenActivity = radioButton5.Text + "\r\n";

            }
            else
            {
                ChosenActivity = radioButton6.Text + "\r\n";

            }

            MessageBox.Show(ChosenActivity, "Your Favourite Activity");
        }
    }
}
