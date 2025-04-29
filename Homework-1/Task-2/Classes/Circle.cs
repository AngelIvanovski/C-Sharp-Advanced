using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes
{
    public class Circle : IShape
    {

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }


    }
}
