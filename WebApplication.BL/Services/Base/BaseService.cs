using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Core.Interfaces;

namespace WebApplication.BL.Services
{
    public abstract class BaseService<TModelToAdd, TModel, TEntity, TKey> : IBaseService<TModelToAdd, TModel, TEntity, TKey>
        where TModelToAdd : class, IBaseModel<TKey>
        where TModel : class, IBaseModel<TKey>
        where TEntity : class, IBaseEntity<TKey>
        where TKey : IEquatable<TKey>, IComparable<TKey>
    {
        protected readonly IBaseRepository<TEntity, TKey> _repository;
        protected readonly IDataAdapter _dataAdapter;

        public BaseService(IBaseRepository<TEntity, TKey> repository, IDataAdapter dataAdapter)
        {
            _repository = repository;
            _dataAdapter = dataAdapter;
        }


        public virtual async Task<TModel> AddAsync(TModelToAdd model)
        {
            var entity = _dataAdapter.Parse<TModelToAdd, TEntity>(model);
            await _repository.AddAsync(entity);

            entity = await _repository.GetAsync(entity.Id);
            var modelResult = _dataAdapter.Parse<TEntity, TModel>(entity);

            return modelResult;
        }

        public virtual async Task<List<TModel>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _dataAdapter.Parse<TEntity, TModel>(entities).ToList();
        }

        public virtual async Task<TModel> GetAsync(TKey id)
        {
            var entity = await _repository.GetAsync(id);
            return _dataAdapter.Parse<TEntity, TModel>(entity);
        }

        public virtual async Task RemoveAsync(TKey id)
        {
            await _repository.RemoveAsync(id);
        }

        public virtual async Task<TModel> UpdateAsync(TKey id, TModelToAdd value)
        {
            var entity = _dataAdapter.Parse<TModelToAdd, TEntity>(value);
            await _repository.PutAsync(id, entity);

            entity = await _repository.GetAsync(entity.Id);

            return _dataAdapter.Parse<TEntity, TModel>(entity);
        }
    }
}
