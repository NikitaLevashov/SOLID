using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution_Principle
{
    public interface IWorking
    {
        string GetWorkInfo(int employeeId); // получить опыт работника
    }
}
