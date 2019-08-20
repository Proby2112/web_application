using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Entities
{
    public class SecondarySource : BaseEntity<string>
    {
        public string ResourceId { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
