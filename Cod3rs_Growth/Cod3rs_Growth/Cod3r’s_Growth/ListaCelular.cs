
using Cod3r_s_Growth.Dominio.Repositorio;
using Cod3r_s_Growth.Infra;
using Modelo_de_Dados;
using System.ComponentModel;


namespace Cod3r_s_Growth
{
    public partial class ListaCelular : Form
    {
        public IRepositorio repositorio;

        public ListaCelular(IRepositorio repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
            CarregarTela();
        }

        private void AoClicarEmCadastrar(object sender, EventArgs e)
        {
            int GuardarId = 0;
            CadastroCelular cadastroCelular = new(null, GuardarId, repositorio);
            cadastroCelular.ShowDialog();
            CarregarTela();
        }

        private void AoClicarEmDeletar(object sender, EventArgs e)
        {
            try
            {
                ValidarQuantidadeDeLinhasSelecionadas();
                var idCelular = (int)dataGridView2.CurrentRow.Cells[0].Value;
                var listaCelulares = repositorio.ObterTodos();

                var celular = listaCelulares
                    .FirstOrDefault(celular => celular.Id == idCelular);

                DialogResult dialogResult = MessageBox.Show("Deseja mesmo apagar? \nNão será possível recuperar as informações!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (celular != null)
                    {
                        repositorio.Deletar(idCelular);
                        MessageBox.Show("Celular removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CarregarTela();
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
                var listaCelulares = repositorio.ObterTodos();

                var celular = listaCelulares.FirstOrDefault(celular => celular.Id == idCelular) ?? 
                    throw new Exception($"Não foi encontrado celular com Id: {idCelular}");

                using (CadastroCelular cadastroCelular = new(celular, celular.Id, repositorio))
                {
                    cadastroCelular.ShowDialog();
                }

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