using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;

namespace WebApplication.DL.Repositories
{
    public class PrimarySourceRepository : BaseRepository<PrimarySource, string>, IPrimarySourceRepository
    {
        public PrimarySourceRepository(IGenericRepository<PrimarySource, string> repository) : base(repository) { }
    }

}
