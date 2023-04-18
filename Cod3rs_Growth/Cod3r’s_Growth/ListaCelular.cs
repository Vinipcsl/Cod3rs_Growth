using Modelo_de_Dados;
using System.Data;
using System.Windows.Forms;

namespace Cod3r_s_Growth
{

    public partial class ListaCelular : Form
    {


        public ListaCelular()
        {
            InitializeComponent();



        }


        private void ListaCelular_Load(object sender, EventArgs e)
        {




        }
        public void recebeLista()
        {
            
        }

        private void AoClicarEmCadastrar(object sender, EventArgs e)
        {
            CadastroCelular cadastroCelular = new CadastroCelular(this);
            cadastroCelular.Show();
        }

        private void AoClicarEmDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}