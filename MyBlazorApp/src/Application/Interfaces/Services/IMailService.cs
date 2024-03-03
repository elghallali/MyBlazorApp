using MyBlazorApp.Application.Requests.Mail;
using System.Threading.Tasks;

namespace MyBlazorApp.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}