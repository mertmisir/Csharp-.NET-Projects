using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32002395_ArifMertMisir_lab1
{
    public partial class Form1 : Form
    {
        double result = 0; 
        string operatorr; // this one is for 4 operations(+,-,*,/)
        string firstnum;  // to store the label2's content.
        public Form1()
        {
            InitializeComponent();
        }


        private void AllNumbers_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;// An object with a Button type to get the button texts easily and assign them onto the label2.
            label2.Text = button.Text;
            firstnum = label2.Text;
            
        }

        private void Operations_Click(object sender, EventArgs e)
        { 
            Button button = (Button)sender; // An object again to be assigned to the operations.
            if (result != 0)
            {
               // button16.PerformClick(); // button 16 represents equal button. This PerformClick gets the result from ButtonEqual_Click function!
                operatorr = button.Text; 
            }

            else
            {
                operatorr = button.Text;
                result = double.Parse(label2.Text);// convert to double what you have inside the label2, assign it to the result.
                
            }

        }

        private void ButtonC_Click(object sender, EventArgs e) // clears all the history and the result.
        {
            label1.Text = string.Empty;
            result = 0;
            label2.Text = "0";
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            
            switch(operatorr)
            {
                case "+":
                    label2.Text = (result + Double.Parse(label2.Text)).ToString();
                    label1.Text = result.ToString() + operatorr + firstnum;
                    break;

                case "-":
                    label2.Text = (result - Double.Parse(label2.Text)).ToString();
                    label1.Text = result.ToString() + operatorr + firstnum;
                    break;

                case "*":
                    label2.Text = (result * Double.Parse(label2.Text)).ToString();
                    label1.Text = result.ToString() + operatorr + firstnum;
                    break;

                case "/":
                    label2.Text = (result / Double.Parse(label2.Text)).ToString();
                    label1.Text = result.ToString() + operatorr + firstnum;
                    break;

                default:
                    break;


            }
            result = double.Parse(label2.Text);
            operatorr = string.Empty;
        }


    }
}
