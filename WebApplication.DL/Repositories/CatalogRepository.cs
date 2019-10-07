using System.Linq;
using System.Threading.Tasks;
using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;

namespace WebApplication.DL.Repositories
{
    public class CatalogRepository : BaseRepository<Catalog, string>, ICatalogRepository
    {
        public CatalogRepository(IGenericRepository<Catalog, string> repository) : base(repository) { }

        public Task<Catalog> GetByUrlAsync(string url)
        {
            var entity = _repository.Table.FirstOrDefault(e => e.FriendlyUrl.Equals(url));
            return Task.FromResult(entity);
        }
    }

}