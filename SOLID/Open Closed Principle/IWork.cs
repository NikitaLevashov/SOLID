using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    public interface IWork // вид ит-деятельности(работы) заносим в интерфейс IWork
    {
        string Work();
    }
}
