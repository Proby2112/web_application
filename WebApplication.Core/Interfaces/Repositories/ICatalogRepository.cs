using System.Threading.Tasks;
using WebApplication.Core.Entities;

namespace WebApplication.Core.Interfaces.Repositories
{
    public interface ICatalogRepository : IBaseRepository<Catalog, string>
    {
        Task<Catalog> GetByUrlAsync(string url);
    }
}
