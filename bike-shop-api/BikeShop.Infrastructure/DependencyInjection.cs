using EasyCommerceShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BikeShop.Infrastructure
{
    public static class DependencyInjection
    {

        public static void AddInfrastructure(this IServiceCollection services, IConfiguration conf)
        {
            services.AddDbContext<BikeShopDBContext>(options =>
            {
                options.UseSqlServer(conf.GetSection("Database:ConectionString").Value);
            });
        }
    }

}
