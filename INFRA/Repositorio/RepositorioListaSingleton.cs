using DOMINIO;

namespace INFRA.Repositorio
{
    public class RepositorioListaSingleton : IRepositorio
    {
        protected List<Peca> _ListaDePecas = Singleton.Instancia().listaPecas;

        public List<Peca> ObterTodos()
        {
            return _ListaDePecas.ToList();
        }

        public Peca ObterPorId(int id)
        {
            return _ListaDePecas.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"Peça não encontrada com id [{id}]");
        }

        public void Adicionar(Peca pecaNova)
        {
            _ListaDePecas.Add(pecaNova);
        }

        public void Editar(Peca pecaEditada)
        {
            var pecaAtual = ObterPorId(pecaEditada.Id);
            int index = _ListaDePecas.IndexOf(pecaAtual);
            _ListaDePecas[index] = pecaEditada;
        }

        public void Remover(int id)
        {
            var pecaARemover = ObterPorId(id);

            _ListaDePecas.Remove(pecaARemover);
        }
    }
}
