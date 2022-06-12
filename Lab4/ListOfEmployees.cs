using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    class ListOfEmployees
    {
        private List<Employee> MainList = new List<Employee>();
        public void Add(Employee item)
        {
            MainList.Add(item);
        }
        public int GExperience(int index)
        {
            return MainList[index].GetExperience();
        }
        public int GSalary(int index)
        {
            return MainList[index].GetSalary();
        }
        public int GHoliday(int index)
        {
            return MainList[index].GetHoliday();
        }
        public int GetCount()
        {
            return MainList.Count;
        }
        public int GetSubordinates()
        {
            int sub = 0;
            for(int i = 0; i < MainList.Count; ++i)
            {
                if (MainList[i].GetSalary() < 35000) ++sub;
            }
            return sub;
        }
    }
}
