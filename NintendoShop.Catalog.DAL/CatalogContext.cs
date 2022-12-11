using MongoDB.Driver;
using NintendoShop.Catalog.DAL.Configuration;
using NintendoShop.Catalog.DAL.Interfaces;
using NintendoShop.Catalog.DAL.Models;

namespace NintendoShop.Catalog.DAL
{
    internal class CatalogContext : ICatalogContext
    {
        public CatalogContext(CatalogDatabaseSettings settings)
        {
            var mongoClient = new MongoClient(settings.ConnectionString);
            var catalogDatabase = mongoClient.GetDatabase(settings.DatabaseName);

            GameProducts = catalogDatabase.GetCollection<GameProduct>(nameof(GameProducts));
            Categories = catalogDatabase.GetCollection<Category>(nameof(Categories));
        }
        public IMongoCollection<GameProduct> GameProducts { get; }

        public IMongoCollection<Category> Categories { get; }
    }
}