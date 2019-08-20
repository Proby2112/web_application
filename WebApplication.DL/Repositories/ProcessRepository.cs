using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;

namespace WebApplication.DL.Repositories
{
    public class ProcessRepository : BaseRepository<Process, string>, IProcessRepository
    {
        public ProcessRepository(IGenericRepository<Process, string> repository) : base(repository) { }
    }

}
