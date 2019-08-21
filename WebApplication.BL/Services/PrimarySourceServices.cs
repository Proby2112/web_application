using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Core.Models;

namespace WebApplication.BL.Services
{
    public class PrimarySourceService : BaseService<PrimarySourceAddViewModel, PrimarySourceGetFullViewModel, PrimarySource, string>, IPrimarySourceService
    {
        public PrimarySourceService(IPrimarySourceRepository repository, IDataAdapter dataAdapter) : base(repository, dataAdapter) { }
    }
}
