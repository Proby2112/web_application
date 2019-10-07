using System;
using System.Threading.Tasks;
using WebApplication.Core.Entities;
using WebApplication.Core.Helpers.Core;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Core.Models;

namespace WebApplication.BL.Services
{
    public class CatalogService : BaseService<CatalogAddViewModel, CatalogGetFullViewModel, Catalog, string>, ICatalogService
    {
        new ICatalogRepository _repository;

        public CatalogService(ICatalogRepository repository, IDataAdapter dataAdapter) : base(repository, dataAdapter)
        {
            _repository = repository;
        }

        public async Task<CatalogGetFullViewModel> GetByUrlAsync(string url)
        {
            Catalog                 entity;
            CatalogGetFullViewModel model;

            if (url.IsEmpty()) throw new ArgumentNullException("url");

            entity = await _repository.GetByUrlAsync(url);
            model = _dataAdapter.Parse<Catalog, CatalogGetFullViewModel>(entity);

            return model;
        }
    }

}
