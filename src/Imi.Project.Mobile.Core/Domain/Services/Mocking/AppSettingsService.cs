using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class AppSettingsService : IAppSettingsService
    {
        private static AppSettings currentSettings = new AppSettings
        {
            CurrentUserName = "Admin",
            EnableNotifications = true
        };

        public async Task<AppSettings> GetSettings()
        {
            return await Task.FromResult(currentSettings);
        }

        public async Task<bool> SaveSettings(AppSettings settings)
        {
            currentSettings = settings;
            return await Task.FromResult(true);
        }
    }
}
