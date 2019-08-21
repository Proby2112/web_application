using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;
using WebApplication.Core.Interfaces.Services;
using WebApplication.Core.Models;

namespace WebApplication.BL.Services
{
    public class GraphicProductService : BaseService<GraphicProductAddViewModel, GraphicProductGetFullViewModel, GraphicProduct, string>, IGraphicProductService
    {
        public GraphicProductService(IGraphicProductRepository repository, IDataAdapter dataAdapter) : base(repository, dataAdapter) { }
    }

}
