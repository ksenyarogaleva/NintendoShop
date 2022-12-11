using NintendoShop.Catalog.BLL.DTOs.GameProduct;

namespace NintendoShop.Catalog.BLL.Interfaces
{
    public interface IGameProductService
    {
        Task<GameProductDto> GetByIdAsync(string id);
        Task<List<GameProductDto>> GetAllAsync();
        Task CreateAsync(CreateGameProductDto gameProductDto);
        Task UpdateAsync(UpdateGameProductDto gameProductDto);
        Task DeleteAsync(string id);
    }
}
