using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet_api.Models
{
    [BsonIgnoreExtraElements]
    public class Room
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } // MongoDB's _id field as string

        [BsonElement("room_id")]
        public int RoomId { get; set; }

        [BsonElement("room_name")]
        public string? RoomName { get; set; }

        [BsonElement("room_size")]
        public int RoomSize { get; set; }

        [BsonElement("room_status")]
        public int RoomStatus { get; set; }

        [BsonElement("location_id")]
        public string? LocationId { get; set; }

        [BsonElement("room_stack_order")]
        public int RoomStackOrder { get; set; }

        [BsonElement("room_catering")]
        public int RoomCatering { get; set; }
    }
}
