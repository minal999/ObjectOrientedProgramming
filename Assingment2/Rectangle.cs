using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2
{
    internal class Rectangle
    {
        double l,b,perimeter;

        public Rectangle(double l,double b)
        {
            this.l = l;
            this.b = b;
        }

        public void CalculatePerimeter()
        {
            perimeter = 2 * (l + b);
        }

        public string Display()
        {
            return $"Perimeter of Rectangle is {perimeter}";
        }
    }
}
