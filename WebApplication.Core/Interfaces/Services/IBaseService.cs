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
        Task<List<TModel>> GetAllAsync();

        Task<TModel> GetAsync(TKey id);

        Task<TModel> AddAsync(TModelToAdd model);

        Task<TModel> UpdateAsync(TKey id, TModelToAdd model);

        Task RemoveAsync(TKey id);
    }
}
