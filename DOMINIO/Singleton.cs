namespace DOMINIO
{
    public class Singleton
    {
        private static Singleton? _instancia;
        private static int _proximoId;

        public List<Peca> listaPecas = new();

        public static Singleton Instancia()
        {
            lock (typeof(Singleton))
                _instancia ??= 
                    new Singleton();
            
            return _instancia;
        }

        public static int ObterProximoId()
        {
            return ++_proximoId;
        }
    }
}
