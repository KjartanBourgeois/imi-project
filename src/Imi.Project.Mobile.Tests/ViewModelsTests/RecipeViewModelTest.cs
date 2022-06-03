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
    public class RecipeViewModelTest
    {
        private Mock<IRecipeService> recipeService;
        private Mock<IIngredientsService> ingredientService;

        public RecipeViewModelTest()
        {
            recipeService = new Mock<IRecipeService>();
            ingredientService = new Mock<IIngredientsService>();
        }

        [Theory]
        [InlineData("PageTitle")]
        [InlineData("ImageSource")]
        [InlineData("Instructions")]
        [InlineData("NumberOfPersons")]
        public void Init_WithValidInput_InvokedRaisePropertyChanged(string propChanged)
        {
            //Assert
            bool invoked = false;

            ThemeResponseDto testTheme = new ThemeResponseDto();
            testTheme.Id = Guid.NewGuid();
            testTheme.Name = "TestTheme";

            CategoryResponseDto testCategory = new CategoryResponseDto();
            testCategory.Id = Guid.NewGuid();
            testCategory.Name = "TestCategory";

            KitchenResponseDto testKitchen = new KitchenResponseDto();
            testKitchen.Id = Guid.NewGuid();
            testKitchen.Name = "TestKitchen";

            RecipeResponseDto initData = new RecipeResponseDto();
            initData.Id = Guid.NewGuid();
            initData.Name = "Test";
            initData.Image = "Test";
            initData.Instructions = "Test";
            initData.NumberOfPersons = 1;
            initData.WebsiteLink = new Uri("http://www.google.com");
            initData.Theme = testTheme;
            initData.Category = testCategory;
            initData.Kitchen = testKitchen;

            var testViewModel = new RecipeViewModel(recipeService.Object);
            //Act
            testViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals(propChanged)) invoked = true;
            };

            testViewModel.Init(initData);

            //Assert
            Assert.True(invoked);
        }
    }
}