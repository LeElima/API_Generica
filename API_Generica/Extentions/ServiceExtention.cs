using Domain.Extentions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Generica.Extentions
{
    public static class ServiceExtention
    {
        public static void ConfigureSQLContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddSqlContext(config);
        }
        public static void ConfigureUnitOfWork(this IServiceCollection services)
        {
            services.AddUnitOfWork();
            services.AddServices();
        }
    }
}
