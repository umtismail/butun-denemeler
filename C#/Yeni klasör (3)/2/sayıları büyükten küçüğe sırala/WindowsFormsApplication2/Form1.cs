using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        { Form.ShowDialog();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList aList = new ArrayList();



            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                aList.Add(Convert.ToInt32(listBox2.Items[i]));
            }
            aList.Sort();
            listBox2.Items.Clear();


            foreach (var item in aList)
            {
                listBox2.Items.Add(item);
            }
            
        }
	            
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            listBox2.Items.Add(a);
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = 0;
            if ((int ) e.KeyChar>=48 && (int) e.KeyChar<=57)
            {
                e.Handled = false;
                a = 0;
            }
            else if((int )e.KeyChar==8)
            { 
                e.Handled=false ;
            }
            else
            {
                e.Handled = false;
                MessageBox.Show("yanlış girdin");
            }
            if (a=0;a



        }
    }
}
