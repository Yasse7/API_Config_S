using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extentions
{
    public static class ApplicationExtention
    {
        public static IServiceCollection AddApplicationConfiguration(this IServiceCollection services)
        {
            //services.AddMediatR(typeof(ApplicationExtention).Assembly);
            //services.AddScoped<GetStuentsQuery,GetStudentQueryHandler >
            return services;

        }
    }
}
