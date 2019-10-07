using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Core.Entities;
using WebApplication.Core.Interfaces;
using WebApplication.Core.Models;

namespace WebApplication.BL.Managers
{
    public class DataAdapter : IDataAdapter
    {
        readonly IMapper _mapper;

        public DataAdapter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public To Parse<From, To>(From model) => _mapper.Map<From, To>(model);

        public IEnumerable<To> Parse<From, To>(IEnumerable<From> models) => models.Select(Parse<From, To>).ToList();
    }

    class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // CreatingDigitalImage
            CreateMap<Catalog, CatalogGetFullViewModel>();
            CreateMap<Catalog, CatalogGetMinViewModel>();
        }
    }
}
