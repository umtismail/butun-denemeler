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
  abstract class boynuzlugil:Iotcul
    {
        protected string isim;
   
       public boynuzlugil()
       {
         this.isim = "boynuz";
       }
       public override string ad()
       {
           return isim;
       } 
       public override string ye(Iotcul o)
       {
           return "bu gün de ot ile doyduk";
       }
    }
}
