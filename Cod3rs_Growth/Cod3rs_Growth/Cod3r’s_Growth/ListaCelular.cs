using Cod3r_s_Growth.Repositorio;
using Modelo_de_Dados;
using System.ComponentModel;


namespace Cod3r_s_Growth
{
    public partial class ListaCelular : Form
    {
        public static BindingList<Celular> listaDeCelular = Singleton.Instancia();
        public IRepositorio repositorio = new Repositorio.Repositorio();

        public ListaCelular()
        {
            InitializeComponent();
            CarregarTela();
        }

        private void AoClicarEmCadastrar(object sender, EventArgs e)
        {
            int GuardarId = 0;
            CadastroCelular cadastroCelular = new(listaDeCelular, GuardarId);
            cadastroCelular.ShowDialog();
            CarregarTela();
        }

        private void AoClicarEmDeletar(object sender, EventArgs e)
        {
            try
            {
                ValidarQuantidadeDeLinhasSelecionadas();
                var idCelular = (int)dataGridView2.CurrentRow.Cells[0].Value;
                var celular = listaDeCelular.FirstOrDefault(celular => celular.Id == idCelular);

                DialogResult dialogResult = MessageBox.Show("Deseja mesmo apagar? \nNão será possível recuperar as informações!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (celular != null)
                    {
                        repositorio.Deletar(idCelular);
                        MessageBox.Show("Celular removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AoClicarEmAtualizar(object sender, EventArgs e)
        {
            try
            {
                ValidarQuantidadeDeLinhasSelecionadas();

                var idCelular = (int)dataGridView2.CurrentRow.Cells[0].Value;
                var celular = listaDeCelular.FirstOrDefault(celular => celular.Id == idCelular);
                CadastroCelular cadastroCelular = new(listaDeCelular, celular.Id);
                cadastroCelular.ShowDialog();
                CarregarTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarQuantidadeDeLinhasSelecionadas()
        {
            string mensagemDeErro;
            if (dataGridView2.SelectedRows.Count == 0)
            {
                mensagemDeErro = "Operação inválida! \nNenhuma linha selecionada!";
                throw new Exception(mensagemDeErro);
            }
            if (dataGridView2.SelectedRows.Count > 1)
            {
                mensagemDeErro = "Operação inválida! \nSelecione apenas uma linha!";
                throw new Exception(mensagemDeErro);
            }
        }

        public void CarregarTela()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = repositorio.ObterTodos();
        }
    }
}