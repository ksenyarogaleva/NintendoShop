using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NintendoShop.Catalog.DAL.Configuration;
using NintendoShop.Catalog.DAL.Interfaces;
using NintendoShop.Catalog.DAL.Repositories;

namespace NintendoShop.Catalog.DAL.Extensions
{
    public static class DependecyExtensions
    {
        public static void AddDatabaseSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var catalogDbConfig = new CatalogDatabaseSettings();
            configuration.Bind(nameof(CatalogDatabaseSettings), catalogDbConfig);

            services.AddSingleton(catalogDbConfig);
            services.AddScoped<ICatalogContext, CatalogContext>();

            services.AddScoped<IGameProductRepository, GameProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
