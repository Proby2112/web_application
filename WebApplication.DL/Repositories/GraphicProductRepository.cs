using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Interfaces.Repositories;

namespace WebApplication.DL.Repositories
{
    public class GraphicProductRepository : BaseRepository<GraphicProduct, string>, IGraphicProductRepository
    {
        public GraphicProductRepository(IGenericRepository<GraphicProduct, string> repository) : base(repository) { }
    }

}
