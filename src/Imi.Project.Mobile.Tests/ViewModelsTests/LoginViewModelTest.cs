using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Pages;
using Imi.Project.Mobile.ViewModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Imi.Project.Mobile.Tests.ViewModelsTests
{
    public class LoginViewModelTest
    {
        [Fact]
        public void GoToRegisterPage_WithValidBehavoir_ExecutedCommand()
        {
            //Arrange
            var testAccountService = new Mock<IAccountService>();
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            var testBuzz = new Mock<IBuzz>();
            var testViewModel = new LoginViewModel(testAccountService.Object, testBuzz.Object);
            testViewModel.CoreMethods = coreMethodsMock.Object;
            //Act

            testViewModel.GoToRegisterPage.Execute(null);

            //Assert
            coreMethodsMock.Verify(x => x.PushPageModel<RegisterViewModel>(true), Times.Once);
        }
    }
}