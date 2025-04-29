using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Triangle : IShape
    {

        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }
        public double Base { get; set; }
        public double Height { get; set; }  

        public double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
