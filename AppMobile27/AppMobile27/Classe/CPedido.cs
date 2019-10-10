using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMobile27.Classe
{
   public class CPedido
   {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Quarto">Quantidade de quartos</param>
        /// <param name="Banheiro">Quantidade de Documentos</param>
        /// <param name="Cozinha">Quantidade de cozinhas</param>
        /// <param name="Sala">Quantidade de salas</param>
        /// <param name="Data">Data de ida</param>
        /// <param name="Hora">Hora da ida</param>
        /// <param name="Empregado">FUNCIONARIO</param>
        /// <param name="Total">Total de gasto</param>
        /// <returns></returns>
        public bool Cadastrar (int Quarto, int Banheiro, int Cozinha,int Sala, Picker Data, Picker Hora, Picker Empregado, int Total)  
        {
                try
                {
                    var query = $"INSERT INTO Pedido (Quarto,Banheiro,Cozinha,Sala,Data,Hora,Empregado,Total) VALUES ('{Quarto}','{Banheiro}','{Cozinha}','{Sala}','{Data.SelectedItem}','{Hora.SelectedItem}','{Empregado.SelectedItem}','{Total}')";
                    ((App)Application.Current).Conexao.Execute(query);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao inserir\nDetalhes:" + ex.Message);
                }
            
          
        }
   }
}
