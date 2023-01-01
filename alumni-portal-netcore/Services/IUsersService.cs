using AlumniPortal.Entities;

namespace AlumniPortal.Services
{
    public interface IUsersService
    {
        Task<List<AppUser>> GetUsersAsync();
    }
}
