using AutoMapper;
using NintendoShop.Catalog.BLL.DTOs.Category;
using NintendoShop.Catalog.BLL.Interfaces;
using NintendoShop.Catalog.DAL.Interfaces;
using NintendoShop.Catalog.DAL.Models;

namespace NintendoShop.Catalog.BLL.Services
{
    internal class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var dbCategories = await _categoryRepository.GetAllAsync();

            return _mapper.Map<List<CategoryDto>>(dbCategories);
        }

        public async Task<CategoryDto> GetByIdAsync(string id)
        {
            var dbCategory = await _categoryRepository.GetByIdAsync(id);

            return _mapper.Map<CategoryDto>(dbCategory);
        }

        public async Task CreateAsync(CreateCategoryDto categoryDto)
        {
            var categoryForCreate = _mapper.Map<Category>(categoryDto);

            await _categoryRepository.CreateAsync(categoryForCreate);
        }

        public async Task UpdateAsync(CategoryDto categoryDto)
        {
            var categoryForUpdate = _mapper.Map<Category>(categoryDto);

            await _categoryRepository.UpdateAsync(categoryForUpdate);
        }

        public async Task DeleteAsync(string id)
        {
            await _categoryRepository.DeleteAsync(id);
        }
    }
}
