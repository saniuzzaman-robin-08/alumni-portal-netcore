using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CoUAlumniPortal.Entities
{
    [BsonIgnoreExtraElements]
    public class AppUser
    {
        [BsonId]
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? Birthday { get; set; }
    }
}
