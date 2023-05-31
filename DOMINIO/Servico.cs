namespace DOMINIO
{
    public class Servico
    {
        public static string ValidarCampos(Peca peca)
        {
            const int valorMinimoPeca = 1;

            if(string.IsNullOrEmpty(peca.Nome))
            {
                return "campo Nome vazio!";
            }

            else if (string.IsNullOrEmpty(peca.Categoria))
            {
                return "campo Categoria vazio!";
            }

            else if (string.IsNullOrEmpty(peca.Descricao))
            {
                return "campo Descrição vazio!";
            }

            else if (peca.DataDeFabricacao > DateTime.Now)
            {
                return "Data maior do que a data atual!";
            }

            else if (peca.Estoque < valorMinimoPeca)
            {
                return "campo Estoque sem valor!";
            }

            return string.Empty;
        }
    }
}
