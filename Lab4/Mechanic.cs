using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    class Mechanic : Employee
    {
        private int experience;
        private int salary;
        private int holiday;
        public Mechanic(int experience, int salary, int holiday) : base(experience, salary, holiday) { }
        public override int Experience
        {
            get => experience;
            set => experience = value;
        }
        public override int Salary
        {
            get => salary;
            set => salary = value;
        }
        public override int Holiday
        {
            get => holiday;
            set => holiday = value;
        }
        public override int GetExperience()
        {
            return Experience;
        }
        public override int GetSalary()
        {
            return Salary;
        }
        public override int GetHoliday()
        {
            return Holiday;
        }
    }
}
