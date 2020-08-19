using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Flashlight : ContentPage
    {
        public Flashlight()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Xamarin.Essentials.Flashlight.TurnOnAsync();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Xamarin.Essentials.Flashlight.TurnOffAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}