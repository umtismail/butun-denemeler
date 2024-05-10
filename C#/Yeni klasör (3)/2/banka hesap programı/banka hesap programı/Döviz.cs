using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_hesap_programı
{
    class Döviz:BankaHesap
    {
        double USD = 3.78;
        double EUR = 4.52;
        public double usd { get { return USD; } set { ;} }
        public double eur { get { return EUR; } set { ;} }
    }
}
