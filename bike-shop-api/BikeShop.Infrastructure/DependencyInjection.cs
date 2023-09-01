using BikeShop.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Infrastructure
{
    public static class DependencyInjection
    {
        private static IConfiguration _configuration;

        public static void AddInfrastructure(this IServiceCollection services , IConfiguration conf)
        {
            _configuration = conf;
            services.AddDbContext<BikeShopDBContext>(options =>
            {
                options.UseSqlServer(_configuration.GetSection("Database:ConectionString").Value);
            });
        }
    }

}
