using AutoMapper;
using MyBlazorApp.Application.Features.Brands.Commands.AddEdit;
using MyBlazorApp.Application.Features.Brands.Queries.GetAll;
using MyBlazorApp.Application.Features.Brands.Queries.GetById;
using MyBlazorApp.Domain.Entities.Catalog;

namespace MyBlazorApp.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}