
using System.Collections.Generic;

namespace WebApplication.Core.Models
{
    public abstract class ResourceBaseViewModel : BaseModel<string>
    {
        public string CreatingDigitalImageId { get; set; }

    }
    public class ResourceGetFullViewModel : ResourceBaseViewModel
    {
        public CreatingDigitalImageGetMinViewModel CreatingDigitalImage { get; set; }
        public List<PrimarySourceGetMinViewModel> PrimarySources { get; set; }
        public List<SecondarySourceGetMinViewModel> SecondarySources { get; set; }
    }
    public class ResourceGetMinViewModel : ResourceBaseViewModel
    {
    }
    public class ResourceAddViewModel : ResourceBaseViewModel
    {
    }

}
