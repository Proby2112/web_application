using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApplication.Core.Models
{
    public abstract class CreatingDigitalImageBaseViewModel : BaseModel<string>
    {
        public string EvidenceId { get; set; }
    }
    public class CreatingDigitalImageGetFullViewModel : CreatingDigitalImageBaseViewModel
    {
        public EvidenceGetMinViewModel Evidence { get; set; }
        public List<GraphicProductGetMinViewModel> GraphicProducts { get; set; }
        public List<ResourceGetMinViewModel> Resources { get; set; }
    }
    public class CreatingDigitalImageGetMinViewModel : CreatingDigitalImageBaseViewModel
    {
    }

}
