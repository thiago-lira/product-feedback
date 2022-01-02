using System.Threading.Tasks;
using Core.Models;

namespace Core.Repositories
{
    public interface ICategoryRepository
    {
        Task SaveAsync(Category category);
    }
}
