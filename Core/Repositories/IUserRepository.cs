using System.Threading.Tasks;
using Core.DTOs;

namespace Core.Repositories
{
    public interface IUserRepository
    {
        Task SaveAsync(UserCreateDTO userCreateDTO);
    }
}
