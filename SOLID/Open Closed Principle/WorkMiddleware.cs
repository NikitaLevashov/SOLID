using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    // Класс для работы с сервисами
    // Для получения зависимостей здесь используется метод InvokeAsync, в котором передаются две зависимости IWork и WorkService
    public class WorkMiddleware
    {
        private readonly RequestDelegate _next;
        public WorkMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, IWork work, WorkService workService)
        {
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($"{work.Work()}");
           
        }
    }
}
