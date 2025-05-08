using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Classes
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a boat and I do not have wheels :(");
        }

        public void Sail()
        {
            Console.WriteLine("Sailing");
        }
    }
}