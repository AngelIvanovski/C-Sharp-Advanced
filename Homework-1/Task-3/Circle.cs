using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Circle : Shape
    {

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }


        public override double CalculateArea()
        {
           return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
