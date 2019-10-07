using System;
using System.Collections.Generic;
using System.Text;
using WebApplication.Core.Entities;
using WebApplication.Core.Models;

namespace WebApplication.Core.Interfaces.Services
{
    public interface ICatalogService : IBaseService<CatalogAddViewModel, CatalogGetFullViewModel, Catalog, string>
    {
    }
}
