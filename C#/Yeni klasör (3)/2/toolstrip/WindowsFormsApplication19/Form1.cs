using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (kalin==false)
            {richTextBox1.SelectionFont = new Font(richTextBox1.Font,FontStyle.Bold);
                kalin=true;}
            else
            {
                richTextBox1.SelectionFont= new Font(richTextBox1.Font,FontStyle.Regular);
                kalin=false;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont=new Font(richTextBox1.Font,FontStyle.Italic);

      }
        private bool kalin = false;

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont=new Font(richTextBox1.Font,FontStyle.Underline);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment=HorizontalAlignment.Left;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment=HorizontalAlignment.Center;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment=HorizontalAlignment.Right;
      }
           
            }
        }
    
