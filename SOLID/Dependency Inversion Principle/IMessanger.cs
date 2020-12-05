using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion_Principle
{
    public interface IMessenger
    {
        string SendMessage(string text);
    }
}
