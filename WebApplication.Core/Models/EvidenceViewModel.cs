
namespace WebApplication.Core.Models
{
    public abstract class EvidenceBaseViewModel : BaseModel<string>
    {

        public string CreatingDigitalImageId { get; set; }

    }
    public class EvidenceGetFullViewModel : EvidenceBaseViewModel
    {
        public CreatingDigitalImageGetMinViewModel CreatingDigitalImage { get; set; }
    }
    public class EvidenceGetMinViewModel : EvidenceBaseViewModel
    {
    }
    public class EvidenceAddViewModel : EvidenceBaseViewModel
    {
    }

}
