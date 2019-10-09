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
	public partial class TCadastroEmpregados : ContentPage
	{
		public TCadastroEmpregados ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            Classe.CFuncionario CF = new Classe.CFuncionario();
            bool Inserir = CF.Cadastrar(entryCPF.Text,entryCep.Text,entryRG.Text,entryInformacoes.Text);
        }
    }
}