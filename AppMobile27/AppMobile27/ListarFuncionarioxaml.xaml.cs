using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMobile27.Classe;     
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMobile27
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListarFuncionarioxaml : ContentPage
	{
		public ListarFuncionarioxaml ()
		{
			InitializeComponent ();
            CarregarDados();
		}

        Classe.CFuncionario CF = new Classe.CFuncionario();
        private void CarregarDados()
        {
            var lista = CF.SelecionarDados();
            listViewFuncionario.ItemsSource = lista;
        }

        

        private async void MenuItemApagarFuncionario_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmação", "tem certeza que deseja deletar?", "SIM", "NÃO");
            if (resposta == true)
            {
                try
                {
                    var menu = (MenuItem)sender;
                    var model = (ModelFuncionario)menu.CommandParameter;
                    var Deletar = CF.Deletar(model.ID);

                    if (Deletar == true)
                    {
                        await DisplayAlert("Certo!", "Apagado", "OK");
                        CarregarDados();
                    }
                    else
                    {
                        await DisplayAlert("Erro", "Ocorreu um erro", "OK");
                    }
                }
                catch (Exception ex)
                {
                    await DisplayAlert("ERRO", ex.Message, "OK");
                }
            }
        }

        private async void MenuItemApagarTudoFuncionario_Clicked(object sender, EventArgs e)
        {
            var respostaConfirmacao = await DisplayAlert("Confimação", "tem certeza que deseja deletar todas as informações?", "SIM", "NÃO");
            if (respostaConfirmacao == true)
            {
                try
                {
                    var resultadoDeleteAll = CF.ApagarTudo();

                    if (resultadoDeleteAll == true)
                    {
                        await DisplayAlert("CERTO", "Inserido", "OK");
                        CarregarDados();
                    }
                    else
                    {
                        await DisplayAlert("ERRO", "Houve um erro", "OK");
                    }
                }
                catch (Exception ex)
                {
                    await DisplayAlert("ERRO", ex.Message, "OK");
                }
            }
            
        }

        private void ButtonAdicionar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TCadastroEmpregados());
        }
    }
}