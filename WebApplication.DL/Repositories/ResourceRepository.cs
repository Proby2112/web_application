using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;

namespace WebApplication.DL.Repositories
{
    public class ResourceRepository : BaseRepository<Resource, string>, IResourceRepository
    {
        public ResourceRepository(IGenericRepository<Resource, string> repository) : base(repository) { }
    }

}
