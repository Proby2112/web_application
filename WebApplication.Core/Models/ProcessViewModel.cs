using Newtonsoft.Json;

namespace WebApplication.Core.Models
{
    public abstract class ProcessBaseViewModel : BaseModel<string>
    {
        public string GraphicProductId { get; set; }
    }
    public class ProcessGetFullViewModel : ProcessBaseViewModel
    {
        public GraphicProductGetMinViewModel GraphicProduct { get; set; }
    }
    public class ProcessGetMinViewModel : ProcessBaseViewModel
    {
    }
    public class ProcessAddViewModel : ProcessBaseViewModel
    {
    }

}
