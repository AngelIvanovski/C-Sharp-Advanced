using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Classes
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, string type, int age, bool lazy, int livesLeft) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Cat: {Name}, Age: {Age}, Lazy: {Lazy}, Lives Left: {LivesLeft}");
        }
    }
}