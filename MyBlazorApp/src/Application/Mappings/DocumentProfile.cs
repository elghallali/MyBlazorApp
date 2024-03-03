using AutoMapper;
using MyBlazorApp.Application.Features.Documents.Commands.AddEdit;
using MyBlazorApp.Application.Features.Documents.Queries.GetById;
using MyBlazorApp.Domain.Entities.Misc;

namespace MyBlazorApp.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}