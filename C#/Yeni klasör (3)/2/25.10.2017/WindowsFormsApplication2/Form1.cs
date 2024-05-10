using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y, z,a,b,c;
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhabalar herkese");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip x = new ToolTip();
            x.SetToolTip(button1, "bu buton mesaj veriyor");
            x.ToolTipTitle = "dikkat";
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
            Random rnd = new Random();
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            timer1.Enabled = true;
            this.BackColor = Color.FromArgb(x, y, z);
            this.backClor = Color.label1(x, y, z);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            timer2.Enabled = true;
            richTextBox1.ForeColor = Color.FromArgb(x, y, z);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            label5.Text ="Sonuç = "+ c.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a - b;
            label5.Text = "Sonuç = "+ c.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a * b;
            label5.Text ="Sonuç = "+ c.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a / b;
            label5.Text ="Sonuç = "+ c.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            timer2.Enabled = true;
            richTextBox1.ForeColor = Color.FromArgb(x, y, z);
        }
    }
}
