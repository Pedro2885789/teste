using DOMINIO;

namespace CRUD
{
    public partial class ControleDePecas : Form
    {
        private readonly IRepositorio _repositorio;

        public ControleDePecas(IRepositorio repositorio)
        {
            _repositorio = repositorio; 

            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = _repositorio.ObterTodos();
        }

        private void AoClicarAdicionar(object sender, EventArgs e)
        {
            try
            {
                CadastroDePecas cadastroDePecas = new(null);
                cadastroDePecas.ShowDialog();

                var pecaPreenchida = cadastroDePecas.peca;
                pecaPreenchida.Id = Singleton.ObterProximoId();

                if (cadastroDePecas.DialogResult == DialogResult.OK)
                {
                    _repositorio.Adicionar(pecaPreenchida);
                }

                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AoClicarRemover(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um item");
                    return;
                }

                string mensagem = "Tem certeza que deseja remover essa linha?";
                var resultado = MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             
                if (resultado == DialogResult.Yes)
                {
                    var linhaSelecionada = dataGridView2.SelectedRows[0].Cells[0].RowIndex;
                    var pecaSelecionada = (Peca)dataGridView2.Rows[linhaSelecionada].DataBoundItem;

                    _repositorio.Remover(pecaSelecionada.Id);                          
                }

                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AoClicarEditar(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um item");
                    return;
                }

                var linhaSelecionada = dataGridView2.SelectedRows[0].Cells[0].RowIndex;
                var pecaSelecionada = (Peca)dataGridView2.Rows[linhaSelecionada].DataBoundItem;

                CadastroDePecas cadastroPeca = new(pecaSelecionada);
                cadastroPeca.ShowDialog();

                var pecaAtualizada = cadastroPeca.peca;
                pecaAtualizada.Id = pecaSelecionada.Id;

                if (cadastroPeca.DialogResult == DialogResult.OK)
                {
                    _repositorio.Editar(pecaAtualizada);
                }

                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
