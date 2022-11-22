using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class UserServices : IUsers
    {
        private DataContext dbContext;

        public UserServices()
        {
            this.dbContext = new DataContext();
        }
        public async Task<List<Users>> getAllUsers()
        {
            var users = await dbContext.Users.ToListAsync();
            return users;
        }

        public async Task<Users> getUserById(int id)
        {
            var user = await dbContext.Users.FindAsync(id);
            return user;
        }
    }
}
