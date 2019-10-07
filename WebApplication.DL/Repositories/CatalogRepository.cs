using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;

namespace WebApplication.DL.Repositories
{
    public class CatalogRepository : BaseRepository<Catalog, string>, ICatalogRepository
    {
        public CatalogRepository(IGenericRepository<Catalog, string> repository) : base(repository) { }
    }

}