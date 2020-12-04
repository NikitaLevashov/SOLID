using SOLID.Liskov_Substitution_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution_Principle
{
    public class SeniorEmployee : IWorking, IEmployee // реализуем интерфейсы IWorking, IEmployee
    {
        public string GetWorkInfo(int employeeId)
        {
            return "Senior Work";
        }

        public string GetEmployeeInfo(int employeeId)
        {
            return "Senior Employee";
        }

    }
}
