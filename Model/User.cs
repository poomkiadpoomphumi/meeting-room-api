using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet_api.Models
{
    [BsonIgnoreExtraElements] 
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } // MongoDB's _id field as string

        [BsonElement("code")]
        public string? Code { get; set; }

        [BsonElement("iname")]
        public string? Iname { get; set; } // Title (e.g., นาย)

        [BsonElement("fname")]
        public string? FirstName { get; set; }

        [BsonElement("lname")]
        public string? LastName { get; set; }

        [BsonElement("emailaddr")]
        public string? Email { get; set; }

        [BsonElement("mobile")]
        public string? Mobile { get; set; }

        [BsonElement("unitabbr")]
        public string? UnitAbbreviation { get; set; }

        [BsonElement("location")]
        public string? Location { get; set; }

        [BsonElement("createdBy")]
        public string? CreatedBy { get; set; }

        [BsonElement("updatedBy")]
        public string? UpdatedBy { get; set; }

        [BsonElement("disable")]
        public bool? Disable { get; set; }

        [BsonElement("createdAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? CreatedAt { get; set; }

        [BsonElement("updatedAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? UpdatedAt { get; set; }
    }
}
