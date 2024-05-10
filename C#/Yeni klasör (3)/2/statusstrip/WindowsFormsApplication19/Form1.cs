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
            toolStripStatusLabel1.Text = "kopyala";
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
        
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "yazım modu";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "yazma modu";
        }
           
            }
        }
    
