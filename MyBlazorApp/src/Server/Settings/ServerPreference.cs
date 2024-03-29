﻿using MyBlazorApp.Shared.Constants.Localization;
using MyBlazorApp.Shared.Settings;
using System.Linq;

namespace MyBlazorApp.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}