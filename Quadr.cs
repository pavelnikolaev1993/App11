using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    struct Func
    {
        double k;
        double b;
        
        public Func(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (k == 0 || b == 0)
            {
                return "Любое число может быть решением";
            }
            else if (k != 0)
            {
                double x = -b / k;
                return $"Решением является {x}";
            }
         
            else
            {
                return "Решения нет";
            }
        }
    }
}
