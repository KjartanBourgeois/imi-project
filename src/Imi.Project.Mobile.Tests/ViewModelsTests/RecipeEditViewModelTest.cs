using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.ViewModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xunit;

namespace Imi.Project.Mobile.Tests.ViewModelsTests
{
    public class RecipeEditViewModelTest
    {
        private Mock<IRecipeService> recipeService;
        private Mock<ICategoryService> categoryService;
        private Mock<IKitchenService> kitchenService;
        private Mock<IThemeService> themeService;

        public RecipeEditViewModelTest()
        {
            recipeService = new Mock<IRecipeService>();
            categoryService = new Mock<ICategoryService>();
            kitchenService = new Mock<IKitchenService>();
            themeService = new Mock<IThemeService>();
        }

        [Theory]
        [InlineData("Categories")]
        [InlineData("Kitchens")]
        [InlineData("Themes")]
        [InlineData("Instructions")]
        public void Init_WithValidInput_InvokedRaisePropertyChanged(string propChanged)
        {
            //Assert
            bool invoked = false;
            object initData = new object();

            var testViewModel = new RecipeEditViewModel(recipeService.Object, categoryService.Object, kitchenService.Object, themeService.Object);

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
        public void AddNewInstruction_WithValidInput_ExecuteCorrectPrivateMethod()
        {
            //Assert
            var expectedMethodName = "AddInstructions";
            Type testType = typeof(RecipeEditViewModel);
            MethodInfo testMethod = testType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(m => m.Name == "AddInstructions" && m.IsPrivate).First();

            var testViewModel = new RecipeEditViewModel(recipeService.Object, categoryService.Object, kitchenService.Object, themeService.Object);

            //Act
            testViewModel.AddNewInstruction.Execute(null);

            //Assert
            Assert.Equal(testMethod.Name, expectedMethodName);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddNewInstruction_WithNullOrEmptyStringInstruction_ReturnsNewInstructionNull(string instruction)
        {
            //Assert
            Type testType = typeof(RecipeEditViewModel);
            MethodInfo testMethod = testType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(m => m.Name == "AddInstructions" && m.IsPrivate).First();

            var testViewModel = new RecipeEditViewModel(recipeService.Object, categoryService.Object, kitchenService.Object, themeService.Object);
            testViewModel.NewInstruction = instruction;

            //Act
            testViewModel.AddNewInstruction.Execute(null);

            //Assert
            Assert.Null(testViewModel.NewInstruction);
        }

        [Fact]
        public void AddNewInstruction_WithValidInstructionInput_AddsInstructionToList()
        {
            //Assert
            string testInstruction = "NewInstruction";
            Type testType = typeof(RecipeEditViewModel);
            MethodInfo testMethod = testType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(m => m.Name == "AddInstructions" && m.IsPrivate).First();

            var testViewModel = new RecipeEditViewModel(recipeService.Object, categoryService.Object, kitchenService.Object, themeService.Object);
            testViewModel.NewInstruction = testInstruction;
            testViewModel.Instructions = new ObservableCollection<string>();

            //Act
            testViewModel.AddNewInstruction.Execute(null);

            //Assert
            Assert.NotEmpty(testViewModel.Instructions);
            Assert.Equal(testViewModel.Instructions.First(), testInstruction);
        }

        [Fact]
        public void SaveRecipe_WithValidInput_ExecuteCorrectPrivateMethod()
        {
            // Assert

            var expectedMethodName = "SaveNewRecipe";
            Type testType = typeof(RecipeEditViewModel);
            MethodInfo testMethod = testType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(m => m.Name == "SaveNewRecipe" && m.IsPrivate).First();

            var testViewModel = new RecipeEditViewModel(recipeService.Object, categoryService.Object, kitchenService.Object, themeService.Object);

            //Act
            testViewModel.AddNewInstruction.Execute(null);

            //Assert
            Assert.Equal(testMethod.Name, expectedMethodName);
        }

        [Fact]
        public void SaveRecipe_WithUnvalidWebsiteUri_ExecutedCoreMethods()
        {
            //Arrange
            var coreMethodsMock = new Mock<FreshMvvm.IPageModelCoreMethods>();
            var testViewModel = new RecipeEditViewModel(recipeService.Object, categoryService.Object, kitchenService.Object, themeService.Object);
            testViewModel.CoreMethods = coreMethodsMock.Object;

            //Act
            testViewModel.SaveRecipe.Execute(null);

            //Assert
            coreMethodsMock.Verify(x => x.DisplayAlert("Error", "Link naar de website is niet correct", "Ga terug"), Times.Once);
        }
    }
}