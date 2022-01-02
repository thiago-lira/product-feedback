using System.Threading.Tasks;
using Core.Models;

namespace Core.Repositories
{
    public interface IUserRepository
    {
        Task SaveAsync(User user);
        Task<User> FindAsync(int id);
    }
}
