using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution_Principle
{
    // JuniorEmployee требует реализации только IEmployee, а не IWorking. При таком подходе будет поддерживаться принцип LSP

    class JuniorEmployee : IEmployee  // реализуем интерфейс только IEmployee, т.к. JuniorEmployee не может работать. 
    {
        public string GetEmployeeInfo(int employeeId)
        {
           return "Junior Employee";
        }

    }
}
