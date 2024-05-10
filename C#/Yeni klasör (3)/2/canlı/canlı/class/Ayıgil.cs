using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace canlı
{
   abstract class Ayıgil:Ietecil,Iotcul
    {
         protected string isim;
   
       public Ayıgil()
       {
         this.isim = "bear";
       }
       public override string ad()
       {
           return isim;
       }
       public override string avlan(Ietecil e)
       {
           return "bu günde etcil ile doyduk";
       }
       public override string avlan(Iotcul e)
       {
           return "bu günde otçul doyduk";
       }
       public override string ye(Iotcul o)
       {
           return "bu günde ot ile doyduk";
       }
       
    }
}
