using WebApplication.Core.Entities;
using WebApplication.Core.Models;

namespace WebApplication.Core.Interfaces.Services
{
    public interface ISecondarySourceService : IBaseService<SecondarySourceAddViewModel, SecondarySourceGetFullViewModel, SecondarySource, string>
    {
    }
}
