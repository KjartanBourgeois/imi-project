using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainFlyoutPageFlyout : ContentPage
    {
        private IUserService userService;
        private IAppSettingsService appSettings;
        public MainFlyoutPageFlyout()
        {
            InitializeComponent();
            userService = new UserService();
            appSettings = new AppSettingsService();

        }

        protected override async void OnAppearing()
        {
            var settings = await appSettings.GetSettings();
            var currentUser = await userService.GetUser(settings.CurrentUserName);

            base.OnAppearing();
        }

        private async void btnExitApp_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Afsluiten", "Ben u zeker dat u de app wilt afsluiten?", "Ja", "Nee"))
            {
                Environment.Exit(0);
            }
        }

        private async void btnAdmin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminPage());
        }
    }
}