using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class LoginViewModel : FreshBasePageModel
    {
        private readonly IAccountService _accountService;
        private readonly IBuzz _buzz;

        public LoginViewModel(IAccountService accountService, IBuzz buzz)
        {
            _accountService = accountService;
            _buzz = buzz;
        }

        #region Properties

        private string user;

        public string User
        {
            get { return user; }
            set { user = value; RaisePropertyChanged(nameof(User)); }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; RaisePropertyChanged(nameof(Email)); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; RaisePropertyChanged(nameof(Password)); }
        }

        #endregion Properties

        public override void Init(object initData)
        {
            Email = "Super.Admin@user.be";
            Password = "Test123?";
            base.Init(initData);
        }

        public ICommand Login => new Command(() => CheckCorrectLogin());
        public ICommand GoToRegisterPage => new Command(async () => await CoreMethods.PushPageModel<RegisterViewModel>());

        private async void CheckCorrectLogin()
        {
            if (CheckValidEmail(Email))
            {
                try
                {
                    var response = await _accountService.Login(Email, Password);
                    var jwtToken = response.JwtToken;
                    Application.Current.Properties["JWT"] = jwtToken;
                    var jwtHandler = new JwtSecurityTokenHandler();
                    var token = jwtHandler.ReadToken(jwtToken);
                    var jwtSecurityToken = token as JwtSecurityToken;
                    try
                    {
                        var role = jwtSecurityToken.Claims.First(claim => claim.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").Value;
                        if (role == "Admin" || role == "SuperAdmin")
                        {
                            Application.Current.MainPage = AdminNavigation();
                        }
                    }
                    catch
                    {
                        Application.Current.MainPage = UserNavigation();
                    }
                }
                catch
                {
                    await CoreMethods.DisplayAlert("Fout", "Uw login gegevens zijn niet correct", "Keer terug");
                    _buzz.Buzzer();
                }
            }
            else
            {
                await CoreMethods.DisplayAlert("Fout", "Uw login gegevens zijn niet correct", "Keer terug");
                _buzz.Buzzer();
            }
        }

        private bool CheckValidEmail(string email)
        {
            //Found on docs form microsoft

            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private FreshMasterDetailNavigationContainer AdminNavigation()
        {
            var masterNavigationAdmin = new FreshMasterDetailNavigationContainer();
            masterNavigationAdmin.Init($"Menu, Hello {User}");
            masterNavigationAdmin.AddPage<AllRecipesViewModel>("Alle Recepten", null);
            masterNavigationAdmin.AddPage<ProfileViewModel>("Mijn Profiel", null);
            masterNavigationAdmin.AddPage<ContactViewModel>("Contacteer ons", null);
            masterNavigationAdmin.AddPage<AdminViewModel>("Admin", null);

            return masterNavigationAdmin;
        }

        private FreshMasterDetailNavigationContainer UserNavigation()
        {
            var masterNavigationUser = new FreshMasterDetailNavigationContainer();
            masterNavigationUser.Init($"Menu, Hello {User}");
            masterNavigationUser.AddPage<AllRecipesViewModel>("Alle Recepten", null);
            masterNavigationUser.AddPage<ProfileViewModel>("Mijn Profiel", null);
            masterNavigationUser.AddPage<ContactViewModel>("Contacteer ons", null);

            return masterNavigationUser;
        }
    }
}