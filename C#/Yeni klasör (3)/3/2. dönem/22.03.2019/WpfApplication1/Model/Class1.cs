using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Class1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void onpropertychanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
         }

        public string isim;
        public string Isim
        {
            get { return isim; }
            set {isim=value; onpropertychanged("isim"); onpropertychanged("fisim");}
        }

        public string sisim;
        public string sIsim
        {
            get { return sisim; }
            set { sisim = value; onpropertychanged("sisim"); onpropertychanged("fisim"); }
        }

        public string fisim;
        public string fIsim
        {
            get { return string.Format("{0} {1}", isim, sisim); }
            set { fisim = value; onpropertychanged("fisim"); }
        }

        
    }
}
