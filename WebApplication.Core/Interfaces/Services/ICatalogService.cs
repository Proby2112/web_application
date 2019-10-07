using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Entities;
using WebApplication.Core.Models;

namespace WebApplication.Core.Interfaces.Services
{
    public interface ICatalogService : IBaseService<CatalogAddViewModel, CatalogGetFullViewModel, Catalog, string>
    {
        Task<CatalogGetFullViewModel> GetByUrlAsync(string url);
    }
}
