
using Cod3r_s_Growth.Dominio.Repositorio;
using Cod3r_s_Growth.Infra;
using Modelo_de_Dados;
using System.ComponentModel;


namespace Cod3r_s_Growth
{
    public partial class ListaCelular : Form
    {
        public static BindingList<Celular> listaDeCelular = Singleton.Instancia();
        public IRepositorio repositorioDoBanco ;

        public ListaCelular(IRepositorio repositorio)
        {
            InitializeComponent();
            repositorioDoBanco = repositorio;
            CarregarTela();
        }

        private void AoClicarEmCadastrar(object sender, EventArgs e)
        {
            int GuardarId = 0;
            CadastroCelular cadastroCelular = new(listaDeCelular, GuardarId, repositorioDoBanco);
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

                DialogResult dialogResult = MessageBox.Show("Deseja mesmo apagar? \nN�o ser� poss�vel recuperar as informa��es!", "Aten��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (celular != null)
                    {
                        repositorioDoBanco.Deletar(idCelular);
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
                var celular = listaDeCelular.FirstOrDefault(celular => celular.Id == idCelular);
                CadastroCelular cadastroCelular = new(listaDeCelular, celular.Id, repositorioDoBanco);
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
                mensagemDeErro = "Opera��o inv�lida! \nNenhuma linha selecionada!";
                throw new Exception(mensagemDeErro);
            }
            if (dataGridView2.SelectedRows.Count > 1)
            {
                mensagemDeErro = "Opera��o inv�lida! \nSelecione apenas uma linha!";
                throw new Exception(mensagemDeErro);
            }
        }

        public void CarregarTela()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = repositorioDoBanco.ObterTodos();
        }
    }
}