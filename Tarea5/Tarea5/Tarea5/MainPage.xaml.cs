using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea5.Controls;
using Tarea5.Services;
using Tarea5.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Tarea5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new DependencyServiceViewModel();

      //      Content = new StackLayout
      //      {
      //          Children = {
      //  new Label {
      //    Text = "Hello, Custom Renderer !",
      //  },
      //  new MyEntry {
      //    Text = "In Shared Code",
      //  }
      //},
      //          VerticalOptions = LayoutOptions.CenterAndExpand,
      //          HorizontalOptions = LayoutOptions.CenterAndExpand,
      //      };


        }

       
    }
}
