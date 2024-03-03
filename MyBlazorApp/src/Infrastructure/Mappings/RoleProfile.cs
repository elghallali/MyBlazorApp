using AutoMapper;
using MyBlazorApp.Application.Responses.Identity;
using MyBlazorApp.Infrastructure.Models.Identity;

namespace MyBlazorApp.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}