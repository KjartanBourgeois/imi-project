using FreshMvvm;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class ContactViewModel : FreshBasePageModel
    {
        #region properties

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        #endregion

        public ICommand SendMessage => new Command(async () => await SendEmail());

        private async Task SendEmail()
        {
            var emailMessage = new EmailMessage($"Contact,{Name},{emailAddress}", Message, "kjartan.bourgeois@student.howest.be");
            await Email.ComposeAsync(emailMessage);
        }
    }
}
