using System;

namespace WebApplication.Core.Interfaces
{
    public interface IBaseEntity<T> where T : IEquatable<T>, IComparable<T>
    {
        T Id { get; set; }
        DateTime Created { get; set; }

        void SetId();
    }
}
