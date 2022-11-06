using CoUAlumniPortal.Entities;
using CoUAlumniPortal.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoUAlumniPortal.Controllers
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
