using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using Imi.Project.Mobile.ViewModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Imi.Project.Mobile.Tests.ViewModelsTests
{
    public class SettingsViewModelTest
    {
        private Mock<IUserService> userService;
        private Mock<IAppSettingsService> appSettings;

        public SettingsViewModelTest()
        {
            userService = new Mock<IUserService>();
            appSettings = new Mock<IAppSettingsService>();
        }

        [Theory]
        [InlineData("Email")]
        [InlineData("UserName")]
        [InlineData("EnableNotifications")]
        public void Init_WithValidInput_InvokedRaisePropertyChanged(string propChanged)
        {
            //Assert
            bool invoked = false;
            object initData = new object();

            var testViewModel = new SettingsViewModel();

            //Act
            testViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals(propChanged)) invoked = true;
            };

            testViewModel.Init(initData);

            //Assert
            Assert.True(invoked);
        }

        [Fact]
        public void Save_WithValidInput_ExecuteSaveSettingsCommand()
        {
            //Assert
            var expectedMethodName = "SaveSettings";
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            Type testType = typeof(SettingsViewModel);
            MethodInfo testMethod = testType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(m => m.Name == "SaveSettings" && m.IsPrivate).First();

            var testViewModel = new SettingsViewModel();
            testViewModel.CoreMethods = coreMethodsMock.Object;

            //Act
            testViewModel.Save.Execute(null);

            //Assert
            Assert.Equal(testMethod.Name, expectedMethodName);
        }
    }
}