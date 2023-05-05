using Modelo_de_Dados;
using System.ComponentModel;

namespace Cod3r_s_Growth
{
    public partial class CadastroCelular : Form
    {
        public BindingList<Celular> _listaCelulares;
        public Celular? _celular;
        public bool Atualizando => _celular != null;
        private static List<string> listaDeErros = new();

        public CadastroCelular(BindingList<Celular> celulars, Celular celular)
        {
            InitializeComponent();
            PreencherCampos(celular);
            _listaCelulares = celulars;
            _celular = celular;
        }

        private void AoClicarEmSalvar(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();

                if (Atualizando)
                {
                    var atalizarCelular = AtualizarCelular();
                    var indexDoCelular = _listaCelulares.IndexOf(atalizarCelular);

                    _listaCelulares[indexDoCelular] = atalizarCelular;

                    MessageBox.Show("Celular atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    var celular = CriaCelular();

                    _listaCelulares.Add(celular);
                    MessageBox.Show("Celular cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Celular CriaCelular()
        {
            if (Atualizando)
            {
                return AtualizarCelular();
            }
            var celular = new Celular();

            celular.Id = Singleton.Instancia().IdIncremento();
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

        private void PreencherCampos(Celular celular)
        {
            if (celular != null)
            {
                TextoMarca.Text = celular.Marca;
                TextoModelo.Text = celular.Modelo;
                TextoCor.Text = celular.Cor;
                TextoMemoria.Text = celular.Memoria.ToString();
                DataFabricado.Text = celular.AnoFabricacao?.ToString();
            }
        }

        private void ValidarCampos()
        {
            listaDeErros.Clear();

            if (string.IsNullOrEmpty(TextoMarca.Text))
            {
                listaDeErros.Add("Por favor, preencha a marca!");
            }
            if (string.IsNullOrEmpty(TextoModelo.Text))
            {
                listaDeErros.Add("Por favor, preencha o modelo!");
            }
            if (string.IsNullOrEmpty(TextoCor.Text))
            {
                listaDeErros.Add("Por favor, preencha a cor!");
            }
            if (string.IsNullOrEmpty(TextoMemoria.Text))
            {
                listaDeErros.Add("Por favor, preencha a memória!");
            }
            if (string.IsNullOrEmpty(DataFabricado.Text))
            {
                listaDeErros.Add("Por favor, preencha o data!");
            }
            if (listaDeErros.Count > 0)
            {
                var _listaDeErros = string.Join("\n", listaDeErros);
                throw new Exception(_listaDeErros);

            }
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