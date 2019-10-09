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
	public partial class Vi : ContentPage
	{
		public Vi ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(entryNomePessoa.Text) ||
            //   string.IsNullOrEmpty(entryNomeUsuario.Text) ||
            //   string.IsNullOrEmpty(entrySenha.Text)||
            //   string.IsNullOrEmpty(entryEmail.Text)||
            //   string.IsNullOrEmpty(entryCEP.Text))

            
            //{
                Classe.CUsuario AcessoUsuario = new Classe.CUsuario();
                bool Resultado = AcessoUsuario.CadastrarUsuario(entryNomePessoa.Text, entryNomeUsuario.Text, entryEmail.Text, entrySenha.Text, entryCEP.Text);
                Navigation.PushAsync(new MainPage());

            //}
            //else
            //{
            //    DisplayAlert("Erro","°Não deixe os campos vazios !!!","OK");
            //}
        }
    }
}