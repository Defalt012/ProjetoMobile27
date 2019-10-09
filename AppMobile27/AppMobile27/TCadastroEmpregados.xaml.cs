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
        Classe.CFuncionario CF = new Classe.CFuncionario();
        public TCadastroEmpregados()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            CarregarDados();
        }

        private void CarregarDados()
        {
            var itens = CF.SelecionarDados();
            listviewEmpregados.ItemsSource = itens;
        }

        private void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(entryCPF.Text) ||
                !string.IsNullOrEmpty(entryCep.Text) ||
                !string.IsNullOrEmpty(entryRG.Text) ||
                !string.IsNullOrEmpty(entryInformacoes.Text))
            {

                bool Inserir = CF.Cadastrar(entryCPF.Text, entryCep.Text, entryRG.Text, entryInformacoes.Text);



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
        private void ButtonAtualizar_Clicked(object sender, EventArgs e)
        {
            bool Atualizar = CF.Atualizar(entryCPF.Text, entryCep.Text, entryRG.Text, entryInformacoes.Text,Convert.ToInt32(entryID.Text));

            if (Atualizar == true)
            {
                DisplayAlert("Certo","Atualizou com sucesso","OK");
            }
            else
            {
                DisplayAlert("Erro", "Ocorreu um erro no App", "OK");
            }
        }

        private void ButtonDelete_Clicked(object sender, EventArgs e)
        {

        }
    }
}