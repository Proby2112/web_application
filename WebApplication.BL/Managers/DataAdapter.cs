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
}

namespace HeroesAndDragons.Managers
{
    class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // CreatingDigitalImage
            CreateMap<CreatingDigitalImage, CreatingDigitalImageGetFullViewModel>();
            CreateMap<CreatingDigitalImage, CreatingDigitalImageGetMinViewModel>();

            // Evidence
            CreateMap<Evidence, EvidenceGetFullViewModel>();
            CreateMap<Evidence, EvidenceGetMinViewModel>();

            // FinalProduct
            CreateMap<FinalProduct, FinalProductGetFullViewModel>();
            CreateMap<FinalProduct, FinalProductGetMinViewModel>();

            // GraphicProduct
            CreateMap<GraphicProduct, GraphicProductGetFullViewModel>();
            CreateMap<GraphicProduct, GraphicProductGetMinViewModel>();

            // PrimarySource
            CreateMap<PrimarySource, PrimarySourceGetFullViewModel>();
            CreateMap<PrimarySource, PrimarySourceGetMinViewModel>();

            // Process
            CreateMap<Process, ProcessGetFullViewModel>();
            CreateMap<Process, ProcessGetMinViewModel>();

            // Resource
            CreateMap<Resource, ResourceGetFullViewModel>();
            CreateMap<Resource, ResourceGetMinViewModel>();

            // SecondarySource
            CreateMap<SecondarySource, SecondarySourceGetFullViewModel>();
            CreateMap<SecondarySource, SecondarySourceGetMinViewModel>();
        }
    }
}
