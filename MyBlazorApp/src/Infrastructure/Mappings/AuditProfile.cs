using AutoMapper;
using MyBlazorApp.Application.Responses.Audit;
using MyBlazorApp.Infrastructure.Models.Audit;

namespace MyBlazorApp.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}