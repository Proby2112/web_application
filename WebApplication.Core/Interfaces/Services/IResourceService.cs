using WebApplication.Core.Entities;
using WebApplication.Core.Models;

namespace WebApplication.Core.Interfaces.Services
{
    public interface IResourceService : IBaseService<ResourceAddViewModel, ResourceGetFullViewModel, Resource, string>
    {
    }
}
