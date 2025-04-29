using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Classes;
class Rectangle : IShape
{
    public Rectangle(double length,double width)
    {
        Length = length;
        Width = width;
    }
    public double Length { get; set; }
    public double Width { get; set; }
    public double GetArea()
    {
       return Length * Width;
    }
}

