using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution_Principle
{
    // Класс для работы с сервисами
    // Для получения зависимостей здесь используется метод InvokeAsync, в котором передаются две зависимости IWorking и WorkService
    public class WorkMiddleware
    {
        private readonly RequestDelegate _next;
        public WorkMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, IWorking work, WorkService workService)
        {
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($"{work.GetWorkInfo(13)}");
           
        }
    }
}
