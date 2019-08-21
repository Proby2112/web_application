using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Core.Models;

namespace WebApplication.BL.Services
{
    public class FinalProductService : BaseService<FinalProductAddViewModel, FinalProductGetFullViewModel, FinalProduct, string>, IFinalProductService
    {
        public FinalProductService(IFinalProductRepository repository, IDataAdapter dataAdapter) : base(repository, dataAdapter) { }
    }

}
