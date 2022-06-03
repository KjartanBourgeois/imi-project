using FreshMvvm;
using Imi.Project.Common.Dto;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AllRecipesViewModel : FreshBasePageModel
    {
        private readonly IRecipeService _recipeService;
        private readonly ICategoryService _categoryService;

        public AllRecipesViewModel(IRecipeService recipeService, ICategoryService categoryService)
        {
            _recipeService = recipeService;
            _categoryService = categoryService;
        }

        #region Properties

        private ObservableCollection<RecipeResponseDto> recipes;

        public ObservableCollection<RecipeResponseDto> Recipes
        {
            get { return recipes; }
            set
            {
                recipes = value;
                RaisePropertyChanged(nameof(Recipes));
            }
        }

        private ObservableCollection<CategoryResponseDto> categories;

        public ObservableCollection<CategoryResponseDto> Categories
        {
            get { return categories; }
            set
            {
                categories = value;
                RaisePropertyChanged(nameof(Categories));
            }
        }

        #endregion Properties

        public override async void Init(object initData)
        {
            base.Init(initData);
            await RefreshRecipes();
            await BindCategories();
        }

        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            await RefreshRecipes();
        }

        public override async void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
            await RefreshRecipes();
            await BindCategories();
        }

        private async Task RefreshRecipes()
        {
            try
            {
                var recipes = await _recipeService.GetAllRecipes();
                Recipes = null;
                Recipes = new ObservableCollection<RecipeResponseDto>(recipes);
            }
            catch (Exception ex)
            {
                await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");
            }
        }

        private async Task BindCategories()
        {
            var categories = await _categoryService.GetAllCategories();
            Categories = null;
            Categories = new ObservableCollection<CategoryResponseDto>(categories);
        }

        public ICommand OpenRecipe => new Command<RecipeResponseDto>(
                async (RecipeResponseDto recipe) =>
                {
                    await CoreMethods.PushPageModel<RecipeViewModel>(recipe, false, true);
                }
            );
    }
}