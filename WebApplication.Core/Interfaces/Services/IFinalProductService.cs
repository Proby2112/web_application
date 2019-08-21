using WebApplication.Core.Entities;
using WebApplication.Core.Models;

namespace WebApplication.Core.Interfaces.Services
{
    public interface IFinalProductService : IBaseService<FinalProductAddViewModel, FinalProductGetFullViewModel, FinalProduct, string>
    {
    }
}
