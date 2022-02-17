using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Sample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ControlsPage : ContentPage
	{
		public ControlsPage ()
		{
			InitializeComponent ();
			On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
		}
	}
}