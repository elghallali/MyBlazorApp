using AutoMapper;
using MyBlazorApp.Application.Requests.Identity;
using MyBlazorApp.Application.Responses.Identity;

namespace MyBlazorApp.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}