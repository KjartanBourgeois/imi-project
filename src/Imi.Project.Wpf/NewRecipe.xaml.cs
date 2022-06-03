using Imi.Project.Common.Dto;
using Imi.Project.Wpf.Core.Services.Api;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for NewRecipe.xaml
    /// </summary>
    public partial class NewRecipe : Window
    {
        private RecipeRequestDto newRecipe = new RecipeRequestDto();
        private readonly ApiRecipeService _apiRecipeService;
        private readonly ApiCategoryService _apiCategoryService;
        private readonly ApiKitchenService _apiKitchenService;
        private readonly ApiThemeService _apiThemeService;
        private IEnumerable<CategoryResponseDto> categories;
        private IEnumerable<KitchenResponseDto> kitchens;
        private IEnumerable<ThemeResponseDto> themes;
        private bool isValidated = false;

        public NewRecipe()
        {
            InitializeComponent();
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
            LoadData();
        }

        private void btnAddInstruction_Click(object sender, RoutedEventArgs e)
        {
            string instruction = $"{txtInstruction.Text};";
            if (string.IsNullOrWhiteSpace(instruction)) return;

            lstInstructions.Items.Add(instruction);
            lstInstructions.Items.Refresh();
            txtInstruction.Text = "";
        }

        private async void btnAddNewRecipe_Click(object sender, RoutedEventArgs e)
        {
            BindToNewRecipe();
            if (!isValidated) { MessageBox.Show("WebsiteUrl is niet correct", "Error"); return; }

            await _apiRecipeService.AddRecipe(newRecipe, Application.Current.Properties["JWT"].ToString());
            this.Close();
        }

        private async void LoadData()
        {
            cmbCategories.Items.Clear();
            cmbKitchens.Items.Clear();
            cmbThemes.Items.Clear();

            categories = await _apiCategoryService.GetAllCategories();
            kitchens = await _apiKitchenService.GetAllKitchens();
            themes = await _apiThemeService.GetAllThemes();

            cmbCategories.ItemsSource = categories;
            cmbKitchens.ItemsSource = kitchens;
            cmbThemes.ItemsSource = themes;

            cmbCategories.DisplayMemberPath = "Name";
            cmbKitchens.DisplayMemberPath = "Name";
            cmbThemes.DisplayMemberPath = "Name";
        }

        private void BindToNewRecipe()
        {
            newRecipe.Id = Guid.NewGuid();
            newRecipe.Name = txtRecipeName.Text;
            newRecipe.CategoryId = ((CategoryResponseDto)cmbCategories.SelectedItem).Id;
            newRecipe.KitchenId = ((KitchenResponseDto)cmbKitchens.SelectedItem).Id;
            newRecipe.ThemeId = ((ThemeResponseDto)cmbThemes.SelectedItem).Id;
            newRecipe.Instructions = ConvertListStringsToString();
            newRecipe.Image = txtImageLink.Text;
            newRecipe.WebsiteLink = new Uri($"{txtWebsiteLink.Text}");
            ValidateUri(txtWebsiteLink.Text);
            newRecipe.NumberOfPersons = int.Parse(txtNumberOfPersons.Text);
        }

        private string ConvertListStringsToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in lstInstructions.Items)
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