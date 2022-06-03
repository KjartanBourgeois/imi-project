using Imi.Project.Mobile.Pages;
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
    public class RegisterViewModelTest
    {
        [Fact]
        public void Init_WithValidInput_ReturnsExpectedUserName()
        {
            //Assert
            var expectedUserName = "Gebruikersnaam";
            object initData = new object();

            var registerViewModel = new RegisterViewModel();

            //Act
            registerViewModel.Init(initData);

            //Assert
            Assert.Equal(registerViewModel.UserName, expectedUserName);
        }

        [Fact]
        public void Init_WithValidInput_ReturnsExpectedEmailAddress()
        {
            //Assert
            var expectedEmailAddress = "@mail.be";
            object initData = new object();

            var registerViewModel = new RegisterViewModel();

            //Act
            registerViewModel.Init(initData);

            //Assert
            Assert.Equal(registerViewModel.EmailAddress, expectedEmailAddress);
        }

        [Fact]
        public void Init_WithValidInput_ReturnsExpectedPassword()
        {
            //Assert
            var expectedPassword = "";
            object initData = new object();

            var registerViewModel = new RegisterViewModel();

            //Act
            registerViewModel.Init(initData);

            //Assert
            Assert.Equal(registerViewModel.Password, expectedPassword);
        }

        [Fact]
        public void Init_WithValidInput_ReturnsExpectedDateOfBirth()
        {
            //Assert
            var expectedDateOfBirth = DateTime.Today;
            object initData = new object();

            var registerViewModel = new RegisterViewModel();

            //Act
            registerViewModel.Init(initData);

            //Assert
            Assert.Equal(registerViewModel.DateOfBirth, expectedDateOfBirth);
        }

        [Fact]
        public void Init_WithValidInput_ReturnsExpectedTerms()
        {
            //Assert
            var expectedTerms = false;
            object initData = new object();

            var registerViewModel = new RegisterViewModel();

            //Act
            registerViewModel.Init(initData);

            //Assert
            Assert.Equal(registerViewModel.Terms, expectedTerms);
        }

        [Fact]
        public void Register_WithValidInput_ExecuteRegisterUserCommand()
        {
            //Assert
            var expectedMethodName = "RegisterUser";
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            Type testType = typeof(RegisterViewModel);
            MethodInfo testMethod = testType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(m => m.Name == "RegisterUser" && m.IsPrivate).First();

            var testViewModel = new RegisterViewModel();
            testViewModel.CoreMethods = coreMethodsMock.Object;

            //Act
            testViewModel.Register.Execute(null);

            //Assert
            Assert.Equal(testMethod.Name, expectedMethodName);
        }

        [Fact]
        public void Register_WithValidInput_ExecuteCorrectCoreMethods()
        {
            //Assert
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            var testViewModel = new RegisterViewModel();
            testViewModel.CoreMethods = coreMethodsMock.Object;

            //Act
            testViewModel.Register.Execute(null);

            //Assert
            coreMethodsMock.Verify(x => x.DisplayAlert(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}