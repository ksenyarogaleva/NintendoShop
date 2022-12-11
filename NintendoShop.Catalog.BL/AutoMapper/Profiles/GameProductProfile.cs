using AutoMapper;
using NintendoShop.Catalog.BLL.DTOs.GameProduct;
using NintendoShop.Catalog.DAL.Models;

namespace NintendoShop.Catalog.BLL.AutoMapper.Profiles
{
    public class GameProductProfile : Profile
    {
        public GameProductProfile()
        {
            CreateMap<GameProduct, GameProductDto>();

            CreateMap<CreateGameProductDto, GameProduct>()
                .ForMember(x => x.Categories, s => s.Ignore())
                .ForMember(x => x.Images, s => s.Ignore());

            CreateMap<UpdateGameProductDto, GameProduct>()
                .ForMember(x => x.Categories, s => s.Ignore())
                .ForMember(x => x.Images, s => s.Ignore());

        }
    }
}
