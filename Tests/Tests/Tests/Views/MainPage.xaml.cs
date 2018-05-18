using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tests.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}
	}
}