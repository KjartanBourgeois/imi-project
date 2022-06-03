using FreshMvvm;
using Imi.Project.Common.Dto;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class RecipeEditViewModel : FreshBasePageModel
    {
        private RecipeResponseDto currentRecipe;
        private RecipeRequestDto newRecipe;
        private RecipeRequestDto updateRecipe;
        private bool isNew = true;
        private bool isValidated = false;
        private readonly IRecipeService _recipeService;
        private readonly ICategoryService _categoryService;
        private readonly IKitchenService _kitchenService;
        private readonly IThemeService _themeService;

        public RecipeEditViewModel(IRecipeService recipeService, ICategoryService categoryService, IKitchenService kitchenService, IThemeService themeService)
        {
            _recipeService = recipeService;
            _categoryService = categoryService;
            _kitchenService = kitchenService;
            _themeService = themeService;
        }

        #region Properties

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; RaisePropertyChanged(nameof(RecipeName)); }
        }

        private string recipeName;

        public string RecipeName
        {
            get { return recipeName; }
            set { recipeName = value; RaisePropertyChanged(nameof(RecipeName)); }
        }

        private int numberOfPersons;

        public int NumberOfPersons
        {
            get { return numberOfPersons; }
            set { numberOfPersons = value; RaisePropertyChanged(nameof(NumberOfPersons)); }
        }

        private ObservableCollection<CategoryResponseDto> categories;

        public ObservableCollection<CategoryResponseDto> Categories
        {
            get { return categories; }
            set { categories = value; RaisePropertyChanged(nameof(Categories)); }
        }

        private CategoryResponseDto selectedCategory;

        public CategoryResponseDto SelectedCategory
        {
            get { return selectedCategory; }
            set { selectedCategory = value; RaisePropertyChanged(nameof(SelectedCategory)); }
        }

        private ObservableCollection<KitchenResponseDto> kitchens;

        public ObservableCollection<KitchenResponseDto> Kitchens
        {
            get { return kitchens; }
            set { kitchens = value; RaisePropertyChanged(nameof(Kitchens)); }
        }

        private KitchenResponseDto selectedKitchen;

        public KitchenResponseDto SelectedKitchen
        {
            get { return selectedKitchen; }
            set { selectedKitchen = value; RaisePropertyChanged(nameof(SelectedKitchen)); }
        }

        private ObservableCollection<ThemeResponseDto> themes;

        public ObservableCollection<ThemeResponseDto> Themes
        {
            get { return themes; }
            set { themes = value; RaisePropertyChanged(nameof(Themes)); }
        }

        private ThemeResponseDto selectedTheme;

        public ThemeResponseDto SelectedTheme
        {
            get { return selectedTheme; }
            set { selectedTheme = value; RaisePropertyChanged(nameof(SelectedTheme)); }
        }

        private string imageLink;

        public string ImageLink
        {
            get { return imageLink; }
            set { imageLink = value; RaisePropertyChanged(nameof(RecipeName)); }
        }

        private ObservableCollection<string> instructions;

        public ObservableCollection<string> Instructions
        {
            get { return instructions; }
            set { instructions = value; RaisePropertyChanged(nameof(Instructions)); }
        }

        private string newInstruction;

        public string NewInstruction
        {
            get { return newInstruction; }
            set { newInstruction = value; RaisePropertyChanged(nameof(NewInstruction)); }
        }

        private string websiteUri;

        public string WebsiteUri
        {
            get { return websiteUri; }
            set { websiteUri = value; RaisePropertyChanged(nameof(WebsiteUri)); }
        }

        #endregion Properties

        public override async void Init(object initData)
        {
            base.Init(initData);
            RecipeResponseDto recipe = initData as RecipeResponseDto;

            if (recipe == null)
            {
                newRecipe = new RecipeRequestDto();
                Instructions = new ObservableCollection<string>();
                await BindPickers();
            }
            else
            {
                isNew = false;
                updateRecipe = new RecipeRequestDto();
                currentRecipe = recipe;
                LoadRecipeState();
                await BindPickers();
            }
        }

        private async Task BindPickers()
        {
            var categories = await _categoryService.GetAllCategories();
            var kitchens = await _kitchenService.GetAllKitchens();
            var themes = await _themeService.GetAllThemes();
            Categories = null;
            Kitchens = null;
            Themes = null;
            Categories = new ObservableCollection<CategoryResponseDto>(categories);
            Kitchens = new ObservableCollection<KitchenResponseDto>(kitchens);
            Themes = new ObservableCollection<ThemeResponseDto>(themes);
        }

        public override async void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
            if (returnedData is RecipeResponseDto)
            {
                LoadRecipeState();
                await BindPickers();
            }
        }

        private void LoadRecipeState()
        {
            Title = currentRecipe.Name;
            RecipeName = currentRecipe.Name;
            ImageLink = currentRecipe.Image;
            SelectedCategory = currentRecipe.Category;
            SelectedKitchen = currentRecipe.Kitchen;
            SelectedTheme = currentRecipe.Theme;
            WebsiteUri = currentRecipe.WebsiteLink.ToString();
            NumberOfPersons = currentRecipe.NumberOfPersons;
            Instructions = new ObservableCollection<string>(ConvertStringToListString());
        }

        private void SaveNewRecipeState()
        {
            newRecipe.Name = RecipeName;
            newRecipe.NumberOfPersons = NumberOfPersons;
            newRecipe.CategoryId = selectedCategory.Id;
            newRecipe.Image = ImageLink;
            newRecipe.KitchenId = selectedKitchen.Id;
            newRecipe.ThemeId = selectedTheme.Id;
            newRecipe.WebsiteLink = new Uri($"{WebsiteUri}");
            newRecipe.Instructions = ConvertListStringsToString();
        }

        private void UpdateRecipeState()
        {
            updateRecipe.Id = currentRecipe.Id;
            updateRecipe.Name = RecipeName;
            updateRecipe.NumberOfPersons = currentRecipe.NumberOfPersons;
            updateRecipe.CategoryId = currentRecipe.Category.Id;
            updateRecipe.Image = currentRecipe.Image;
            updateRecipe.KitchenId = currentRecipe.Kitchen.Id;
            updateRecipe.ThemeId = currentRecipe.Theme.Id;
            updateRecipe.WebsiteLink = currentRecipe.WebsiteLink;
            updateRecipe.Instructions = ConvertListStringsToString();
        }

        public ICommand AddNewInstruction => new Command(() => AddInstructions());

        public ICommand SaveRecipe => new Command(() => SaveNewRecipe());

        private async void SaveNewRecipe()
        {
            if (isNew)
            {
                ValidateUri(WebsiteUri);
                if (!isValidated)
                {
                    await CoreMethods.DisplayAlert("Error", "Link naar de website is niet correct", "Ga terug");
                    return;
                }
                SaveNewRecipeState();
                newRecipe.Id = Guid.NewGuid();
                await _recipeService.AddRecipe(newRecipe, Application.Current.Properties["JWT"].ToString());
            }
            else
            {
                UpdateRecipeState();
                ValidateUri(currentRecipe.WebsiteLink.ToString());
                if (!isValidated)
                {
                    await CoreMethods.DisplayAlert("Error", "Link naar de website is niet correct", "Ga terug");
                    return;
                }
                await _recipeService.UpdateRecipe(updateRecipe, Application.Current.Properties["JWT"].ToString());
            }

            await CoreMethods.DisplayAlert("Opslaan", "Het recept is opgeslaan", "Ok");
            await CoreMethods.PopPageModel(false, true);
        }

        private void AddInstructions()
        {
            if (!String.IsNullOrWhiteSpace(NewInstruction))
            {
                string formatInstruction = $"{NewInstruction}";
                Instructions.Add(formatInstruction);
            }
            NewInstruction = null;
        }

        private List<string> ConvertStringToListString()
        {
            var list = new List<string>();
            var splittedString = currentRecipe.Instructions.Split(';');

            foreach (var item in splittedString)
            {
                list.Add(item);
            }

            return list;
        }

        private string ConvertListStringsToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Instructions)
            {
                stringBuilder.Append(item.ToString());
            }
            return stringBuilder.ToString();
        }

        private void ValidateUri(string uri)
        {
            if (Uri.IsWellFormedUriString(uri, UriKind.Absolute)) isValidated = true;
        }
    }
}