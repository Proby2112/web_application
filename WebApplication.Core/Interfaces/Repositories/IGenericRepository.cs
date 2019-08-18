using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace WebApplication.Core.Interfaces
{
    public interface IGenericRepository<TEntity, TKey>
            where TEntity : class, IBaseEntity<TKey>
            where TKey : IEquatable<TKey>, IComparable<TKey>
    {
        DbSet<TEntity> Table { get; }

        TEntity Get(TKey id);
        IEnumerable<TEntity> Get();

        int Insert(IEnumerable<TEntity> entities);
        int Insert(TEntity entity);

        int Update(IEnumerable<TEntity> entities);
        int Update(TEntity entity);

        int Delete(IEnumerable<TEntity> entities);
        int Delete(TEntity entity);

        int SaveChanges();
    }
}
