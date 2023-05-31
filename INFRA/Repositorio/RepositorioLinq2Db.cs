using System;
using System.Configuration;
using DOMINIO;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.SqlServer;

namespace INFRA.Repositorio
{
    public  class RepositorioLinq2Db : IRepositorio
    {
        private static DataConnection ConexaoLinq2Db()
        {
            var DataConnection = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
            return SqlServerTools.CreateDataConnection(DataConnection);
        }

        public List<Peca> ObterTodos()
        {
            using var conexao = ConexaoLinq2Db();
            try
            {
                return conexao.GetTable<Peca>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("MensagensDeTela.ERRO_AO_OBTER_DADOS", ex);
            }
        }

        public Peca? ObterPorId(int id)
        {
            using var conexao = ConexaoLinq2Db();
            try
            {
                var listaPecas = conexao.GetTable<Peca>();
                var pecaPeloId = listaPecas.FirstOrDefault(x => x.Id == id);
                return pecaPeloId;
            }
            catch(Exception ex)
            { 
                throw new Exception("MensagensDeTela.ERRO_AO_OBTER_ID", ex);
            }
        }

        public void Adicionar(Peca pecaNova)
        {
            using var conexao = ConexaoLinq2Db();
            try
            {
                conexao.Insert(pecaNova);
            }
            catch(Exception ex)
            {
                throw new Exception("MensagensDeTela.ERRO_AO_ADICIONAR_DADOS", ex);
            }
        }

        public void Editar(Peca pecaEditada)
        {
            using var conexao = ConexaoLinq2Db();
            try
            {
                conexao.Update(pecaEditada);
            }
            catch(Exception ex)
            {
                throw new Exception("MensagensDeTela.ERRO_AO_EDITAR_DADOS", ex);
            }
        }

        public void Remover(int id)
        {
            using var conexao = ConexaoLinq2Db();
            try
            {
                var pecaARemover = ObterPorId(id);
                if (pecaARemover != null)
                {
                    conexao.Delete(pecaARemover);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("MensagensDeTela.ERRO_AO_REMOVER_DADOS", ex);
            }
        }
    }
}
