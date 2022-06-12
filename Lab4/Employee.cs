using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    abstract class Employee
    {
        public abstract int Experience { get; set; }
        public abstract int Salary { get; set; }
        public abstract int Holiday { get; set; }
        public Employee(int experience, int salary, int holiday)
        {
            Experience = experience;
            Salary = salary;
            Holiday = holiday;
        }
        public abstract int GetExperience();
        public abstract int GetSalary();
        public abstract int GetHoliday();
    }
}
