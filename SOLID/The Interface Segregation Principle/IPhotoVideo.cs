using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.MessageMiddleware
{
    // Данный класс устанавливает объект IMessage, передаваемый через конструктор.
    interface IPhotoVideo
    {
        void MakePhotoVideo();
    }
}
