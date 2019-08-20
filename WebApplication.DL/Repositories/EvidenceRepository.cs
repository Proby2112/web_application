using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;

namespace WebApplication.DL.Repositories
{
    public class EvidenceRepository : BaseRepository<Evidence, string>, IEvidenceRepository
    {
        public EvidenceRepository(IGenericRepository<Evidence, string> repository) : base(repository) { }
    }

}
