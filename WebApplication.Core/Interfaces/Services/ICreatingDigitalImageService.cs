using System;
using System.Collections.Generic;
using System.Text;
using WebApplication.Core.Entities;
using WebApplication.Core.Models;

namespace WebApplication.Core.Interfaces.Services
{
    public interface ICreatingDigitalImageService : IBaseService<CreatingDigitalImageAddViewModel, CreatingDigitalImageGetFullViewModel, CreatingDigitalImage, string>
    {
    }
}
