using Newtonsoft.Json;

namespace WebApplication.Core.Models
{
    public abstract class FinalProductBaseViewModel : BaseModel<string>
    {
        public string GraphicProductId { get; set; }
    }
    public class FinalProductGetFullViewModel : FinalProductBaseViewModel
    {
        public GraphicProductGetMinViewModel GraphicProduct { get; set; }
    }
    public class FinalProductGetMinViewModel : FinalProductBaseViewModel
    {
    }

}
