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
    public class AllRecipesViewModelTest
    {
        [Fact]
        public void Init_WithValidInput_InvokedRaisePropertyChangedOfRecipes()
        {
            //Assert
            bool invoked = false;
            object initData = new object();

            var recipeService = new Mock<IRecipeService>();
            var categoryService = new Mock<ICategoryService>();

            var allRecipesViewModel = new AllRecipesViewModel(recipeService.Object, categoryService.Object);

            //Act
            allRecipesViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals("Recipes")) invoked = true;
            };

            allRecipesViewModel.Init(initData);

            //Assert
            Assert.True(invoked);
        }

        [Fact]
        public void Init_WithValidInput_InvokedRaisePropertyChangedOfCategories()
        {
            //Assert
            bool invoked = false;
            object initData = new object();

            var recipeService = new Mock<IRecipeService>();
            var categoryService = new Mock<ICategoryService>();

            var allRecipesViewModel = new AllRecipesViewModel(recipeService.Object, categoryService.Object);

            //Act
            allRecipesViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals("Categories")) invoked = true;
            };

            allRecipesViewModel.Init(initData);

            //Assert
            Assert.True(invoked);
        }

        [Fact]
        public void ReverseInit_WithValidInput_InvokedRaisePropertyChangedOfCategories()
        {
            //Assert
            bool invoked = false;
            object returnedData = new object();

            var recipeService = new Mock<IRecipeService>();
            var categoryService = new Mock<ICategoryService>();

            var allRecipesViewModel = new AllRecipesViewModel(recipeService.Object, categoryService.Object);

            //Act
            allRecipesViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals("Categories")) invoked = true;
            };

            allRecipesViewModel.ReverseInit(returnedData);

            //Assert
            Assert.True(invoked);
        }

        [Fact]
        public void ReverseInit_WithValidInput_InvokedRaisePropertyChangedOfRecipes()
        {
            //Assert
            bool invoked = false;
            object returnedData = new object();

            var recipeService = new Mock<IRecipeService>();
            var categoryService = new Mock<ICategoryService>();

            var allRecipesViewModel = new AllRecipesViewModel(recipeService.Object, categoryService.Object);

            //Act
            allRecipesViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals("Recipes")) invoked = true;
            };

            allRecipesViewModel.ReverseInit(returnedData);

            //Assert
            Assert.True(invoked);
        }

        [Fact]
        public void OpenRecipe_WithValidInput_ExecutePushPageModel()
        {
            //Assert
            var testRecipe = new Mock<RecipeResponseDto>();
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            var recipeService = new Mock<IRecipeService>();
            var categoryService = new Mock<ICategoryService>();
            var allRecipesViewModel = new AllRecipesViewModel(recipeService.Object, categoryService.Object);
            allRecipesViewModel.CoreMethods = coreMethodsMock.Object;

            //Act
            allRecipesViewModel.OpenRecipe.Execute(testRecipe.Object);

            //Assert
            coreMethodsMock.Verify(x => x.PushPageModel<RecipeViewModel>(testRecipe.Object, false, true), Times.Once);
        }

        [Fact]
        public void OpenRecipe_WithoutRecipe_DontExecutePushPageModel()
        {
            //Assert
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            var recipeService = new Mock<IRecipeService>();
            var categoryService = new Mock<ICategoryService>();
            var allRecipesViewModel = new AllRecipesViewModel(recipeService.Object, categoryService.Object);
            allRecipesViewModel.CoreMethods = coreMethodsMock.Object;

            //Act
            allRecipesViewModel.OpenRecipe.Execute(null);

            //Assert
            coreMethodsMock.Verify(x => x.PushPageModel<RecipeViewModel>(null, false, true), Times.Never);
        }
    }
}