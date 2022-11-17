using CoUAlumniPortal.Entities;
using CoUAlumniPortal.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CoUAlumniPortal.Services
{
    public class UsersService : IUsersService
    {
        private IMongoCollection<AppUser> _users;

        public UsersService(IOptions<UsersDatabaseSettings> usersDatabaseSettings)
        {
            var mongoClient = new MongoClient(
            usersDatabaseSettings.Value.ConnectionString);

            var database = mongoClient.GetDatabase(usersDatabaseSettings.Value.DatabaseName);
            _users = database.GetCollection<AppUser>(usersDatabaseSettings.Value.UsersCollectionName);
        }

        public async Task<List<AppUser>> GetUsersAsync()
        {
            return await _users.Find(_ => true).ToListAsync();
        }
    }
}
