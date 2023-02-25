using System.Threading.Tasks;

namespace need.Models.Abstract
{
    public interface IBaseRepository<T>
    {
        Task Create(T entity);
        Task<T> Get(int id);
        Task<IEnumerable<T>> Select();
        Task<bool> Delete(int id);
        Task SaveChangesAsync();
    }
}
