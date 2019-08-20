
namespace WebApplication.Core.Models
{
    public abstract class GraphicProductBaseViewModel : BaseModel<string>
    {
        public string CreatingDigitalImageId { get; set; }
        public string FinalProductId { get; set; }
        public string ProcessId { get; set; }

    }
    public class GraphicProductGetFullViewModel : GraphicProductBaseViewModel
    {
        public CreatingDigitalImageGetMinViewModel CreatingDigitalImage { get; set; }
        public FinalProductGetMinViewModel FinalProduct { get; set; }
        public ProcessGetMinViewModel Process { get; set; }
    }
    public class GraphicProductGetMinViewModel : GraphicProductBaseViewModel
    {
    }
    public class GraphicProductAddViewModel : GraphicProductBaseViewModel
    {
    }

}
