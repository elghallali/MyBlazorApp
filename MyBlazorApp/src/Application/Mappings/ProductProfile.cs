using AutoMapper;
using MyBlazorApp.Application.Features.Products.Commands.AddEdit;
using MyBlazorApp.Domain.Entities.Catalog;

namespace MyBlazorApp.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}