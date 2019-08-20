using Newtonsoft.Json;

namespace WebApplication.Core.Models
{
    public abstract class SecondarySourceBaseViewModel : BaseModel<string>
    {
        public string ResourceId { get; set; }
    }
    public class SecondarySourceGetFullViewModel : SecondarySourceBaseViewModel
    {
        public ResourceGetMinViewModel Resource { get; set; }
    }
    public class SecondarySourceGetMinViewModel : SecondarySourceBaseViewModel
    {
    }
    public class SecondarySourceAddViewModel : SecondarySourceBaseViewModel
    {
    }

}
