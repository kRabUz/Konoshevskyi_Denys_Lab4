using Laba_4;
using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Head head_ex = new Head(15, 50000, 156);
            Manager manager_ex = new Manager(12, 35000, 104);
            Engineer engineer_ex = new Engineer(8, 20000, 52);
            Mechanic mechanic_ex = new Mechanic(6, 15000, 52);
            Engineer_Architect engineer_architect_ex = new Engineer_Architect(5, 12500, 52);
            ListOfEmployees list = new ListOfEmployees();
            list.Add(head_ex);
            list.Add(manager_ex);
            list.Add(engineer_ex);
            list.Add(mechanic_ex);
            list.Add(engineer_architect_ex);
            for (int i = 0; i < list.GetCount(); i++)
            {
                Console.WriteLine($"Employee "+ (i+1) +" has experience "+ list.GExperience(i) + "" +
                    " year, salary "+ list.GSalary(i) + " uah per month and " +
                    ""+ list.GHoliday(i) + " holidays per year ");
            }
            Console.WriteLine();
            Console.WriteLine($"Manager has "+list.GetSubordinates()+" subordinates");
        }
    }
}
