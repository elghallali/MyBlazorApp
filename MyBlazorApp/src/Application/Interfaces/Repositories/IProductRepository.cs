using System.Threading.Tasks;

namespace MyBlazorApp.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
    }
}