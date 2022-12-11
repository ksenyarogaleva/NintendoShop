using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NintendoShop.Catalog.DAL.Models
{
    public class GameProduct
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public ICollection<string> Images { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
