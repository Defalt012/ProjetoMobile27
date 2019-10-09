using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMobile27.Classe
{
    public class CFuncionario
    {
        public bool Cadastrar(string CPF, string CEP, string RG, string Observacao)
        {
            try
            {
                var query = $"INSERT INTO Login (CPF,CEP,RG,Observacao) VALUES ('{CPF}','{CEP}','{RG}','{Observacao}')";
                ((App)Application.Current).Conexao.Execute(query);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }
    }
}
