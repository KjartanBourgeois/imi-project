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
    public class ProfileViewModelTest
    {
        [Fact]
        public void GoToFavoritePage_WithValidBehavoir_ExecutedCommand()
        {
            //Arrange
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            var testViewModel = new ProfileViewModel();
            testViewModel.CoreMethods = coreMethodsMock.Object;
            //Act

            testViewModel.GoToFavoritePage.Execute(null);

            //Assert
            coreMethodsMock.Verify(x => x.PushPageModel<FavoriteRecipeViewModel>(true), Times.Once);
        }

        [Fact]
        public void GoToMyPhotosPage_WithValidBehavoir_ExecutedCommand()
        {
            //Arrange
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            var testViewModel = new ProfileViewModel();
            testViewModel.CoreMethods = coreMethodsMock.Object;
            //Act

            testViewModel.GoToMyPhotosPage.Execute(null);

            //Assert
            coreMethodsMock.Verify(x => x.PushPageModel<PhotosViewModel>(true), Times.Once);
        }

        [Fact]
        public void GoToSettingsPage_WithValidBehavoir_ExecutedCommand()
        {
            //Arrange
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            var testViewModel = new ProfileViewModel();
            testViewModel.CoreMethods = coreMethodsMock.Object;
            //Act

            testViewModel.GoToSettingsPage.Execute(null);

            //Assert
            coreMethodsMock.Verify(x => x.PushPageModel<SettingsViewModel>(true), Times.Once);
        }
    }
}