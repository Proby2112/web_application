﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Core.Interfaces;

namespace WebApplication.Core.Entities
{
    public class BaseEntity<TKey> : IBaseEntity<TKey> where TKey : IEquatable<TKey>, IComparable<TKey>
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual TKey Id { get; set; }

        public virtual DateTime Created { get; set; }
        public virtual DateTime Updated { get; set; }

        public BaseEntity()
        {
            Created = DateTime.UtcNow;
            Updated = Created;
        }

        public override int GetHashCode()
        {
            if (Id == null)
                return 0;
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var temp = obj as BaseEntity<TKey>;
            var result = temp != null ? Id.Equals(temp.Id) : false;

            return result;
        }

        public void SetId()
        {
            if (this is IBaseEntity<string>)
                (this as IBaseEntity<string>).Id = Guid.NewGuid().ToString();
        }

        public virtual bool Compare(BaseEntity<TKey> entity)
        {
            return Id.CompareTo(entity.Id) == 0;
        }
    }
}
