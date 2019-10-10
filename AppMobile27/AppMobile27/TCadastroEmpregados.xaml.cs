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
        
        public TCadastroEmpregados()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
        }
        Classe.CFuncionario CF = new Classe.CFuncionario();

        private void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(entryCPF.Text) ||
                !string.IsNullOrEmpty(entryCep.Text) ||
                !string.IsNullOrEmpty(entryRG.Text) ||
                !string.IsNullOrEmpty(entryInformacoes.Text))
            {

                bool Inserir = CF.Cadastrar(entryNome.Text,entryCPF.Text, entryCep.Text, entryRG.Text, entryInformacoes.Text);



                if (Inserir == true)
                {
                    DisplayAlert("Certo", "Funcionario Cadastrado", "OK");
                }
                else
                {
                    DisplayAlert("Erro", "Ocorreu um erro no App", "OK");
                }
            }


        }
        

        private void ButtonListagem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListarFuncionarioxaml());
        }
    }
}