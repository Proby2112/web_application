using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Core.Models;

namespace WebApplication.BL.Services
{
    public class ResourceService : BaseService<ResourceAddViewModel, ResourceGetFullViewModel, Resource, string>, IResourceService
    {
        public ResourceService(IResourceRepository repository, IDataAdapter dataAdapter) : base(repository, dataAdapter) { }
    }

}
