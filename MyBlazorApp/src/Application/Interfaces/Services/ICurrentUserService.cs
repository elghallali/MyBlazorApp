using MyBlazorApp.Application.Interfaces.Common;

namespace MyBlazorApp.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}