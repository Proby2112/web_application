using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;

namespace WebApplication.DL.Repositories
{
    public class SecondarySourceRepository : BaseRepository<SecondarySource, string>, ISecondarySourceRepository
    {
        public SecondarySourceRepository(IGenericRepository<SecondarySource, string> repository) : base(repository) { }
    }

}
