using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Entities
{
    public class Evidence : BaseEntity<string>
    {
        public string CreatingDigitalImageId { get; set; }
        public virtual CreatingDigitalImage CreatingDigitalImage { get; set; }
    }
}
