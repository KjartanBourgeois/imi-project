using Imi.Project.Common.Dto;
using Imi.Project.Wpf.Core.Services.Api;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ApiRecipeService _recipeService;

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<RecipeResponseDto> recipes;

        public ObservableCollection<RecipeResponseDto> Recipes
        {
            get { return recipes; }
            set
            {
                recipes = value;
                OnPropertyChanged(nameof(Recipes));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            _recipeService = new ApiRecipeService();
            btnUpdate.IsEnabled = false;
            btnDelete.IsEnabled = false;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var login = new LoginScreen();
            login.ShowDialog();
            await LoadRecipes();
        }

        private async Task LoadRecipes()
        {
            var recipes = await _recipeService.GetAllRecipes();
            Recipes = null;
            Recipes = new ObservableCollection<RecipeResponseDto>(recipes);
            lstRecipes.ItemsSource = Recipes;
            lstRecipes.DisplayMemberPath = "Name";
        }

        private void lstRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnUpdate.IsEnabled = true;
            btnDelete.IsEnabled = true;
            var recipe = (RecipeResponseDto)lstRecipes.SelectedItem;

            if (recipe == null)
            {
                ClearRecipeDetails();
            }
            else
            {
                GetRecipeDetails(recipe);
            }
        }

        private void GetRecipeDetails(RecipeResponseDto recipe)
        {
            lblName.Content = recipe.Name;
            lblCategory.Content = recipe.Category.Name;
            lblKitchen.Content = recipe.Kitchen.Name;
            lblTheme.Content = recipe.Theme.Name;
            lblNumerOfPersons.Content = recipe.NumberOfPersons;
            BitmapImage recipeImage = new BitmapImage();
            recipeImage.BeginInit();
            recipeImage.UriSource = new Uri(recipe.Image);
            recipeImage.EndInit();
            imgRecipe.Source = recipeImage;
            lblWebsite.Content = recipe.WebsiteLink;
        }

        private void ClearRecipeDetails()
        {
            lblName.Content = string.Empty;
            lblCategory.Content = string.Empty;
            lblKitchen.Content = string.Empty;
            lblTheme.Content = string.Empty;
            lblNumerOfPersons.Content = string.Empty;
            imgRecipe.Source = null;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var selectedRecipe = (RecipeResponseDto)lstRecipes.SelectedItem;
            var updateScreen = new UpdateView(selectedRecipe);
            updateScreen.Show();
        }

        private void RefreshList()
        {
            lstRecipes.Items.Refresh();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            var newScreen = new NewRecipe();
            newScreen.Show();
        }

        private async void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            await LoadRecipes();
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedRecipe = (RecipeResponseDto)lstRecipes.SelectedItem;
            var deleteView = new DeleteView(selectedRecipe);
            deleteView.Show();
        }
    }
}