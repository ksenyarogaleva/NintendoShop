using MongoDB.Driver;
using NintendoShop.Catalog.DAL.Models;

namespace NintendoShop.Catalog.DAL.Interfaces
{
    internal interface ICatalogContext
    {
        IMongoCollection<GameProduct> GameProducts { get; }
        IMongoCollection<Category> Categories { get; }
    }
}
