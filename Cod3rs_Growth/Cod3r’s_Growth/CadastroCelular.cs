using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo_de_Dados;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cod3r_s_Growth
{
    public partial class CadastroCelular : Form
    {
        public  BindingList<Celular> _celulares;

        public CadastroCelular(BindingList<Celular> celulars)
        {
            InitializeComponent();
            _celulares = celulars;
        }
        
        private void CadastroCelular_Load(object sender, System.EventArgs e)
        {

        }

        private void AoClicarEmSalvar_Click(object sender, System.EventArgs e)
        {
            string mensagem = "";

            if (TextoId.Text == "")
            {
                mensagem += "Por favor, preencha o id!";
            }
            if (TextoMarca.Text == "")
            {
                mensagem += "\nPor favor, preencha a marca!";
            }
            if (TextoModelo.Text == "")
            {
                mensagem += "\nPor favor, preencha o modelo!";
                if (TextoCor.Text == "")
                {
                    mensagem += "\nPor favor, preencha a cor!";

                }
                if (TextoMemoria.Text == "")
                {
                    mensagem += "\nPor favor, preencha o memoria!";
                }
                if (DataFabricado.Text == "")
                {
                    mensagem += "\nPor favor, preencha o data!";
                }
                if (!mensagem.Equals(""))
                {
                    MessageBox.Show(mensagem);
                }
                else
                {
                    Celular celular1 = new Celular();

                    celular1.Id = Convert.ToInt32(TextoId.Text);
                    celular1.Marca = TextoMarca.Text;
                    celular1.Modelo = TextoModelo.Text;
                    celular1.Cor = TextoCor.Text;
                    celular1.Memoria = Convert.ToInt32(TextoMemoria.Text);
                    celular1.AnoFabricacao = Convert.ToString(DataFabricado.Text);

                    _celulares.Add(celular1);

                    this.DialogResult = DialogResult.OK;

                }

            }
        }
        private void AoClicarEmCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    
