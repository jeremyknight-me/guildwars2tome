﻿using GuildWars2Tome.Extensions;
using GuildWars2Tome.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http;
using System.Threading.Tasks;

namespace GuildWars2Tome.Pages
{
    public partial class Settings
    {
        private SettingsFormModel formModel = new SettingsFormModel();

        [Inject]
        protected HttpClient Http { get; set; }

        [Inject]
        protected IJSRuntime JS { get; set; }

        private async Task HandleValidSaveSubmit()
        {
            await this.JS.LocalStorageSet("settings.apiKey", formModel.ApiKey);
        }
    }
}