using Imi.Project.Mobile.Core.Domain.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipePage : ContentPage
    {

        public RecipePage(Recipe recipe)
        {
            InitializeComponent();

        }


        //private async void btnShare_Clicked(object sender, System.EventArgs e)
        //{
        //    await Share.RequestAsync(new ShareTextRequest { Uri = currentRecipe.WebsiteLink.ToString(), Text = "Deel dit recept" });
        //}
    }
}