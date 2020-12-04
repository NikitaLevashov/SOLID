using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    // Данный класс устанавливает объект IWork, передаваемый через конструктор.
    public class WorkService 
    {
        protected internal IWork Work { get; }
        public WorkService(IWork work)
        {
            Work = work;
        }
    }
}
