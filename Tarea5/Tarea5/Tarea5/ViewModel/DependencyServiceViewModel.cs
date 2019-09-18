using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Tarea5.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Tarea5.ViewModel
{
    public class DependencyServiceViewModel
    {
        public ICommand GetDeviceOrientation { get; set; }

        public DependencyServiceViewModel()
        {
            GetDeviceOrientation = new Command(() =>
            {
          
                DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
                App.Current.MainPage.DisplayAlert("Orientation:", orientation.ToString(), "Ok");
            });
        }




    }
}

