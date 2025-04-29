using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Triangle : Shape
    {

        public Triangle(double baseLength,double height)
        {
            BaseLength = baseLength;
            Height = height;

        }
        public double BaseLength { get; set; }
        public double Height { get; set; }  


        public override double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }

        public override double CalculatePerimeter()
        {
            return 3 * BaseLength;
        }
    }
}
