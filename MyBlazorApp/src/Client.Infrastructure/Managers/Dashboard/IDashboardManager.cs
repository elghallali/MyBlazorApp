using MyBlazorApp.Application.Features.Dashboards.Queries.GetData;
using MyBlazorApp.Shared.Wrapper;
using System.Threading.Tasks;

namespace MyBlazorApp.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}