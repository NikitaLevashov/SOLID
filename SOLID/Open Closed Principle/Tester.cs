using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    class Tester : IWork  //Реализуем интерфейс IWork в классе Tester
    {
        public string Work()
        {
            return "Тестировать код";
          
        }

    }
}
