﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public void GetNotification(string message)
        {
            Console.WriteLine($"{Name}: {message}");
        }
    }
}
