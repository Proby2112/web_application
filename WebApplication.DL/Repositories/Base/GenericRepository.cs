using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Core.Interfaces;
using WebApplication.DL;

namespace WebApplication.DL.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey>
            where TEntity : class, IBaseEntity<TKey>
            where TKey : IEquatable<TKey>, IComparable<TKey>
    {
        AppDbContext _context;
        DbSet<TEntity> _entities;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        protected virtual DbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<TEntity>();
                return _entities;
            }
        }
        public DbSet<TEntity> Table => Entities;

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        // ======== CREATE ========
        public virtual int Insert(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }

            return _context.SaveChanges();
        }

        // ======== READ ========
        public virtual IEnumerable<TEntity> Get()
        {
            return Entities;
        }

        public virtual TEntity Get(TKey id)
        {
            return Entities.Find(id);
        }

        // ======== UPDATE ========
        public virtual int Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }

            return _context.SaveChanges();
        }

        // ======== DELETE ========
        public virtual int Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }

            return _context.SaveChanges();
        }


        public virtual int Insert(TEntity entity) => Insert(new List<TEntity>() { entity });
        public virtual int Update(TEntity entity) => Update(new List<TEntity>() { entity });
        public virtual int Delete(TEntity entity) => Delete(new List<TEntity>() { entity });
    }
}
