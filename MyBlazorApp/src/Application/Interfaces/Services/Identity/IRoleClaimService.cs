using MyBlazorApp.Application.Interfaces.Common;
using MyBlazorApp.Application.Requests.Identity;
using MyBlazorApp.Application.Responses.Identity;
using MyBlazorApp.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBlazorApp.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}