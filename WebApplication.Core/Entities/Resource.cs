using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Entities
{
    public class Resource : BaseEntity<string>
    {
        public string CreatingDigitalImageId { get; set; }

        public virtual CreatingDigitalImage CreatingDigitalImage { get; set; }
        public virtual ICollection<PrimarySource> PrimarySources { get; set; }
        public virtual ICollection<SecondarySource> SecondarySources { get; set; }
    }
}
