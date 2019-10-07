using Newtonsoft.Json;
using System;
using WebApplication.Core.Interfaces;

namespace WebApplication.Core.Models
{
    public class BaseModel<TKey> : IBaseModel<TKey> where TKey : IEquatable<TKey>, IComparable<TKey>
    {
        public TKey Id { get; set; }
        public DateTime? Created { get; set; }
    }
}
