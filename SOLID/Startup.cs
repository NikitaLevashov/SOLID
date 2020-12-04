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
            // �������� ������������
            // �������� ����������� ������ Tester �� IWork (Open Closed Principle)
            services.AddTransient<IWork, Tester>();
            services.AddSingleton<Open_Closed_Principle.WorkService>();

            // �������� ����������� ������ MiddleEmployee �� IWorking (Liskov Substitution Principle)
            services.AddSingleton<IWorking, MiddleEmployee>();
            services.AddSingleton<Liskov_Substitution_Principle.WorkService>();


        }
        public void Configure(IApplicationBuilder app) 
        {
            //WorkMiddleware ������������ � �������� ��������� ������� (Open Closed Principle)
            //app.UseMiddleware<Open_Closed_Principle.WorkMiddleware>();

            //WorkMiddleware ������������ � �������� ��������� ������� (Liskov Substitution Principle)
            app.UseMiddleware<Liskov_Substitution_Principle.WorkMiddleware>();
        }
    }
}
