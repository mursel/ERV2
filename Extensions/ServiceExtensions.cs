using Entities;
using Logger;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERV2.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureLog(this IServiceCollection services)
        {
            services.AddSingleton<ILogService, LogService>();
        }

        public static void ConfigureMySql(this IServiceCollection services, IConfiguration configuration)
        {
            var cnString = configuration["mySqlcn:connectionString"];
            services.AddDbContext<MainContext>(o => o.UseMySql(cnString));
        }

        public static void ConfigureUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }
    }
}
