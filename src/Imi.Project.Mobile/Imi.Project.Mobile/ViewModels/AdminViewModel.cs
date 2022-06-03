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
    public class AdminViewModel : FreshBasePageModel
    {
        private readonly IRecipeService _recipeService;

        public AdminViewModel(IRecipeService recipeService)
        {
            _recipeService = recipeService;
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

        #endregion Properties

        public override async void Init(object initData)
        {
            base.Init(initData);
            await RefreshRecipes();
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
        }

        private async Task RefreshRecipes()
        {
            var recipes = await _recipeService.GetAllRecipes();
            Recipes = null;
            Recipes = new ObservableCollection<RecipeResponseDto>(recipes);
        }

        public ICommand AddNewRecipe => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<RecipeEditViewModel>();
            }
        );

        public ICommand OpenRecipeEditPage => new Command<RecipeResponseDto>(
            async (RecipeResponseDto recipe) =>
            {
                await CoreMethods.PushPageModel<RecipeEditViewModel>(recipe, false, true);
            }
        );

        public ICommand Delete => new Command<RecipeResponseDto>(
            async (RecipeResponseDto recipe) =>
            {
                await CoreMethods.DisplayAlert("Verwijderen", "Je staat op het punt dit recept te verwijderen", "Verwijder");
                await _recipeService.DeleteRecipe(recipe.Id, Application.Current.Properties["JWT"].ToString());
                await CoreMethods.DisplayAlert("Verwijderd", "Het recept is verwijderd", "OKe");
                await RefreshRecipes();
            }
        );
    }
}