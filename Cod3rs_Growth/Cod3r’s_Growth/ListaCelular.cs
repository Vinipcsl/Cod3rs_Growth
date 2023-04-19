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
        private void ListarCelular(object sender, EventArgs e)
        {

        }
        private void AoClicarEmCadastrar(object sender, EventArgs e)
        {
            CadastroCelular cadastroCelular = new CadastroCelular(listaDeCelular);
            cadastroCelular.Show();

            dataGridView2.DataSource = cadastroCelular._celulares;
        }

        private void AoClicarEmDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}