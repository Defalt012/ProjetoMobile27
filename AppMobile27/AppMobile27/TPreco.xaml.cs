using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMobile27
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TPreco : ContentPage
	{
		public TPreco ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonFinalizar_Clicked(object sender, EventArgs e)
        {

        }
    }
}