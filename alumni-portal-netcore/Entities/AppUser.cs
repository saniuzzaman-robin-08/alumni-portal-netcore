using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;

namespace CoUAlumniPortal.Entities
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
