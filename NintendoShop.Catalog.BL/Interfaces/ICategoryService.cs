using NintendoShop.Catalog.BLL.DTOs.Category;

namespace NintendoShop.Catalog.BLL.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryDto> GetByIdAsync(string id);
        Task<List<CategoryDto>> GetAllAsync();
        Task CreateAsync(CreateCategoryDto categoryDto);
        Task UpdateAsync(CategoryDto categoryDto);
        Task DeleteAsync(string id);
    }
}
