using NintendoShop.Catalog.BLL.DTOs.Category;

namespace NintendoShop.Catalog.BLL.DTOs.GameProduct
{
    public class GameProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public ICollection<string> Images { get; set; }
        public ICollection<CategoryDto> Categories { get; set; }
    }
}
