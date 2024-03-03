using MyBlazorApp.Application.Interfaces.Repositories;
using MyBlazorApp.Domain.Entities.Catalog;

namespace MyBlazorApp.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}