using System.Collections.Generic;

namespace WebApplication.Core.Entities
{
    public class CreatingDigitalImage : BaseEntity<string>
    {
        public string EvidenceId { get; set; }

        public virtual Evidence Evidence { get; set; }
        public virtual ICollection<GraphicProduct> GraphicProducts { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
