using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMobile27
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonLogar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryNome.Text)||
                !string.IsNullOrEmpty(entrySenha.Text))
            {


                Classe.CUsuario CU = new Classe.CUsuario();
                bool Logar = CU.Login(entryNome.Text, entrySenha.Text);
                Navigation.PushAsync(new MenuStrip());

            }
            else
            {
                DisplayAlert("Erro", "Ocorreu um erro no App", "OK");
            }
      
            
        }


        private void ButtonCriarConta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Vi());

        }
    }
}
