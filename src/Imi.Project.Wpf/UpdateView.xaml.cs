using Imi.Project.Common.Dto;
using Imi.Project.Wpf.Core.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for UpdateView.xaml
    /// </summary>
    public partial class UpdateView : Window
    {
        private RecipeResponseDto selectedDto;
        private RecipeRequestDto updateRecipe = new RecipeRequestDto();
        private readonly ApiRecipeService _apiRecipeService;
        private readonly ApiCategoryService _apiCategoryService;
        private readonly ApiKitchenService _apiKitchenService;
        private readonly ApiThemeService _apiThemeService;
        private IEnumerable<CategoryResponseDto> categories;
        private IEnumerable<KitchenResponseDto> kitchens;
        private IEnumerable<ThemeResponseDto> themes;
        private bool isValidated = false;

        public UpdateView(RecipeResponseDto dto)
        {
            InitializeComponent();
            selectedDto = dto;
            _apiCategoryService = new ApiCategoryService();
            _apiKitchenService = new ApiKitchenService();
            _apiThemeService = new ApiThemeService();
            _apiRecipeService = new ApiRecipeService();
            categories = new List<CategoryResponseDto>();
            themes = new List<ThemeResponseDto>();
            kitchens = new List<KitchenResponseDto>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadRecipeDetailsAsync(selectedDto);
        }

        private async void LoadRecipeDetailsAsync(RecipeResponseDto dto)
        {
            cmbCategory.Items.Clear();
            cmbKitchen.Items.Clear();
            cmbTheme.Items.Clear();

            categories = await _apiCategoryService.GetAllCategories();
            kitchens = await _apiKitchenService.GetAllKitchens();
            themes = await _apiThemeService.GetAllThemes();

            cmbCategory.ItemsSource = categories;
            cmbKitchen.ItemsSource = kitchens;
            cmbTheme.ItemsSource = themes;

            cmbCategory.DisplayMemberPath = "Name";
            cmbKitchen.DisplayMemberPath = "Name";
            cmbTheme.DisplayMemberPath = "Name";

            lblCurrentCategory.Content = $"Huidgie Categorie : {dto.Category.Name}";
            lblCurrentKitchen.Content = $"Huidgie Keuken : {dto.Kitchen.Name}";
            lblCurrentTheme.Content = $"Huidgie Thema : {dto.Theme.Name}";

            txtRecipeName.Text = dto.Name;
            txtNumberOfPersons.Text = dto.NumberOfPersons.ToString();
            txtImageLink.Text = dto.Image;
            txtWebsiteLink.Text = dto.WebsiteLink.ToString();
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateRecipe();
            if (!isValidated) { MessageBox.Show("WebsiteUrl is niet correct", "Error"); return; }
            await _apiRecipeService.UpdateRecipe(updateRecipe, Application.Current.Properties["JWT"].ToString());
            this.Close();
        }

        private void UpdateRecipe()
        {
            var selectedCategory = (CategoryResponseDto)cmbCategory.SelectedItem;
            var selectedKitchen = (KitchenResponseDto)cmbKitchen.SelectedItem;
            var selectedTheme = (ThemeResponseDto)cmbTheme.SelectedItem;

            updateRecipe.CategoryId = cmbCategory.SelectedItem == null ? selectedDto.Category.Id : selectedCategory.Id;
            updateRecipe.KitchenId = cmbKitchen.SelectedItem == null ? selectedDto.Kitchen.Id : selectedKitchen.Id;
            updateRecipe.ThemeId = cmbTheme.SelectedItem == null ? selectedDto.Theme.Id : selectedTheme.Id;

            updateRecipe.Id = selectedDto.Id;
            updateRecipe.Name = txtRecipeName.Text;
            updateRecipe.NumberOfPersons = int.Parse(txtNumberOfPersons.Text);
            updateRecipe.Image = txtImageLink.Text;
            updateRecipe.WebsiteLink = new Uri($"{txtWebsiteLink.Text}");
            ValidateUri(txtWebsiteLink.Text);
            updateRecipe.Instructions = ConvertListStringsToString();
        }

        private string ConvertListStringsToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in selectedDto.Instructions)
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