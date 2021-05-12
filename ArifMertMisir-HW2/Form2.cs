using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArifMertMisir_HW2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Are you sure?","Exit",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            string temp;
            if (textBox1.SelectedText != "")
            {
                temp = textBox1.SelectedText;
                MessageBox.Show(temp);
                textBox1.Cut();

            }
            
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            if(textBox1.CanUndo == true )
            {
                textBox1.Undo();
                textBox1.ClearUndo();
                textBox2.Clear();

            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
                
            }
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true )
            {
                textBox2.Paste();
                Clipboard.Clear();
            }
        }

        private void mnuViewTextBoxes_Click(object sender, EventArgs e)
        {
            mnuViewTextBoxes.Checked = !mnuViewTextBoxes.Checked;
            textBox1.Visible = !textBox1.Visible;
            textBox2.Visible = !textBox2.Visible;
        }
    }
}
