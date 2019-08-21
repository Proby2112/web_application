using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Core.Models;

namespace WebApplication.BL.Services
{
    public class SecondarySourceService : BaseService<SecondarySourceAddViewModel, SecondarySourceGetFullViewModel, SecondarySource, string>, ISecondarySourceService
    {
        public SecondarySourceService(ISecondarySourceRepository repository, IDataAdapter dataAdapter) : base(repository, dataAdapter) { }
    }

}
