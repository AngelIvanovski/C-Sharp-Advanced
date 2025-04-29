using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public class Manager : Employee
    {
        public Manager(string fullName,int age,int salary,int bonus) : base(fullName,age,salary,bonus) { }
        
        public override int CalculateSalary()
        {
            return Salary + Bonus;
        }

        public override string DisplayInfo()
        {
            return $"Manager: {FullName}, Age: {Age}, Salary: {CalculateSalary()}";
        }
    }
    }

