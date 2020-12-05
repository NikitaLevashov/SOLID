using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion_Principle
{
    public class Facebook : IMessenger
    {
        public string SendMessage(string text)
        {
            return $"Сообщение отправлено в Facebook: {text}";
        }
    }
}
