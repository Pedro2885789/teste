using DOMINIO;

namespace CRUD
{
    public partial class CadastroDePecas : Form
    {
        public Peca peca = new();

        public CadastroDePecas(Peca? peca)
        {
            InitializeComponent();

            this.peca = peca == null 
                ? new Peca()
                : PreencherCampos(peca);
        }

        private Peca PreencherCampos(Peca peca)
        {
            textBox1.Text = peca.Descricao;
            textBox2.Text = peca.Nome;
            numericUpDown1.Value = peca.Estoque;
            textBox6.Text = peca.Categoria;
            dateTimePicker1.Value = peca.DataDeFabricacao;
            return peca;
        }

        private void AoClicarEmSalvar(object sender, EventArgs e)
        {
            try
            {
                var pecaParaAdicionar = new Peca()
                {
                    Nome = textBox2.Text,
                    Categoria = textBox6.Text,
                    Descricao = textBox1.Text,
                    Estoque = (int)numericUpDown1.Value,
                    DataDeFabricacao = dateTimePicker1.Value,
                };

                var errosValidacao = Servico.ValidarCampos(pecaParaAdicionar);

                if (!string.IsNullOrEmpty(errosValidacao))
                {
                    MessageBox.Show(errosValidacao);
                    return;
                }

                peca = pecaParaAdicionar;

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarCancelar(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
