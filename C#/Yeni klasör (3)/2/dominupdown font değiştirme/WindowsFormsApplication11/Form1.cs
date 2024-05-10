using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Font = new Font(Convert.ToString(domainUpDown1.SelectedItem), 20);
            }

            catch
            {
                domainUpDown1.SelectedIndex++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 10; i < 100; i++)
            {
                domainUpDown1.Items.Add(System.Drawing.FontFamily.Families[i].Name);
            }
            {
                domainUpDown1.Wrap = true;
            }
        }
    }
}
