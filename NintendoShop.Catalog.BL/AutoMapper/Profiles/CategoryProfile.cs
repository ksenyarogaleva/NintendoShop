using AutoMapper;
using NintendoShop.Catalog.BLL.DTOs.Category;
using NintendoShop.Catalog.DAL.Models;

namespace NintendoShop.Catalog.BLL.AutoMapper.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>();

            CreateMap<CreateCategoryDto, Category>();
        }
    }
}
