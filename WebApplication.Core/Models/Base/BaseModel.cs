using Newtonsoft.Json;
using System;
using WebApplication.Core.Interfaces;

namespace WebApplication.Core.Models
{
    public class BaseModel<TKey> : IBaseModel<TKey> where TKey : IEquatable<TKey>, IComparable<TKey>
    {
        [JsonProperty("id")] public TKey Id { get; set; }
        [JsonProperty("cteated_time")] public DateTime? Created { get; set; }
    }
}
