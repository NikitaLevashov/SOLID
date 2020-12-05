using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.MessageMiddleware
{
    // Нокиа 3410 поддерживает только звонки и сообщения ( если бы интерфейс IPhone содержал методы ICall, IMessage, IPhotoVideo, IInternet пришлось бы реализовывать их все)
    public class PhoneNokia3410 : ICall, IMessage
    {
        public void Call()
        {

        }

        public void MakeMessage()
        {

        }
    }
}
