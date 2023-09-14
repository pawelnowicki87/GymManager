using GymManager.Application.Common.Interfaces;
using GymManager.Infrastructure.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString)
            .EnableSensitiveDataLogging());
               

            return services;
        }
        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            //
            return app;
        }
    }
}
