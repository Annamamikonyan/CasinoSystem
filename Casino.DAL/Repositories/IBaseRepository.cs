using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Casino.DAL.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        T GetById(object id);
        Task<T> FindByConditionAsync(T entity);
        Task<IReadOnlyList<T>> ListAllAsync();
        IQueryable<T> GetAll();
        Task<T> AddAsync(T entity);
        T Add(T entity);
        void Update(T entity);
        Task DeleteAsync(T entity);
        Task SaveChangesAsync();
        void SaveChanges();
        void DeleteRange(List<T> entity);
        void AddRange(List<T> entities, bool saveChanges = true);
        void RemoveByCondition(Expression<Func<T, bool>> predicate, int takeCount);
        void ChangeState(T entity, EntityState state);

    }
}
