using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion_Principle
{
    // Данный класс устанавливает объект IMessenger, передаваемый через конструктор.
    public class MessageService 
    {
        protected internal IMessenger Messenger { get; }
        public MessageService(IMessenger message)
        {
            Messenger = message;
        }
    }
}
