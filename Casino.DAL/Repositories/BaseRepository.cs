using Casino.DAL.EntityModels;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Casino.DAL.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly CasinoContext  _dbContext;

        public BaseRepository(CasinoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
        public virtual T GetById(object id)
        {
            return _dbContext.Set<T>().Find(id);
        }
        public virtual async Task<T> FindByConditionAsync(T entity)
        {
            return await _dbContext.Set<T>().FindAsync(entity);
        }
        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
        public virtual IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        public void DeleteRange(List<T> entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);
            _dbContext.SaveChanges();
        }
        public void AddRange(List<T> entities, bool saveChanges = true)
        {
            _dbContext.Set<T>().AddRange(entities);
            if (saveChanges)
            {
                _dbContext.SaveChanges();
            }
        }
        public void RemoveByCondition(Expression<Func<T, bool>> predicate, int takeCount)
        {
            _dbContext.Set<T>().Where(predicate)
            .Take(takeCount)
             .ExecuteDelete();
        }
        public void ChangeState(T entity, EntityState state)
        {
            _dbContext.Entry(entity).State = state;
        }
    }
}
