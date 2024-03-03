using MudBlazor;
using MyBlazorApp.Shared.Managers;
using System.Threading.Tasks;

namespace MyBlazorApp.Client.Infrastructure.Managers.Preferences
{
    public interface IClientPreferenceManager : IPreferenceManager
    {
        Task<MudTheme> GetCurrentThemeAsync();

        Task<bool> ToggleDarkModeAsync();
    }
}