using Imi.Project.Common.Dto;
using Imi.Project.Mobile.Core.Domain.Services;
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
    public class AdminViewModelTest
    {
        [Fact]
        public void Init_WithValidInput_InvokedRaisePropertyChanged()
        {
            //Assert
            bool invoked = false;
            object initData = new object();

            var recipeService = new Mock<IRecipeService>();

            var adminViewModel = new AdminViewModel(recipeService.Object);

            //Act
            adminViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals("Recipes")) invoked = true;
            };

            adminViewModel.Init(initData);

            //Assert
            Assert.True(invoked);
        }

        [Fact]
        public void ReverseInit_WithValidInput_InvokedRaisePropertyChanged()
        {
            //Assert
            bool invoked = false;
            object initData = new object();

            var recipeService = new Mock<IRecipeService>();

            var adminViewModel = new AdminViewModel(recipeService.Object);

            //Act
            adminViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals("Recipes")) invoked = true;
            };

            adminViewModel.ReverseInit(initData);

            //Assert
            Assert.True(invoked);
        }

        [Fact]
        public void AddNewRecipe_WithValidInput_TriggersPushPageModel()
        {
            //Assert
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();

            var recipeService = new Mock<IRecipeService>();
            var adminViewModel = new AdminViewModel(recipeService.Object);
            adminViewModel.CoreMethods = coreMethodsMock.Object;

            //Act

            adminViewModel.AddNewRecipe.Execute(null);

            //Assert
            coreMethodsMock.Verify(x => x.PushPageModel<RecipeEditViewModel>(true), Times.Once);
        }

        [Fact]
        public void OpenRecipeEditPage_WithValidInput_TriggersPushPageModel()
        {
            //Assert
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            var testRecipe = new Mock<RecipeResponseDto>();
            var recipeService = new Mock<IRecipeService>();
            var adminViewModel = new AdminViewModel(recipeService.Object);
            adminViewModel.CoreMethods = coreMethodsMock.Object;

            //Act

            adminViewModel.OpenRecipeEditPage.Execute(testRecipe.Object);

            //Assert
            coreMethodsMock.Verify(x => x.PushPageModel<RecipeEditViewModel>(testRecipe.Object, false, true), Times.Once);
        }

        /*Werkt nog niet*/

        //[Fact]
        //public void Delete_WithValidInput_TriggersPushPageModel()
        //{
        //    //Assert
        //    var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
        //    var testRecipe = new Mock<RecipeResponseDto>();
        //    var recipeService = new Mock<IRecipeService>();
        //    var adminViewModel = new AdminViewModel(recipeService.Object);
        //    var testApp = new Mock<Xamarin.Forms.Application>();
        //    adminViewModel.CoreMethods = coreMethodsMock.Object;

        //    //Act

        //    adminViewModel.Delete.Execute(testRecipe.Object);

        //    //Assert
        //    coreMethodsMock.Verify(x => x.DisplayAlert(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        //    recipeService.Verify(x => x.DeleteRecipe(It.IsAny<Guid>(), testApp.Object.Properties["JWT"].ToString()), Times.Once);
        //    coreMethodsMock.Verify(x => x.DisplayAlert(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        //}
    }
}