using MyBlazorApp.Application.Interfaces.Repositories;
using MyBlazorApp.Domain.Entities.Misc;

namespace MyBlazorApp.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}