using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMobile27.Classe
{
    public class CFuncionario
    {
        /// <summary>
        /// 10102019-SelecionarDados: Metodo de listagem
        /// </summary>
        /// <returns>Retorna os itens listado da tabela Funcionario</returns>
        public List<ModelFuncionario> SelecionarDados()
        {
            try
            {
                var itens = ((App)Application.Current).Conexao.Query<ModelFuncionario>("SELECT * FROM Funcionario");
                return itens;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao listar.\nDetalhes:" + ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CPF">CPF DO FUNCIONARIO</param>
        /// <param name="CEP">CEP DO FUNCIONARIO</param>
        /// <param name="RG">RG DO FUNCIONARIO</param>
        /// <param name="Observacao">OBSERVAÇÃO DO FUNCIONARIO</param>
        /// <returns></returns>
        public bool Cadastrar(string CPF, string CEP, string RG, string Observacao)
        {
            try
            {
                var query = $"INSERT INTO Funcionario (CPF,CEP,RG,Observacao) VALUES ('{CPF}','{CEP}','{RG}','{Observacao}')";
                ((App)Application.Current).Conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool Atualizar(string CPF, string CEP, string RG, string Observacao, int ID)
        {
            try
            {
                var query = $"UPDATE Funcionario SET CPF = '{CPF}',CEP = '{CEP},RG ='{RG}',Observacao = '{Observacao}' WHERE ID = '{ID}'";
                ((App)Application.Current).Conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);

            }

        }

        public bool Deletar(int ID)
        {
            try
            {
                var query = $"DELETE FROM Funcionario WHERE ID = {ID}";
                ((App)Application.Current).Conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar.\nDetalhes:" + ex.Message);
            }
        }
    }
}
