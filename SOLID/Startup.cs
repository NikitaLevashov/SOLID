using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SOLID.Liskov_Substitution_Principle;
using SOLID.Open_Closed_Principle;

namespace SOLID
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // ненужное закомментить
            // передаем зависимость класса Tester от IWork (Open Closed Principle)
            services.AddTransient<IWork, Tester>();
            services.AddSingleton<Open_Closed_Principle.WorkService>();

            // передаем зависимость класса MiddleEmployee от IWorking (Liskov Substitution Principle)
            services.AddSingleton<IWorking, MiddleEmployee>();
            services.AddSingleton<Liskov_Substitution_Principle.WorkService>();


        }
        public void Configure(IApplicationBuilder app) 
        {
            //WorkMiddleware встраивается в конвейер обработки запроса (Open Closed Principle)
            //app.UseMiddleware<Open_Closed_Principle.WorkMiddleware>();

            //WorkMiddleware встраивается в конвейер обработки запроса (Liskov Substitution Principle)
            app.UseMiddleware<Liskov_Substitution_Principle.WorkMiddleware>();
        }
    }
}
