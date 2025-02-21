using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet_api.Models
{
    // Ignore extra elements that are not mapped to the class
    [BsonIgnoreExtraElements] 
    public class Booking
    {
        [BsonId]
        public ObjectId Id { get; set; } // MongoDB's _id field

        [BsonElement("meeting_id")]
        public int? MeetingId { get; set; } // Nullable if necessary

        [BsonElement("meeting_title")]
        public string? MeetingTitle { get; set; }

        [BsonElement("meeting_datetime_start")]
        public DateTime? MeetingDatetimeStart { get; set; }

        [BsonElement("meeting_datetime_end")]
        public DateTime? MeetingDatetimeEnd { get; set; }

        [BsonElement("meeting_description")]
        public string? MeetingDescription { get; set; }

        [BsonElement("room_id")]
        public int? RoomId { get; set; }

        [BsonElement("room_name")]
        public string? RoomName { get; set; }

        [BsonElement("meeting_participant_count")]
        public int? MeetingParticipantCount { get; set; }

        [BsonElement("meeting_department_name")]
        public string? MeetingDepartmentName { get; set; }

        [BsonElement("meeting_reserver_name")]
        public string? MeetingReserverName { get; set; }

        [BsonElement("meeting_reserver_phone")]
        public string? MeetingReserverPhone { get; set; }

        [BsonElement("meeting_room_type")]
        public string? MeetingRoomType { get; set; }

        [BsonElement("meeting_catering_detail")]
        public string? MeetingCateringDetail { get; set; }

        [BsonElement("meeting_conference_detail")]
        public string? MeetingConferenceDetail { get; set; }

        [BsonElement("meeting_conference_app")]
        public string? MeetingConferenceApp { get; set; }

        [BsonElement("meeting_video_id")]
        public string? MeetingVideoId { get; set; }

        [BsonElement("meeting_update_timestamp")]
        public DateTime? MeetingUpdateTimestamp { get; set; }

        [BsonElement("meeting_update_employee_id")]
        public string? MeetingUpdateEmployeeId { get; set; }

        [BsonElement("meeting_insert_timestamp")]
        public DateTime? MeetingInsertTimestamp { get; set; }

        [BsonElement("meeting_insert_employee_id")]
        public string? MeetingInsertEmployeeId { get; set; }
    }
}
