using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet_api.Models
{
    [BsonIgnoreExtraElements]
    public class Location
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } // MongoDB's _id field as string

        [BsonElement("location_id")]
        public string? LocationId { get; set; }

        [BsonElement("location_name")]
        public string? LocationName { get; set; }

        [BsonElement("createdAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updatedAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime UpdatedAt { get; set; }
    }
}
