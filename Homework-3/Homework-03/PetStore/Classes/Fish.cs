using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Classes
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public Fish(string name, string type, int age, string color, string size) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Fish: {Name}, Age: {Age}, Color: {Color}, Size: {Size}");
        }
    }
}