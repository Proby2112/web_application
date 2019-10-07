﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApplication.Core.Interfaces;

namespace WebApplication.DL.Repositories
{
    public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : class, IBaseEntity<TKey>
        where TKey : IEquatable<TKey>, IComparable<TKey>
    {
        protected readonly IGenericRepository<TEntity, TKey> _repository;

        public string TableName => _repository.TableName();

        public BaseRepository(IGenericRepository<TEntity, TKey> repository)
        {
            _repository = repository;
        }

        public virtual Task AddAsync(TEntity item)
        {
            item.SetId();

            _repository.Insert(item);
            return Task.FromResult("Ok");
        }

        public virtual Task<TEntity> GetAsync(TKey id)
        {
            var res = _repository.Get(id);
            return Task.FromResult(res);
        }

        public virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var res = _repository.Get();
            return Task.FromResult(res);
        }

        public virtual Task PutAsync(TKey id, TEntity item)
        {
            _repository.Update(item);
            return Task.FromResult("Ok");
        }

        public virtual Task RemoveAsync(TEntity entity)
        {
            _repository.Delete(entity);
            return Task.FromResult("Ok");
        }

        public Task RemoveAsync(TKey id)
        {
            var entity = _repository.Get(id);

            _repository.Delete(entity);
            return Task.FromResult("Ok");
        }
    }
}
