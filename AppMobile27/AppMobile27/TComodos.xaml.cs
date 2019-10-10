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
	public partial class TComodos : ContentPage
	{
        int Cozinha = 0;
        int Sala = 0;
        int Quarto = 0;
        int Banheiro = 0;

        public TComodos ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonSubtrair1_Clicked(object sender, EventArgs e)
        {
            Quarto = Quarto - 1;
            labelQuarto.Text = Convert.ToString("("+Quarto+")");
        }

        private void ButtonSoma1_Clicked(object sender, EventArgs e)
        {
            Quarto = Quarto + 1;
            labelQuarto.Text = Convert.ToString("("+Quarto+")");
        }

        private void ButtonSubtrair2_Clicked(object sender, EventArgs e)
        {
            Banheiro = Banheiro - 1;
            labelBanheiro.Text = Convert.ToString("("+Banheiro+")");
        }

        private void ButtonSoma2_Clicked(object sender, EventArgs e)
        {
            Banheiro = Banheiro + 1;
            labelBanheiro.Text = Convert.ToString("("+Banheiro+")");
        }

        private void ButtonSubtrair3_Clicked(object sender, EventArgs e)
        {
            Sala = Sala - 1;
            labelSala.Text = Convert.ToString("("+Sala+")");
        }

        private void ButtonSoma3_Clicked(object sender, EventArgs e)
        {
            Sala = Sala + 1;
            labelSala.Text = Convert.ToString("("+Sala+")");
        }

        private void ButtonSubtrair4_Clicked(object sender, EventArgs e)
        {
            Cozinha = Cozinha - 1;
            labelCozinha.Text = Convert.ToString("("+Cozinha+")");
        }

        private void ButtonSoma4_Clicked(object sender, EventArgs e)
        {
            Cozinha = Cozinha + 1;
            labelCozinha.Text = Convert.ToString("("+Cozinha+")");
        }

        public void ButtonProximo_Clicked(object sender, EventArgs e)
        {
            Cozinha = Convert.ToInt32(labelCozinha.Text);
            Sala = Convert.ToInt32(labelSala.Text);
            Banheiro = Convert.ToInt32(labelBanheiro.Text);
            Quarto = Convert.ToInt32(labelQuarto.Text);
            Total.Text = Convert.ToString(((Cozinha * 30) + (Sala * 30) + (Banheiro * 25) + (Quarto * 25)));
            int Totalr = Convert.ToInt32(Total); 

            CPedido CP = new CPedido();
            bool Cadastrar = CP.Cadastrar(Quarto, Banheiro, Cozinha, Sala, pickerDia, pickerHORA, pickerFuncionario, Totalr);

        }
    }
}