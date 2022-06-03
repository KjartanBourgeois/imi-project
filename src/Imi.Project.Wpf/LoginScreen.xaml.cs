using Imi.Project.Wpf.Core.Services.Api;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using System.Windows;

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        private readonly ApiAccountService _accountService;
        public bool isSucces = false;

        public LoginScreen()
        {
            InitializeComponent();
            _accountService = new ApiAccountService();
            txtEmail.Text = "Super.Admin@user.be";
            txtPassword.Password = "Test123?";
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            await CheckCorrectLoginAsync();
            if (isSucces)
            {
                MessageBox.Show("Login correct");
                this.Close();
            }
            else
            {
                MessageBox.Show("Login is niet correct");
            }
        }

        private async Task CheckCorrectLoginAsync()
        {
            var response = await _accountService.Login(txtEmail.Text, txtPassword.Password);
            var jwtToken = response.JwtToken;
            Application.Current.Properties["JWT"] = jwtToken;
            var jwtHandler = new JwtSecurityTokenHandler();
            var token = jwtHandler.ReadToken(jwtToken);
            isSucces = true;
        }
    }
}