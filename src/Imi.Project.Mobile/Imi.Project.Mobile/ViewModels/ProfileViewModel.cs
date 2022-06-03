using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class ProfileViewModel : FreshBasePageModel
    {
        #region Properties

        private ImageSource profileImageSource;

        public ImageSource ProfileImageSource
        {
            get { return profileImageSource; }
            set { profileImageSource = value; }
        }

        #endregion Properties

        public override void Init(object initData)
        {
            base.Init(initData);
            BindProperties();
        }

        private void BindProperties()
        {
            ProfileImageSource = "local:ImageResource Imi.Project.Mobile.Images.profileholder.jpg";
        }

        public ICommand GoToFavoritePage => new Command(async () => await CoreMethods.PushPageModel<FavoriteRecipeViewModel>());
        public ICommand GoToMyPhotosPage => new Command(async () => await CoreMethods.PushPageModel<PhotosViewModel>());
        public ICommand GoToSettingsPage => new Command(async () => await CoreMethods.PushPageModel<SettingsViewModel>());
    }
}