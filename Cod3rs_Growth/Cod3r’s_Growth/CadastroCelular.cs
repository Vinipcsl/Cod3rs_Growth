using Modelo_de_Dados;
using System.ComponentModel;

namespace Cod3r_s_Growth
{
    public partial class CadastroCelular : Form
    {
        public BindingList<Celular> _listaCelulares;
        public Celular? _celular;
        public bool Atualizando => _celular != null;

        public CadastroCelular(BindingList<Celular> celulars, Celular? celular = null)
        {
            InitializeComponent();
            _listaCelulares = celulars;
            _celular = celular;
        }

        private void CadastroCelular_Load(object sender, EventArgs e)
        {
            if (_celular != null)
            {
                PreencheCampos(_celular);
            }
        }

        private void AoClicarEmSalvar(object sender, EventArgs e)
        {
            string mensagem = string.Empty;

            if (string.IsNullOrEmpty(TextoMarca.Text))
            {
                mensagem += "Por favor, preencha a marca!";
            }
            if (string.IsNullOrEmpty(TextoModelo.Text))
            {
                mensagem += "\nPor favor, preencha o modelo!";
            }
            if (string.IsNullOrEmpty(TextoCor.Text))
            {
                mensagem += "\nPor favor, preencha a cor!";
            }
            if (string.IsNullOrEmpty(TextoMemoria.Text))
            {
                mensagem += "\nPor favor, preencha a memória!";
            }
            if (string.IsNullOrEmpty(DataFabricado.Text))
            {
                mensagem += "\nPor favor, preencha o data!";
            }
            if (!mensagem.Equals(""))
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var celular = CriaCelular();

            if (Atualizando)
            {
                // Executar a operação de atualizar
                var atalizarCelular = AtualizarCelular();
                _listaCelulares.Add(atalizarCelular);
                Close();

            }
            else
            {
                _listaCelulares.Add(celular);
                LimpaCampos();
                Close();
            }
        }

        private Celular CriaCelular()
        {
            var celular = new Celular();

            if (Atualizando)
            {
                celular.Id = _celular.Id; 

            }
            else
            {
               var ultimoid = _listaCelulares.Any() ? (_listaCelulares.Max(x => x.Id) ): 1;
                celular.Id = ultimoid + 1;
                
            }
           
            celular.Marca = TextoMarca.Text;
            celular.Modelo = TextoModelo.Text;
            celular.Cor = TextoCor.Text;
            celular.Memoria = Convert.ToInt32(TextoMemoria.Text);
            celular.AnoFabricacao = Convert.ToString(DataFabricado.Text);
            return celular;
        }
        private Celular AtualizarCelular()
        {
            var atualizarCelular = new Celular();

            atualizarCelular.Marca = TextoMarca.Text;
            atualizarCelular.Modelo = TextoModelo.Text;
            atualizarCelular.Cor = TextoCor.Text;
            atualizarCelular.Memoria = Convert.ToInt32(TextoMemoria.Text);
            atualizarCelular.AnoFabricacao = Convert.ToString(DataFabricado.Text);
            return atualizarCelular;
        }

        private void LimpaCampos()
        {
            TextoMarca.Text = "";
            TextoModelo.Text = "";
            TextoCor.Text = "";
            TextoMemoria.Text = "";
            DataFabricado.Text = "";
        }

        private void PreencheCampos(Celular celular)
        {
            TextoMarca.Text = celular.Marca;
            TextoModelo.Text = celular.Modelo;
            TextoCor.Text = celular.Cor;
            TextoMemoria.Text = celular.Memoria.ToString();
            DataFabricado.Text = celular.AnoFabricacao?.ToString();
        }

        private void AoClicarEmCancelar(object sender, EventArgs e)
        {
            Close();
        }

        private void TextoCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void TextoMemoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}