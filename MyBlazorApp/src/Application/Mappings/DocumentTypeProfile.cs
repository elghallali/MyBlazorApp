using AutoMapper;
using MyBlazorApp.Application.Features.DocumentTypes.Commands.AddEdit;
using MyBlazorApp.Application.Features.DocumentTypes.Queries.GetAll;
using MyBlazorApp.Application.Features.DocumentTypes.Queries.GetById;
using MyBlazorApp.Domain.Entities.Misc;

namespace MyBlazorApp.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}