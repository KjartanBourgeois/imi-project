using FreshMvvm;
using Imi.Project.Common.Dto;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class RecipeViewModel : FreshBasePageModel
    {
        private readonly IRecipeService _recipeService;
        private readonly IIngredientsService ingredientService;
        private RecipeResponseDto currentRecipe;

        public RecipeViewModel(IRecipeService recipeService)
        {
            _recipeService = recipeService;
            ingredientService = new MockIngredientsService(); // N/A from API
        }

        #region Properties

        private string pageTitle;

        public string PageTitle
        {
            get { return pageTitle; }
            set { pageTitle = value; RaisePropertyChanged(nameof(PageTitle)); }
        }

        private ImageSource imageSource;

        public ImageSource ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; RaisePropertyChanged(nameof(ImageSource)); }
        }

        private string instructions;

        public string Instructions
        {
            get { return instructions; }
            set { instructions = value; RaisePropertyChanged(nameof(Instructions)); }
        }

        private string ingredients;

        public string Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        private string numberOfPersons;

        public string NumberOfPersons
        {
            get { return numberOfPersons; }
            set { numberOfPersons = value; RaisePropertyChanged(nameof(NumberOfPersons)); }
        }

        #endregion Properties

        public override async void Init(object initData)
        {
            base.Init(initData);

            currentRecipe = initData as RecipeResponseDto;

            //var recipe = await _recipeService.GetRecipe(currentRecipe.Id);

            await RefreshRecipe();
        }

        private async Task RefreshRecipe()
        {
            GetIngredients();
            GetInstructions();
            PageTitle = currentRecipe.Name;
            NumberOfPersons = $"Aantal Personen: {currentRecipe.NumberOfPersons}";
            ImageSource = currentRecipe.Image;
        }

        private async void GetIngredients()
        {
            var ingredients = await ingredientService.GetAllByRecipeId(currentRecipe.Id);

            StringBuilder sb = new StringBuilder();
            foreach (var item in ingredients)
            {
                sb.AppendLine($"- {item.Amount} {item.Unit} {item.Name}");
            }
            Ingredients = sb.ToString();
        }

        private void GetInstructions()
        {
            StringBuilder sb = new StringBuilder();
            var strings = currentRecipe.Instructions;
            strings.Replace("-", "");
            var splittedStrings = strings.Split(';');

            foreach (string s in splittedStrings)
            {
                sb.Append($"- {s} \n");
            }

            Instructions = sb.ToString();
        }

        public ICommand ShareRecipe => new Command(async () => await ShareRecipeAsync());

        private async Task ShareRecipeAsync()
        {
            await Share.RequestAsync(new ShareTextRequest { Uri = currentRecipe.WebsiteLink.ToString(), Text = "Deel dit recept" });
        }
    }
}