using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SampleTabbedPage : TabbedPage
	{
		public SampleTabbedPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            profilePage.LogoutButton.Clicked += LogoutButton_Clicked;
        }

        private async void LogoutButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(true);
        }

        public SampleTabbedPage(string name, string email)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            profilePage.LogoutButton.Clicked += LogoutButton_Clicked;
            profilePage.Name = name;
            profilePage.Email = email;
        }
    }
}