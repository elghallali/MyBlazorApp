using MyBlazorApp.Application.Features.Documents.Commands.AddEdit;
using MyBlazorApp.Application.Features.Documents.Queries.GetAll;
using MyBlazorApp.Application.Features.Documents.Queries.GetById;
using MyBlazorApp.Application.Requests.Documents;
using MyBlazorApp.Shared.Wrapper;
using System.Threading.Tasks;

namespace MyBlazorApp.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}