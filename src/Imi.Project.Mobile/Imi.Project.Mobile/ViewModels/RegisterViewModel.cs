using FreshMvvm;
using System;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class RegisterViewModel : FreshBasePageModel
    {
        #region properties

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        private bool terms;

        public bool Terms
        {
            get { return terms; }
            set { terms = value; }
        }

        #endregion properties

        public override void Init(object initData)
        {
            base.Init(initData);
            UserName = "Gebruikersnaam";
            EmailAddress = "@mail.be";
            Password = "";
            DateOfBirth = DateTime.Today;
            Terms = false;
        }

        public ICommand Register => new Command(() => RegisterUser());

        private void RegisterUser()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Gebruikersnaam is {UserName}");
            sb.AppendLine($"Geboortedatum is {DateOfBirth.ToShortDateString()}");
            sb.AppendLine($"Emailadres is {EmailAddress}");
            sb.AppendLine($"Wachtwoord is {Password}");
            sb.AppendLine($"Voorwaarden? {Terms}");

            sb.ToString();
            CoreMethods.DisplayAlert("Uw Gegevens", $"{sb}", "Ga door");
        }
    }
}