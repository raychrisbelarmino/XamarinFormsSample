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
            //Temp
            /**/
            NameEntry.Text = "Name";
            EmailEntry.Text = "Email@gmail.com";
            PasswordEntry.Text = "TabbedPage";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(NameEntry.Text) && !string.IsNullOrEmpty(EmailEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
            {
                if (PasswordEntry.Text.Equals("MasterDetailPage"))
                    Application.Current.MainPage = new MainMasterDetailPage(NameEntry.Text, EmailEntry.Text);
                else if (PasswordEntry.Text.Equals("TabbedPage"))
                    Application.Current.MainPage = new SampleTabbedPage(NameEntry.Text, EmailEntry.Text);
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

        protected async override void OnAppearing()
        {
            base.OnAppearing();


            //logo.Rotation = 90;//animation without time
            //await logo.RotateTo(90, 5000);//animation with time

            //logo.Scale = 2;//animation without time
            //await logo.ScaleTo(2, 5000);//animation with time

            //logo.TranslationX = 50;//animation without time
            //logo.TranslationY = 50;//animation without time
            //await logo.TranslateTo(50, 50, 5000);//animation with time

            //logo.Opacity = 0.5;//animation without time
            //await logo.FadeTo(0.1, 5000);//animation with time
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            NameEntry.Text = string.Empty;
            EmailEntry.Text = string.Empty;
            PasswordEntry.Text = string.Empty;
        }

        private async void SignUp_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignupPage(), true);
        }
    }
}
