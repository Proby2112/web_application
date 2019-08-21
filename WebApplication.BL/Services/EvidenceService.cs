using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Core.Models;

namespace WebApplication.BL.Services
{
    public class EvidenceService : BaseService<EvidenceAddViewModel, EvidenceGetFullViewModel, Evidence, string>, IEvidenceService
    {
        public EvidenceService(IEvidenceRepository repository, IDataAdapter dataAdapter) : base(repository, dataAdapter) { }
    }

}
