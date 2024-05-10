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
   abstract class Kedigil:Ietecil
    {
       protected string isim;
      
       
       
       public Kedigil()
       {
         this.isim = "felida";
       }
       public override string ad()
       {
           return isim;
       }
       public override string avlan(Ietecil e)
       {
           return "etcil avlandı";
       }
       public override string avlan(Iotcul e)
       {
           return "otcul avlandı";
       }
    }
}
