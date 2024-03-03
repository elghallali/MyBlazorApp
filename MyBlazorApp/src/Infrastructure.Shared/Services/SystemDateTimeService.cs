using MyBlazorApp.Application.Interfaces.Services;
using System;

namespace MyBlazorApp.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}