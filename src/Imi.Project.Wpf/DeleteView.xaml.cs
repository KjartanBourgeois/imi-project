using Imi.Project.Common.Dto;
using Imi.Project.Wpf.Core.Services.Api;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for DeleteView.xaml
    /// </summary>
    public partial class DeleteView : Window
    {
        private RecipeResponseDto selectedDto;
        private readonly ApiRecipeService _apiRecipeService;

        public DeleteView(RecipeResponseDto dto)
        {
            InitializeComponent();
            selectedDto = dto;
            _apiRecipeService = new ApiRecipeService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            lblRecipeName.Content = selectedDto.Name;
            lblCurrentCategory.Content = selectedDto.Category.Name;
            lblCurrentKitchen.Content = selectedDto.Kitchen.Name;
            lblCurrentTheme.Content = selectedDto.Theme.Name;
            lblImageLink.Content = selectedDto.Image;
            lblNumberOfPersons.Content = selectedDto.NumberOfPersons.ToString();
            lblWebsiteLink.Content = selectedDto.WebsiteLink.ToString();
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var messageBox = MessageBox.Show("Bent u zeker dat u dit recept wilt verwijderen?", "Verwijderen", MessageBoxButton.OKCancel);
            switch (messageBox)
            {
                case MessageBoxResult.OK:
                    await _apiRecipeService.DeleteRecipe(selectedDto.Id, Application.Current.Properties["JWT"].ToString());
                    this.Close();
                    break;

                case MessageBoxResult.Cancel:
                    this.Close();
                    break;
            }
        }
    }
}