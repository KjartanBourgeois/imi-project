using Imi.Project.Wpf.Core.Services;
using Imi.Project.Wpf.Core.Services.Api;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IAccountService, ApiAccountService>();
            services.AddSingleton<IRecipeService, ApiRecipeService>();
            services.AddSingleton<ICategoryService, ApiCategoryService>();
            services.AddSingleton<IKitchenService, ApiKitchenService>();
            services.AddSingleton<IThemeService, ApiThemeService>();
        }
    }
}