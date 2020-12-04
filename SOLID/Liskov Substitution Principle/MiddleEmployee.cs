using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution_Principle
{
    public class MiddleEmployee : IWorking, IEmployee //реализуем интерфейсы IWorking, IEmployee
    {
        public string GetWorkInfo(int employeeId)
        {
            return "Middle Work";
        }

        public string GetEmployeeInfo(int employeeId)
        {
            return "Middle Employee";
        }

    }
}
