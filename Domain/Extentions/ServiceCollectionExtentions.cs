using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static void AddSqlContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ConstrutoraContext>(x => x.UseSqlServer(config.GetConnectionString("Construtora")));
        }
        public static void AddUnitOfWork(this IServiceCollection services)
        {
            
        }
        public static void AddServices(this IServiceCollection services)
        {
            
        }
    }
}
