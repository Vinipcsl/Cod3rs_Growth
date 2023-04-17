using Modelo_de_Dados;

namespace Cod3r_s_Growth
{
    public partial class ListaCelular : Form
    {
        public ListaCelular()
        {
            InitializeComponent();


            listaCelular.AddRange(Array.Empty<Celular>());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroCelular cadastroCelular = new CadastroCelular();
            cadastroCelular.Show();
        }
    }
}