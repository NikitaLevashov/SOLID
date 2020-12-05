using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.MessageMiddleware
{
    // Класс для работы с сервисами
    // Для получения зависимостей здесь используется метод InvokeAsync, в котором передаются две зависимости IWorking и WorkService
    interface IMessage
    {
        void MakeMessage();
    }
}
