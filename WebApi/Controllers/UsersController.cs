using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUsers _userService;
        public UsersController(IUsers userService)
        {
            this._userService = userService;
        }
        
        // GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<Users>> GetUsers()
        {
            return await _userService.getAllUsers();
        }

        // GET: api/users/3
        [HttpGet("{id}")]
        public async Task<Users> GetUser(int id)
        {
            var user = await _userService.getUserById(id);
            return user;
        }

    }
}
