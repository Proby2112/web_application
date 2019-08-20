using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;

namespace WebApplication.DL.Repositories
{
    public class FinalProductRepository : BaseRepository<FinalProduct, string>, IFinalProductRepository
    {
        public FinalProductRepository(IGenericRepository<FinalProduct, string> repository) : base(repository) { }
    }

}
