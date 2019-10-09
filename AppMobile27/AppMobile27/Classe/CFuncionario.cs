using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMobile27.Classe
{
    public class CFuncionario
    {

        public List<ModelFuncionario> SelecionarDados()
        {
            var itens = ((App)Application.Current).Conexao.Query<ModelFuncionario>("SELECT * FROM Funcionario");
            return itens;
        }

        public bool Cadastrar(string CPF, string CEP, string RG, string Observacao)
        {
            try
            {
                var query = $"INSERT INTO Funcionario (CPF,CEP,RG,Observacao) VALUES ('{CPF}','{CEP}','{RG}','{Observacao}')";
                ((App)Application.Current).Conexao.Execute(query);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }
        public bool Atualizar(string CPF, string CEP, string RG, string Observacao,int ID)
        {
            try
            {
                var query = $"UPDATE Funcionario SET CPF = '{CPF}',CEP = '{CEP},RG ='{RG}',Observacao = '{Observacao}' WHERE ID = '{ID}'";
                ((App)Application.Current).Conexao.Execute(query);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
