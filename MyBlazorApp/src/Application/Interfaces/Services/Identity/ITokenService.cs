using MyBlazorApp.Application.Interfaces.Common;
using MyBlazorApp.Application.Requests.Identity;
using MyBlazorApp.Application.Responses.Identity;
using MyBlazorApp.Shared.Wrapper;
using System.Threading.Tasks;

namespace MyBlazorApp.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}