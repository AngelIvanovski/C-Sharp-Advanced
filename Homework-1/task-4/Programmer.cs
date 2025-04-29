using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public class Programmer : Employee
    {

        public Programmer(string fullName, int age, int salary, int bonus) : base(fullName, age, salary, bonus) {  }
     
        
        public override int CalculateSalary()
        {
            return Salary + Bonus;
        }

        public override string DisplayInfo()
        {
            return $"Programmer: {FullName}, Age: {Age}, Salary: {CalculateSalary()}";
        }
    }
}
