using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    class SoftwareDeveloper : IWork  // реализуем интерфейс IWork в классе SoftwareDeveloper
    {
        public string Work()
        {
            return "Разрабатывать ПО";

        }
    }
}
