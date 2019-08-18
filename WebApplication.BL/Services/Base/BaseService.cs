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
            await _repository.Add(entity);

            entity = await _repository.Get(entity.Id);
            var modelResult = _dataAdapter.Parse<TEntity, TModel>(entity);

            return modelResult;
        }

        public virtual async Task<List<TModel>> GetAll()
        {
            var entities = await _repository.GetAll();
            return _dataAdapter.Parse<TEntity, TModel>(entities).ToList();
        }

        public virtual async Task<TModel> Get(TKey id)
        {
            var entity = await _repository.Get(id);
            return _dataAdapter.Parse<TEntity, TModel>(entity);
        }

        public virtual async Task Remove(TKey id)
        {
            await _repository.Remove(id);
        }

        public virtual async Task<TModel> Update(TKey id, TModelToAdd value)
        {
            var entity = _dataAdapter.Parse<TModelToAdd, TEntity>(value);
            await _repository.Put(id, entity);

            entity = await _repository.Get(entity.Id);

            return _dataAdapter.Parse<TEntity, TModel>(entity);
        }
    }
}
