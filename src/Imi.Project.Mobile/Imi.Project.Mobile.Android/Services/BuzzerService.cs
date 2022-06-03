using Android.Content;
using Android.OS;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(Imi.Project.Mobile.Droid.Services.BuzzerService))]

namespace Imi.Project.Mobile.Droid.Services
{
    public class BuzzerService : IBuzz
    {
        public void Buzzer()
        {
            using (var vib = (Vibrator)Android.App.Application.Context.GetSystemService(Context.VibratorService))
            {
                vib.Vibrate(5000);
            }
        }
    }
}