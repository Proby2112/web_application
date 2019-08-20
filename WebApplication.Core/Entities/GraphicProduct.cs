using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Core.Entities
{
    public class GraphicProduct : BaseEntity<string>
    {
        public string CreatingDigitalImageId { get; set; }
        public string FinalProductId { get; set; }
        public string ProcessId { get; set; }

        public virtual CreatingDigitalImage CreatingDigitalImage { get; set; }
        public virtual FinalProduct FinalProduct { get; set; }
        public virtual Process Process { get; set; }
    }
}
