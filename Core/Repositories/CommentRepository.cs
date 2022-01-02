using System.Threading.Tasks;
using Core.Data;
using Core.Models;

namespace Core.Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public async Task SaveAsync(Comment comment)
        {
            await dbSet.AddAsync(comment);
            await context.SaveChangesAsync();
        }
    }
}
