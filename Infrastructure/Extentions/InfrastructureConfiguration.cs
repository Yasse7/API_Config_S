using Domain.Repositories;
using Infrastructure.Students.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extentions
{
    public static class InfrastructureConfiguration
    {
        public static IServiceCollection AddInfrastructureConfiguration(this IServiceCollection services)
        {
            //AddSingleton pour utilisé un seul objet
            //probleme de meme action dans la meme minute(just exemple)
            services.AddSingleton <IStudentrepository,StudentRepository>();
            return services;
        }
    }
}
