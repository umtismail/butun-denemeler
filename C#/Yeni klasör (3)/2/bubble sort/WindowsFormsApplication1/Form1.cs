using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] dizi = { 8, 0, 3, 5, 2, 4 };
            int gecici;

            for (int i = dizi.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= dizi.Length - 1; j++)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }
            foreach (int a in dizi)
            {
                listBox1.Items.Add(a.ToString());
            }
        }
    }
}
