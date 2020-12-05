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
            //// �������� ������������
            //// �������� ����������� ������ Tester �� IWork (Open Closed Principle)
            services.AddTransient<IWork, Tester>();
            services.AddSingleton<Open_Closed_Principle.WorkService>();

            // �������� ����������� ������ MiddleEmployee �� IWorking (Liskov Substitution Principle)
            services.AddSingleton<IWorking, MiddleEmployee>();
            services.AddSingleton<Liskov_Substitution_Principle.WorkService>();

            //// �������� ����������� ������ Viber �� IMessage (Dependency Inversion Principle)
            services.AddScoped<IMessenger, Viber>();
            services.AddScoped<MessageService>();


        }
        public void Configure(IApplicationBuilder app) 
        {
            //WorkMiddleware ������������ � �������� ��������� ������� (Open Closed Principle)
            app.UseMiddleware<Open_Closed_Principle.WorkMiddleware>();

            //MessageMiddleware ������������ � �������� ��������� ������� (Liskov Substitution Principle)
            app.UseMiddleware<Liskov_Substitution_Principle.MessageMiddleware>();

            //MessageMiddlewareProect ������������ � �������� ��������� ������� (Dependency Inversion Principle)
            app.UseMiddleware<MessageMiddlewareProect>();
        }
    }
}
