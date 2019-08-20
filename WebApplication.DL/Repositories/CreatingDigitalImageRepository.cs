using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;

namespace WebApplication.DL.Repositories
{
    public class CreatingDigitalImageRepository : BaseRepository<CreatingDigitalImage, string>, ICreatingDigitalImageRepository
    {
        public CreatingDigitalImageRepository(IGenericRepository<CreatingDigitalImage, string> repository) : base(repository) { }
    }

}
