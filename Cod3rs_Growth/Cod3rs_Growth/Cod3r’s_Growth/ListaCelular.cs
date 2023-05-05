using Cod3r_s_Growth.Repositorio;
using Modelo_de_Dados;
using System.ComponentModel;

namespace Cod3r_s_Growth
{
    public partial class ListaCelular : Form
    {
        public static BindingList<Celular> listaDeCelular = Singleton.Instancia();
        public static Repositorio repositorio = IRepositorio();

        public ListaCelular()
        {
            InitializeComponent();
            dataGridView2.DataSource = listaDeCelular;
        }

        private void AoClicarEmCadastrar(object sender, EventArgs e)
        {
            ExibirTelaCadastro();
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
                        listaDeCelular.Remove(celular);
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

                ExibirTelaCadastro(celular);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarQuantidadeDeLinhasSelecionadas()
        {
            var mensagemDeErro = string.Empty;
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

        private static void ExibirTelaCadastro(Celular? celular = null)
        {
            CadastroCelular cadastroCelular = new(listaDeCelular, celular);
            cadastroCelular.Show();
        }
    }
}