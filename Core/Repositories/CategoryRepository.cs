using System.Threading.Tasks;
using Core.Data;
using Core.Models;

namespace Core.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public async Task SaveAsync(Category category)
        {
            await dbSet.AddAsync(category);
            await context.SaveChangesAsync();
        }
    }
}
