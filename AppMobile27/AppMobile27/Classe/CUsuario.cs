using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace AppMobile27.Classe
{
    public class CUsuario
    {
        


        public bool CadastrarUsuario(string nome,string usuario,string email, string senha, int cep)
        {

            try
            {


                var query = $"INSERT INTO Login (nome,usuario,email,senha,cep) VALUES ('{nome}','{usuario}','{email}','{senha}','{cep}')";
                ((App)Application.Current).Conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);

            }
        }
        public bool Update(string nome, string usuario, string email, string senha, int cep, int id)
        {
            try
            {
                var query = $"UPDATE Login SET nome = '{nome}', usuario = '{usuario}', email = '{email}', senha = '{senha}',cep = '{cep}'  WHERE id = {id}";
                ((App)Application.Current).Conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }
        public bool DeleteItem(int id)
        {
            try
            {
                var query = $"DELETE FROM Login WHERE id = {id}";
                ((App)Application.Current).Conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
}   }   }
