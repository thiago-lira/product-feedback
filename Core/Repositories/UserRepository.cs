using System.Threading.Tasks;
using Core.Data;
using Core.DTOs;
using Core.Models;

namespace Core.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
        }

        public async Task SaveAsync(UserCreateDTO userCreateDTO)
        {
            await dbSet.AddAsync(userCreateDTO.ToModel());
            await context.SaveChangesAsync();
        }
    }
}
