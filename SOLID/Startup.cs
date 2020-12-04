using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SOLID.Open_Closed_Principle;
using SOLID.Services;

namespace SOLID
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // передаем зависимость класса Tester от IWork
            services.AddTransient<IWork, Tester>(); 
            services.AddSingleton<WorkService>();
        }
        public void Configure(IApplicationBuilder app) //WorkMiddleware встраивается в конвейер обработки запроса
        {
            app.UseMiddleware<WorkMiddleware>();
        }
    }
}
