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
    public partial class EmailComposition : ContentPage
    {
        public EmailComposition()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var message = new EmailMessage(EmailEntry.Text,"", SubjectEntry.Text);
            Email.ComposeAsync(message);
        }
    }
}