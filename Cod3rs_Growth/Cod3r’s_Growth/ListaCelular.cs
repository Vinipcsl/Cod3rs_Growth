using Modelo_de_Dados;
using System.ComponentModel;

namespace Cod3r_s_Growth
{
    public partial class ListaCelular : Form
    {
        private static BindingList<Celular> listaDeCelular = new BindingList<Celular>();

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
            if (dataGridView2.SelectedRows.Count == 0 || dataGridView2.SelectedRows.Count > 1)
            {
                MessageBox.Show("Operação inválida! \nSelecione uma linha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var idCelular = (int)dataGridView2.CurrentRow.Cells[0].Value;
            var celular = listaDeCelular.FirstOrDefault(celular => celular.Id == idCelular);

            DialogResult dialogResult = MessageBox.Show("Deseja mesmo apagar? \nNão será possível recuperar as informações!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (celular != null)
                {

                    listaDeCelular.Remove(celular);
                }
            }
        }

        private void AoClicarEmAtualizar(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0 || dataGridView2.SelectedRows.Count > 1)
            {
                MessageBox.Show("Operação inválida! \nSelecione uma linha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var idCelular = (int)dataGridView2.CurrentRow.Cells[0].Value;
            var celular = listaDeCelular.FirstOrDefault(celular => celular.Id == idCelular);

            ExibirTelaCadastro(celular);

        }

        private static void ExibirTelaCadastro(Celular? celular = null)
        {
            CadastroCelular cadastroCelular = new(listaDeCelular, celular);
            cadastroCelular.Show();
        }
    }
}