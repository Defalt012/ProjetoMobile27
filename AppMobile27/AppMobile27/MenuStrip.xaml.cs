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
	public partial class MenuStrip : MasterDetailPage
	{
		public MenuStrip ()
		{
			InitializeComponent ();
            Detail = new NavigationPage(new TMenu());
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void PaginaPedido_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TComodos());
            IsPresented = false;
        }

        private void PaginaConta_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TContaUsuario());
            IsPresented = false;
        }

        private void PaginaLimpar_Tapped(object sender, EventArgs e)
        {

        }

        private void PaginaParticipar_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TCadastroEmpregados());
            IsPresented = false;
        }
    }
}