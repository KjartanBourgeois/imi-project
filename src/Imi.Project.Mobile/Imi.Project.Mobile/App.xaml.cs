using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Api;
using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;

[assembly: ExportFont("FontAwesome5Brands.otf", Alias = "FontAwesomeBrands")]
[assembly: ExportFont("FontAwesome5Regular.otf", Alias = "FontAwesomeRegular")]
[assembly: ExportFont("FontAwesome5Solid.otf", Alias = "FontAwesomeSolid")]

namespace Imi.Project.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTEyMTM3QDMxMzkyZTMzMmUzMFBuZ0wyVGtmTWgxKzY0S0JZWUlseWFBaGZHazN3ZTRvUS84V1l3eXR5Ykk9;NTEyMTM4QDMxMzkyZTMzMmUzME5NZlk1NThGYmZyNGFsYmFxVFU5STdrR1dmcHlWckxJdCs3cVJEd0F0UVE9;NTEyMTM5QDMxMzkyZTMzMmUzMGFHVUJZMUZOOVBWUWxtNWdxcnBIUW8yRjBGWHNBZ01lRTIwc3pGQTdXcEU9;NTEyMTQwQDMxMzkyZTMzMmUzMEVnVEVZL0hpeGM2cHQzTm9lR1FTT0VvYWREeHo3OG5FWm1zSkN0N216cG89;NTEyMTQxQDMxMzkyZTMzMmUzMGF0VThva3p2WlRmSC8ydHNRSVMzYzdBNlE5cVJvdExzUkpQYjJNWkZOdEE9;NTEyMTQyQDMxMzkyZTMzMmUzMEcvZWQ3bFc4Z1NNS1dtTVhlYVBvM2tCRmhGSHVqN2dMd2tSWmx1c3RQbXM9;NTEyMTQzQDMxMzkyZTMzMmUzME5ldGQ5ek15bUdxWUtiTnFnYitKaFYzUzl0YUpjaW5FSmpVYng2TVNxTlU9;NTEyMTQ0QDMxMzkyZTMzMmUzMGRQTUR3YkorbVllSFZzY25UQXJMOGozU25pcS94aEtVcWRyMUVSdlEyZzg9;NTEyMTQ1QDMxMzkyZTMzMmUzMFpwRU5BTVBDUUxRaXZzV1lwQ240M1N0dmhQeWY1MEhYLzBLQWRCZ1pqSjg9;NTEyMTQ2QDMxMzkyZTMzMmUzMFFKWkxoUEs4UTY1NzZ3OHFkYzRXSlMxL2hONjNzRVVsd3dVYUF5MTF4aW89;NTEyMTQ3QDMxMzkyZTMzMmUzMEhCU1l3V1RCWjltdnBOdndsRElyOUUvb2oyRFBMK1hQT29kMmxYbEl1bkE9");

            FreshIOC.Container.Register<IRecipeService, ApiRecipeService>();
            FreshIOC.Container.Register<ICategoryService, ApiCategoryService>();
            FreshIOC.Container.Register<IKitchenService, ApiKitchenService>();
            FreshIOC.Container.Register<IThemeService, ApiThemeService>();
            FreshIOC.Container.Register<IAccountService, ApiAccountService>();
            FreshIOC.Container.Register(DependencyService.Get<IBuzz>());

            InitializeComponent();

            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<LoginViewModel>());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}