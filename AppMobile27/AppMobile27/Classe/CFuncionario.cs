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
        /// <param name="Nome">Nome do funcionario</param>
        /// <param name="CPF">CPF DO FUNCIONARIO</param>
        /// <param name="CEP">CEP DO FUNCIONARIO</param>
        /// <param name="RG">RG DO FUNCIONARIO</param>
        /// <param name="Observacao">OBSERVAÇÃO DO FUNCIONARIO</param>
        /// <returns></returns>
        public bool Cadastrar(string Nome,string CPF, string CEP, string RG, string Observacao)
        {
            try
            {
                var query = $"INSERT INTO Funcionario (Nome,CPF,CEP,RG,Observacao) VALUES ('{Nome}','{CPF}','{CEP}','{RG}','{Observacao}')";
                ((App)Application.Current).Conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir\nDetalhes:" + ex.Message);
            }
        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID">ID das informaçoes</param>
        /// <returns></returns>
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
        public bool ApagarTudo()
        {
            try
            {
                var query = $"DELETE FROM funcionario";
                ((App)Application.Current).Conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Apagar \nDetalhes:" + ex.Message);
            }
        }
    }
}
