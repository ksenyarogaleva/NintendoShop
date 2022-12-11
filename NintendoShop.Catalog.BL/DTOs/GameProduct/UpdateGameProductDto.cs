namespace NintendoShop.Catalog.BLL.DTOs.GameProduct
{
    public class UpdateGameProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public ICollection<string> Categories { get; set; }
    }
}
