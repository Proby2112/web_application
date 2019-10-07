using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Core.Models;

namespace WebApplication.BL.Services
{
    public class CatalogService : BaseService<CatalogAddViewModel, CatalogGetFullViewModel, Catalog, string>, ICatalogService
    {
        public CatalogService(ICatalogRepository repository, IDataAdapter dataAdapter) : base(repository, dataAdapter) { }
    }

}
