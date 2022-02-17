using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;


namespace Sample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SampleTabbedPage : TabbedPage
	{
		public SampleTabbedPage ()
		{
			InitializeComponent ();
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        public SampleTabbedPage(string name, string email)
        {
            InitializeComponent();
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            profilePage.Name = name;
            profilePage.Email = email;
        }
    }
}