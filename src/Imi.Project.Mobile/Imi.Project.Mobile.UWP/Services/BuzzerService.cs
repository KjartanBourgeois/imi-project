using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.Phone.Devices.Notification;

[assembly: Xamarin.Forms.Dependency(typeof(Imi.Project.Mobile.UWP.Services.BuzzerService))]

namespace Imi.Project.Mobile.UWP.Services
{
    public class BuzzerService : IBuzz
    {
        public void Buzzer()
        {
            if (ApiInformation.IsTypePresent("Windows.Phone.Devices.Notification.VibrationDevice"))
            {
                VibrationDevice testVibrationDevice = VibrationDevice.GetDefault();
                testVibrationDevice.Vibrate(TimeSpan.FromSeconds(3));
            }
        }
    }
}