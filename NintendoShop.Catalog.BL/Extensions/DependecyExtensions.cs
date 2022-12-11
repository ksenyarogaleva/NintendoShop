using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NintendoShop.Catalog.BLL.AutoMapper;
using NintendoShop.Catalog.BLL.Interfaces;
using NintendoShop.Catalog.BLL.Services;
using NintendoShop.Catalog.DAL.Extensions;

namespace NintendoShop.Catalog.BLL.Extensions
{
    public static class DependecyExtensions
    {
        public static void ConfigureBLL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabaseSettings(configuration);

            var mapper = AutoMapperConfiguration.GetMapperConfiguration();
            services.AddSingleton(mapper);

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IGameProductService, GameProductService>();
        }
    }
}
