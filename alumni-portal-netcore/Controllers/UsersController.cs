using AlumniPortal.Entities;
using AlumniPortal.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlumniPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController: ControllerBase
    {
        private UsersService _usersService;

        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _usersService.GetUsersAsync();;
        }
    }
}
