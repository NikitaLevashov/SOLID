using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    class SeniorEmployee // класс ИТ-специалист
    {
        public string Name { get; set; }

        public SeniorEmployee(string name)
        {
            this.Name = name;
        }

        public void DoTheWork(IWork work)  // Класс ИТ-специалист делегирует вид ит-деятельности (работы) методу Work объекта IWork.
        {
            work.Work();
        }
    }
}
