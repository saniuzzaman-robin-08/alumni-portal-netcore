using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AlumniPortal.Entities
{
    [BsonIgnoreExtraElements]
    public class AppUser
    {
        [BsonGuidRepresentation(GuidRepresentation.Standard)]
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? Birthday { get; set; }
    }
}
