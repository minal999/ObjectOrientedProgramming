using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2
{
    internal class Circle
    {
        double pi=3.14,radius,area;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void CalculateArea()
        {
            area = pi * radius * radius;
        }

        public string Display()
        {
            return $"Area of Circle is {area}";
        }
    }
}
