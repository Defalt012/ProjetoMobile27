using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace AppMobile27.Classe
{
    public class CUsuario
    {


        public bool CadastrarUsuario(string Nome,string Usuario,string Email, string Senha, string CEP)
        {

            try
            {


                var query = $"INSERT INTO Login (Nome,Usuario,Email,Senha,CEP) VALUES ('{Nome}','{Usuario}','{Email}','{Senha}','{CEP}')";
                ((App)Application.Current).Conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);

            }
        }
        public bool Update(string Nome, string Usuario, string Email, string Senha, string CEP, int ID)
        {
            try
            {
                var query = $"UPDATE Login SET Nome = '{Nome}', Usuario = '{Usuario}', Email = '{Email}', Senha = '{Senha}',CEP = '{CEP}'  WHERE ID = {ID}";
                ((App)Application.Current).Conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteItem(int ID)
        {
            try
            {
                var query = $"DELETE FROM Login WHERE ID = {ID}";
                ((App)Application.Current).Conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);


            }
        }

        public bool Login(string Usuario, string Senha)
        {
            try
            {
                var query = $"SELECT COUNT (*) FROM Login WHERE  Usuario = '{Usuario}' and Senha = '{Senha}'";
                var resultadoSQL = ((App)Application.Current).Conexao.Query<ModelUsuario>(query);

                if (resultadoSQL.Count == 1)
                {
                    
                    return true;
                }
                else
                {
                    
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
                

            }
        }
}   }








