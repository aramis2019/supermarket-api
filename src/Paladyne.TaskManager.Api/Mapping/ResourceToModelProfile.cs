using AutoMapper;
using Paladyne.TaskManager.Api.Domain.Models;
using Paladyne.TaskManager.Api.Domain.Models.Queries;
using Paladyne.TaskManager.Api.Resources;

namespace Paladyne.TaskManager.Api.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<SaveProductResource, Product>()
                .ForMember(src => src.UnitOfMeasurement, opt => opt.MapFrom(src => (EUnitOfMeasurement)src.UnitOfMeasurement));

            CreateMap<ProductsQueryResource, ProductsQuery>();
        }
    }
}