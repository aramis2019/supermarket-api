using AutoMapper;
using Paladyne.TaskManager.Api.Domain.Models;
using Paladyne.TaskManager.Api.Domain.Models.Queries;
using Paladyne.TaskManager.Api.Extensions;
using Paladyne.TaskManager.Api.Resources;

namespace Paladyne.TaskManager.Api.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));

            CreateMap<QueryResult<Product>, QueryResultResource<Product>>();
        }
    }
}