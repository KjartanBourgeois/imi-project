using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class SettingsViewModel : FreshBasePageModel
    {
        private IUserService userService;
        private IAppSettingsService appSettings;

        public SettingsViewModel()
        {
            userService = new UserService();
            appSettings = new AppSettingsService();
        }

        #region Properties

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; RaisePropertyChanged(nameof(Email)); }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; RaisePropertyChanged(nameof(UserName)); }
        }


        private bool enableNotifications;
        public bool EnableNotifications
        {
            get { return enableNotifications; }
            set
            {
                enableNotifications = value;
                RaisePropertyChanged(nameof(EnableNotifications));
            }
        }

        #endregion

        public async override void Init(object initData)
        {
            base.Init(initData);

            //settings
            var settings = await appSettings.GetSettings();
            EnableNotifications = settings.EnableNotifications;

            //user
            var currentUser = await userService.GetUser(settings.CurrentUserName);
            Email = currentUser.Email;
            UserName = currentUser.UserName;
        }

        public ICommand Save => new Command(() => SaveSettings());

        private async void SaveSettings()
        {
            var currentSettings = await appSettings.GetSettings();
            currentSettings.EnableNotifications = EnableNotifications;

            var user = await userService.GetUser(currentSettings.CurrentUserName);
            user.Email = Email;
            user.UserName = UserName;
            await userService.UpdateUser(user);

            currentSettings.CurrentUserName = user.UserName;
            await appSettings.SaveSettings(currentSettings);

            await CoreMethods.DisplayAlert("Opslaan", "Uw instellingen zijn bewaard", "Oké");
            await CoreMethods.PushPageModel<ProfileViewModel>(true);
        }

    }
}
