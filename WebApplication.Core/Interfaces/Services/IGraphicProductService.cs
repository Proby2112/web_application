using WebApplication.Core.Entities;
using WebApplication.Core.Models;

namespace WebApplication.Core.Interfaces.Services
{
    public interface IGraphicProductService : IBaseService<GraphicProductAddViewModel, GraphicProductGetFullViewModel, GraphicProduct, string>
    {
    }
}
