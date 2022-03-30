using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Sample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SampleTabbedPage : Xamarin.Forms.TabbedPage
	{
		public SampleTabbedPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            this.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);
        }

        public SampleTabbedPage(string name, string email)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            profilePage.Name = name;
            profilePage.Email = email;
            this.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);
        }
    }
}