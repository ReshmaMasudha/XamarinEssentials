using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppInfoPage : ContentPage
    {
        public AppInfoPage()
        {
            InitializeComponent();
            LabelApp.Text = $"{ AppInfo.Name}";
            LabelVersionInfo.Text = $"{ AppInfo.VersionString}";
        }

        private void check_theme_Clicked(object sender, EventArgs e)
        {
            //var currentTheme = Xamarin.Essentials.AppInfo.RequestedTheme;
            //var Theme = $"The current theme is:{currentTheme}";
            //DisplayAlert("Theme Details", Theme, "Ok");
        }
    }
}