using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SOLID.Dependency_Inversion_Principle;
using SOLID.Liskov_Substitution_Principle;
using SOLID.Open_Closed_Principle;
using SOLID.MessageMiddleware;

namespace SOLID
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //// ненужное закомментить
            //// передаем зависимость класса Tester от IWork (Open Closed Principle)
            services.AddTransient<IWork, Tester>();
            services.AddSingleton<Open_Closed_Principle.WorkService>();

            // передаем зависимость класса MiddleEmployee от IWorking (Liskov Substitution Principle)
            services.AddSingleton<IWorking, MiddleEmployee>();
            services.AddSingleton<Liskov_Substitution_Principle.WorkService>();

            //// передаем зависимость класса Viber от IMessage (Dependency Inversion Principle)
            services.AddScoped<IMessenger, Viber>();
            services.AddScoped<MessageService>();


        }
        public void Configure(IApplicationBuilder app) 
        {
            //WorkMiddleware встраивается в конвейер обработки запроса (Open Closed Principle)
            app.UseMiddleware<Open_Closed_Principle.WorkMiddleware>();

            //MessageMiddleware встраивается в конвейер обработки запроса (Liskov Substitution Principle)
            app.UseMiddleware<Liskov_Substitution_Principle.MessageMiddleware>();

            //MessageMiddlewareProect встраивается в конвейер обработки запроса (Dependency Inversion Principle)
            app.UseMiddleware<MessageMiddlewareProect>();
        }
    }
}
