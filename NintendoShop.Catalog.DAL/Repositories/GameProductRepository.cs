using MongoDB.Driver;
using NintendoShop.Catalog.DAL.Interfaces;
using NintendoShop.Catalog.DAL.Models;

namespace NintendoShop.Catalog.DAL.Repositories
{
    internal class GameProductRepository : IGameProductRepository
    {
        private ICatalogContext _catalogContext;
        public GameProductRepository(ICatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }

        public async Task<IEnumerable<GameProduct>> GetAllAsync()
        {
            return await _catalogContext.GameProducts.Find("{}").ToListAsync();
        }

        public async Task<GameProduct> GetByIdAsync(string id)
        {
            return await _catalogContext.GameProducts.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(GameProduct entity)
        {
            await _catalogContext.GameProducts.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(GameProduct entity)
        {
            var filter = Builders<GameProduct>.Filter.Eq(x => x.Id, entity.Id);

            await _catalogContext.GameProducts.ReplaceOneAsync(filter, entity);
        }

        public async Task DeleteAsync(string id)
        {
            var filter = Builders<GameProduct>.Filter.Eq(x => x.Id, id);

            await _catalogContext.GameProducts.DeleteOneAsync(filter);
        }
    }
}
