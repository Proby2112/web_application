using WebApplication.Core.Entities;
using WebApplication.Core.Models;

namespace WebApplication.Core.Interfaces.Services
{
    public interface IPrimarySourceService : IBaseService<PrimarySourceAddViewModel, PrimarySourceGetFullViewModel, PrimarySource, string>
    {
    }
}
