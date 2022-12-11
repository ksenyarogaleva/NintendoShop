using AutoMapper;
using NintendoShop.Catalog.BLL.AutoMapper.Profiles;

namespace NintendoShop.Catalog.BLL.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static IMapper GetMapperConfiguration()
        {
            var config = new MapperConfiguration(x =>
            {
                x.AddProfile(new CategoryProfile());
                x.AddProfile(new GameProductProfile());
            });

            return config.CreateMapper();
        }
    }
}
