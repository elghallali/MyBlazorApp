using MyBlazorApp.Application.Features.Dashboards.Queries.GetData;
using MyBlazorApp.Client.Infrastructure.Extensions;
using MyBlazorApp.Shared.Wrapper;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyBlazorApp.Client.Infrastructure.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly HttpClient _httpClient;

        public DashboardManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<DashboardDataResponse>> GetDataAsync()
        {
            var response = await _httpClient.GetAsync(Routes.DashboardEndpoints.GetData);
            var data = await response.ToResult<DashboardDataResponse>();
            return data;
        }
    }
}