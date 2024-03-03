using MyBlazorApp.Application.Interfaces.Serialization.Options;
using System.Text.Json;

namespace MyBlazorApp.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}