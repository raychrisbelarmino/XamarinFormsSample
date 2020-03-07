using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(NameEntry.Text) && !string.IsNullOrEmpty(EmailEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
            {
                if (PasswordEntry.Text.Equals("MasterDetailPage"))
                    await Navigation.PushAsync(new MainMasterDetailPage(NameEntry.Text, EmailEntry.Text), true);
                else if (PasswordEntry.Text.Equals("TabbedPage"))
                    await Navigation.PushAsync(new SampleTabbedPage(NameEntry.Text, EmailEntry.Text), true);
                else
                    await DisplayAlert("Error", "Account does not exist", "Okay");
            }
            else
            {
                bool retryBool = await DisplayAlert("Error", "Please fill in all fields. Retry?", "Yes","No");
                if (retryBool)
                {
                    NameEntry.Text = string.Empty;
                    EmailEntry.Text = string.Empty;
                    PasswordEntry.Text = string.Empty;
                    NameEntry.Focus();
                }
            }
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            NameEntry.Text = string.Empty;
            EmailEntry.Text = string.Empty;
            PasswordEntry.Text = string.Empty;
        }
    }
}
