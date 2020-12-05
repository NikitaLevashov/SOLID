using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion_Principle
{
    // Класс для работы с сервисами
    // Для получения зависимостей здесь используется метод InvokeAsync, в котором передаются две зависимости IMessenger и MessageService
    public class MessageMiddlewareProect
    {
        private readonly RequestDelegate _next;
        public MessageMiddlewareProect(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, IMessenger message)
        {
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($"{message.SendMessage("Hello World")}");
           
        }
    }
}
