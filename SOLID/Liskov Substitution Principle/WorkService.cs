using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution_Principle
{
    // Данный класс устанавливает объект IWorking, передаваемый через конструктор.
    public class WorkService 
    {
        protected internal IWorking Work { get; }
        public WorkService(IWorking work)
        {
            Work = work;
        }
    }
}
