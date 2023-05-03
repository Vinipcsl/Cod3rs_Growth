using Modelo_de_Dados;
using System.ComponentModel;

namespace Cod3r_s_Growth
{
    public partial class CadastroCelular : Form
    {
        ListaCelular lista1 = new ListaCelular();
        public BindingList<Celular> _listaCelulares;
        public Celular? _celular;
        public bool Atualizando => _celular != null;
                
        public CadastroCelular(BindingList<Celular> celulars, Celular? celular = null)
        {
            InitializeComponent();
            _listaCelulares = celulars;
            _celular = celular;
        }      

        private void AoClicarEmSalvar(object sender, EventArgs e)
        {
            var validar = ValidacaoDeCampos();
                 
            if (validar == "") 
            {
                if (Atualizando)
                {                    
                    var atalizarCelular = AtualizarCelular();
                    var indexDoCelular = _listaCelulares.IndexOf(atalizarCelular);
                    _listaCelulares[indexDoCelular] = atalizarCelular;
                    Close();
                }
                else
                {
                    var celular = CriaCelular();
                    
                    _listaCelulares.Add(celular);
                    Close();

                }
            }
           
        }

        private Celular CriaCelular()
        {
            if (Atualizando)
            {
                return AtualizarCelular();
            }
            var celular = new Celular();

            celular.Id = lista1.IdIncremento();
            celular.Marca = TextoMarca.Text;
            celular.Modelo = TextoModelo.Text;
            celular.Cor = TextoCor.Text;
            celular.Memoria = Convert.ToInt32(TextoMemoria.Text);
            celular.AnoFabricacao = Convert.ToString(DataFabricado.Text);
            return celular;
        }

        private Celular AtualizarCelular()
        {
            _celular.Marca = TextoMarca.Text;
            _celular.Modelo = TextoModelo.Text;
            _celular.Cor = TextoCor.Text;
            _celular.Memoria = Convert.ToInt32(TextoMemoria.Text);
            _celular.AnoFabricacao = Convert.ToString(DataFabricado.Text);
            return _celular;
        }

        private void PreencheCampos(Celular celular)
        {
            TextoMarca.Text = celular.Marca;
            TextoModelo.Text = celular.Modelo;
            TextoCor.Text = celular.Cor;
            TextoMemoria.Text = celular.Memoria.ToString();
            DataFabricado.Text = celular.AnoFabricacao?.ToString();
        }

        private string ValidacaoDeCampos()
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
            }
            return mensagem;
        }
        
        private void AoClicarEmCancelar(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja mesmo cancelar a opreação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }           
        }

        private void ValidarCampoCor(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void ValidarCampoMemoria(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}