using Newtonsoft.Json;

namespace WebApplication.Core.Models
{
    public abstract class PrimarySourceBaseViewModel : BaseModel<string>
    {
        public string ResourceId { get; set; }
    }
    public class PrimarySourceGetFullViewModel : PrimarySourceBaseViewModel
    {
        public ResourceGetMinViewModel Resource { get; set; }
    }
    public class PrimarySourceGetMinViewModel : PrimarySourceBaseViewModel
    {
    }
    public class PrimarySourceAddViewModel : PrimarySourceBaseViewModel
    {
    }

}
