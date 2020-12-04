using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution_Principle
{
    public interface IEmployee
    {
        string GetEmployeeInfo(int employeeId); // получить "условный возраст" работника
    }
}
