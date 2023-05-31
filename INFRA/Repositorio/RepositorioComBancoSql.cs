using Microsoft.Data.SqlClient;
using System.Configuration;
using DOMINIO;

namespace INFRA.Repositorio
{
    public class RepositorioComBancoSql : IRepositorio
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

        public List<Peca> ObterTodos()
        {
            SqlConnection conexaoBanco = new (_connectionString);

            conexaoBanco.Open();

            SqlCommand comandoDeExecucao = new ("SELECT * FROM Peca", conexaoBanco);

            var lerExecucaoQuery = comandoDeExecucao.ExecuteReader();

            List<Peca> lista = new();

            Peca peca;

            while (lerExecucaoQuery.Read())
            {
                peca = new Peca()
                {
                    Id = Convert.ToInt32(lerExecucaoQuery[0]),
                    Categoria = lerExecucaoQuery[1].ToString(),
                    Nome = lerExecucaoQuery[2].ToString(),
                    Descricao = lerExecucaoQuery[3].ToString(),
                    Estoque = Convert.ToInt32(lerExecucaoQuery[4]),
                    DataDeFabricacao = Convert.ToDateTime(lerExecucaoQuery[5])
                };

                lista.Add(peca);
            }

            conexaoBanco.Close();

            return lista;
        }

        public Peca ObterPorId(int id)
        {
            Peca peca = new();

            SqlConnection conexaoBanco = new (_connectionString);

            conexaoBanco.Open();

            SqlCommand comandoDeExecucao = new ($"SELECT * FROM Peca WHERE Id = {id}", conexaoBanco);

            var lerExecucaoQuery = comandoDeExecucao.ExecuteReader();

            while (lerExecucaoQuery.Read())
            {
                peca = new()
                {
                    Id = Convert.ToInt32(lerExecucaoQuery[0]),
                    Categoria = lerExecucaoQuery[1].ToString(),
                    Nome = lerExecucaoQuery[2].ToString(),
                    Descricao = lerExecucaoQuery[3].ToString(),
                    Estoque = Convert.ToInt32(lerExecucaoQuery[4]),
                    DataDeFabricacao = Convert.ToDateTime(lerExecucaoQuery[5])
                };
            }

            conexaoBanco.Close();

            return peca;
        }

        public void Adicionar(Peca pecaNova)
        {
            SqlConnection conexaoBanco = new(_connectionString);

            conexaoBanco.Open();

            var comando = new SqlCommand("INSERT INTO Peca (Categoria, Nome, Descricao, Estoque, DataDeFabricacao) VALUES " + $"('{pecaNova.Categoria}', '{pecaNova.Nome}', '{pecaNova.Descricao}', {pecaNova.Estoque}, '{pecaNova.DataDeFabricacao}');", conexaoBanco);

            comando.ExecuteNonQuery();

            conexaoBanco.Close();
        }

        public void Editar(Peca pecaEditada)
        {
            SqlConnection conexaoBanco = new(_connectionString);

            conexaoBanco.Open();

            var comando = new SqlCommand($"UPDATE Peca SET Categoria = '{pecaEditada.Categoria}', Nome = '{pecaEditada.Nome}', Descricao = '{pecaEditada.Descricao}', Estoque = {pecaEditada.Estoque}, DataDeFabricacao = '{pecaEditada.DataDeFabricacao}' WHERE Id ={pecaEditada.Id} ", conexaoBanco);

            comando.ExecuteNonQuery();

            conexaoBanco.Close();
        }

        public void Remover(int id)
        {
            SqlConnection conexaoBanco = new(_connectionString);

            conexaoBanco.Open();

            var pecaARemover = ObterPorId(id);

            var comando = new SqlCommand($"DELETE FROM Peca where Id = {id}", conexaoBanco);

            if (pecaARemover != null)
            {
                comando.ExecuteNonQuery();
            }

            conexaoBanco.Close();
        }
    }
}
