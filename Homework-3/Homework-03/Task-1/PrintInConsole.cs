using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class PrintInConsole
    {
        public void Print<T>(T item)
        {
            Console.WriteLine(item);
        }

        public void PrintCollection<T>(List<T> items)
        {
            int count = 1;
            foreach (T item in items)
            {
                Console.WriteLine($"Item {count}: {item}");
                count++;
            }
        }
    }
}