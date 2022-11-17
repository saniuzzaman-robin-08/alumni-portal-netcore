using CoUAlumniPortal.Entities;

namespace CoUAlumniPortal.Services
{
    public interface IUsersService
    {
        Task<List<AppUser>> GetUsersAsync();
    }
}
