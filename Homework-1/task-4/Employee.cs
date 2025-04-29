using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public abstract class Employee
    {
        public Employee(string fullName,int age, int salary, int bonus)
        {
            FullName = fullName;
            Age = age;
            Salary = salary;
            Bonus = bonus;
        }
        public string FullName { get; set; }
        public int Age { get; set; }

        public int Salary { get; set; }

        public int Bonus { get; set; }

        public abstract int CalculateSalary();


        public abstract string DisplayInfo();

    }
}
