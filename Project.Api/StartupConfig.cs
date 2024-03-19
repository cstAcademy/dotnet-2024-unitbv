
using Project.Core.Services;
using Project.Database.Repositories;

namespace Project.Api
{
    public static class StartupConfig
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<TasksService>();           
            services.AddScoped<Tasks2Service>();           
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<TasksRepository>();
        }
    }
}
