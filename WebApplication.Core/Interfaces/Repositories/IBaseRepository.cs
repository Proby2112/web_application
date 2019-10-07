using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication.Core.Interfaces
{
    public interface IBaseRepository<TEntity, TKey>
        where TEntity : class, IBaseEntity<TKey>
        where TKey : IEquatable<TKey>, IComparable<TKey>
    {
        string TableName { get; }

        Task<TEntity> GetAsync(TKey id);
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task AddAsync(TEntity item);
        Task RemoveAsync(TEntity entity);
        Task RemoveAsync(TKey id);

        Task PutAsync(TKey id, TEntity item);

    }
}
