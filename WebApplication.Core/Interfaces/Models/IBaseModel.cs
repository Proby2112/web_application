using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Interfaces
{
    public interface IBaseModel<T> where T : IEquatable<T>, IComparable<T>
    {
        T Id { get; set; }
        DateTime? Created { get; set; }
    }
}
