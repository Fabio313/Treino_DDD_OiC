using Microsoft.Extensions.DependencyInjection;
using SolutionTraining.CrossCutting.Configuration.Sql;
using SolutionTraining.Domain.Interfaces.v1.Connection;
using SolutionTraining.Domain.Interfaces.v1.Repositories;
using SolutionTraining.Domain.Interfaces.v1.Services;
using SolutionTraining.Infrastructure.Data.Sql.v1.Repositories;
using SolutionTraining.Infrastructure.Service.v1;

namespace SolutionTraining.User.API.Infrastructure.IoC
{
    public static class Bootstrapper
    {
        public static void Inject(IServiceCollection services)
        {
            //Injestão de dependencias 
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IDataBaseConfiguration, SqlDataBaseConfiguration>();
        }
    }
}
