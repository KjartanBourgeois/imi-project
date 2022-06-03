
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoriteRecipePage : ContentPage
    {
        public FavoriteRecipePage()
        {
            InitializeComponent();
            //BindingContext = new RecipeViewModel();
        }

        private void btnRecipe_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new RecipePage());
        }
    }
}