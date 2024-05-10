using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydetCtrlF12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kaydet dümesine tıkladın");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            açToolStripMenuItem.Checked = true;
            açToolStripMenuItem.Enabled = false;
        }
    }
}
