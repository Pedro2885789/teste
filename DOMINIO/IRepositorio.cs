namespace DOMINIO
{
    public interface IRepositorio 
    {
        public List<Peca> ObterTodos();
        Peca? ObterPorId(int id);
        void Adicionar(Peca pecaNova);
        void Editar(Peca pecaEditada);
        void Remover(int id);
    }
}
