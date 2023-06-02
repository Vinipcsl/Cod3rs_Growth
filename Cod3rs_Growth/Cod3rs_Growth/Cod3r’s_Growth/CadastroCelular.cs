using Cod3r_s_Growth.Dominio.Repositorio;
using Cod3r_s_Growth.Infra;
using Modelo_de_Dados;
using System.ComponentModel;

namespace Cod3r_s_Growth
{
    public partial class CadastroCelular : Form
    {
        private Celular _celular = new();
        private static List<string> listaDeErros = new();
        private readonly int _id;
        private int _celularVazio = 0;
        private readonly IRepositorio _repositorio;

        public CadastroCelular(Celular celular, int id, IRepositorio repositorio)
        {
            InitializeComponent();
            _id = id;
            PreencherCampos(celular);
            _repositorio = repositorio;
        }

        private void AoClicarEmSalvar(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();
                if (_id != _celularVazio)
                {
                    AtualizarCelular();
                    _repositorio.Atualizar(_id, _celular);
                    Close();
                    MessageBox.Show("Celular atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var celular = ConverterEmCelular();
                    _repositorio.Adicionar(celular);
                    Close();
                    MessageBox.Show("Celular cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Celular ConverterEmCelular()
        {
            Celular celular = new()
            {
                Id = Singleton.IdIncremento(),
                Marca = TextoMarca.Text,
                Modelo = TextoModelo.Text,
                Cor = TextoCor.Text,
                Memoria = Convert.ToInt32(TextoMemoria.Text),
                AnoFabricacao = Convert.ToDateTime(DataFabricado.Text)
            };

            return celular;
        }

        private void AtualizarCelular()
        {           
            _celular.Marca = TextoMarca.Text;
            _celular.Modelo = TextoModelo.Text;
            _celular.Cor = TextoCor.Text;
            _celular.Memoria = Convert.ToInt32(TextoMemoria.Text);
            _celular.AnoFabricacao = Convert.ToDateTime(DataFabricado.Text);
        }

        private void PreencherCampos(Celular celular)
        {
            var idExiste = _id > 0;

            if (idExiste)
            {
                TextoMarca.Text = celular.Marca;
                TextoModelo.Text = celular.Modelo;
                TextoCor.Text = celular.Cor;
                TextoMemoria.Text = celular.Memoria.ToString();
            }
        }

        private void ValidarCampos()
        {
            const int valorMinimo = 0;
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
            if (listaDeErros.Count > valorMinimo)
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