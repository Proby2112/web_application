using WebApplication.Core.Entities;
using WebApplication.Core.Models;

namespace WebApplication.Core.Interfaces.Services
{
    public interface IEvidenceService : IBaseService<EvidenceAddViewModel, EvidenceGetFullViewModel, Evidence, string>
    {
    }
}
