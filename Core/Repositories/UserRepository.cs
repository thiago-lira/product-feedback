using System.Threading.Tasks;
using Core.Data;
using Core.Models;

namespace Core.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
        }

        public async Task<User> FindAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task SaveAsync(User user)
        {
            await dbSet.AddAsync(user);
            await context.SaveChangesAsync();
        }
    }
}
