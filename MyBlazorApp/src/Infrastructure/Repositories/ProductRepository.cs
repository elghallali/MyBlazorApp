using Microsoft.EntityFrameworkCore;
using MyBlazorApp.Application.Interfaces.Repositories;
using MyBlazorApp.Domain.Entities.Catalog;
using System.Threading.Tasks;

namespace MyBlazorApp.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IRepositoryAsync<Product, int> _repository;

        public ProductRepository(IRepositoryAsync<Product, int> repository)
        {
            _repository = repository;
        }

        public async Task<bool> IsBrandUsed(int brandId)
        {
            return await _repository.Entities.AnyAsync(b => b.BrandId == brandId);
        }
    }
}