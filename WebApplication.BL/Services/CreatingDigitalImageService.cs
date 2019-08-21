using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Core.Models;

namespace WebApplication.BL.Services
{
    public class CreatingDigitalImageService : BaseService<CreatingDigitalImageAddViewModel, CreatingDigitalImageGetFullViewModel, CreatingDigitalImage, string>, ICreatingDigitalImageService
    {
        public CreatingDigitalImageService(ICreatingDigitalImageRepository repository, IDataAdapter dataAdapter) : base(repository, dataAdapter) { }
    }

}
