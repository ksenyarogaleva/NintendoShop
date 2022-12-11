using MongoDB.Driver;
using NintendoShop.Catalog.DAL.Interfaces;
using NintendoShop.Catalog.DAL.Models;

namespace NintendoShop.Catalog.DAL.Repositories
{
    internal class CategoryRepository : ICategoryRepository
    {
        private ICatalogContext _catalogContext;
        public CategoryRepository(ICatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _catalogContext.Categories.Find("{}").ToListAsync();
        }

        public async Task<Category> GetByIdAsync(string id)
        {
            return await _catalogContext.Categories.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(Category entity)
        {
            await _catalogContext.Categories.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(Category entity)
        {
            var filter = Builders<Category>.Filter.Eq(x => x.Id, entity.Id);

            await _catalogContext.Categories.ReplaceOneAsync(filter, entity);
        }
        public async Task DeleteAsync(string id)
        {
            var filter = Builders<Category>.Filter.Eq(x => x.Id, id);

            await _catalogContext.Categories.DeleteOneAsync(filter);
        }
    }
}
