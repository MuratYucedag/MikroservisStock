using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MikroservisStock.Catalog.Entites
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
