using Core.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories
{
    public class RepositoryBase<T> where T : ModelBase
    {
        protected readonly ApplicationContext context;
        protected readonly DbSet<T> dbSet;

        public RepositoryBase(ApplicationContext applicationContext)
        {
            context = applicationContext;
            dbSet = applicationContext.Set<T>();
        }
    }
}
