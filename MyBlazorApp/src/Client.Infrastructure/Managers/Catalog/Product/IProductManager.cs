using MyBlazorApp.Application.Features.Products.Commands.AddEdit;
using MyBlazorApp.Application.Features.Products.Queries.GetAllPaged;
using MyBlazorApp.Application.Requests.Catalog;
using MyBlazorApp.Shared.Wrapper;
using System.Threading.Tasks;

namespace MyBlazorApp.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}