using MyBlazorApp.Application.Interfaces.Common;
using MyBlazorApp.Application.Requests.Identity;
using MyBlazorApp.Shared.Wrapper;
using System.Threading.Tasks;

namespace MyBlazorApp.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}