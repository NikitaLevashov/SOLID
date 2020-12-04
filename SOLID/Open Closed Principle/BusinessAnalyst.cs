using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    class BusinessAnalyst : IWork // реализуем интерфейс IWork в классе BusinessAnalyst
    {
        public string Work()
        {
            return "Изучение бизнес-процессов";

        }
    }
}
