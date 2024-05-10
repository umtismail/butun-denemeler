using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    class silindir:sekil
    {
        public silindir(double r, double h)
        : base(r, h)
        {
        }
        public override double Alan()
        {
        return 2 * PI * x * x + 2 * PI * x * y;
        }
        
    }
}
