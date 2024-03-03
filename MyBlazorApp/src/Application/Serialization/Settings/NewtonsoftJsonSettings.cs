
using MyBlazorApp.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace MyBlazorApp.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}