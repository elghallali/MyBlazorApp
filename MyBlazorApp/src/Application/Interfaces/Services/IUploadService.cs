using MyBlazorApp.Application.Requests;

namespace MyBlazorApp.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}