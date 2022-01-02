using System.Threading.Tasks;
using Core.Models;

namespace Core.Repositories
{
    public interface ICommentRepository
    {
        Task SaveAsync(Comment comment);
    }
}
