using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication.Core.Interfaces
{
    public interface IBaseService<TModelToAdd, TModel, TEntity, TKey>
        where TModelToAdd : class, IBaseModel<TKey>
        where TModel : class, IBaseModel<TKey>
        where TEntity : class, IBaseEntity<TKey>
        where TKey : IEquatable<TKey>, IComparable<TKey>
    {
        Task<List<TModel>> GetAll();

        Task<TModel> Get(TKey id);

        Task<TModel> AddAsync(TModelToAdd model);

        Task<TModel> Update(TKey id, TModelToAdd model);

        Task Remove(TKey id);
    }
}
