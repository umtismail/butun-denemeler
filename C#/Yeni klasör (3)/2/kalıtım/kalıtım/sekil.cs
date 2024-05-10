using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    class sekil
    {
        public const double PI = Math.PI;
        protected double x, y;
        public sekil()
        {
        }
        public sekil(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double Alan()
        {
            return x * y;
        }
    }
}
