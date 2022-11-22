using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IUsers
    {
        Task<List<Users>> getAllUsers();
        Task<Users> getUserById(int id);
    }
}
