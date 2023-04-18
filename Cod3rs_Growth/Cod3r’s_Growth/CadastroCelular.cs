﻿using System;
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

namespace Cod3r_s_Growth
{
    public partial class CadastroCelular : Form
    {
        ListaCelular lsCelular;

        public CadastroCelular(ListaCelular LC)
        {
            InitializeComponent();
         lsCelular = LC;

        }

        private void CadastroCelular_Load(object sender, System.EventArgs e)
        {

        }
        private void AoClicarEmSalvar_Click(object sender, System.EventArgs e)
        {
            lsCelular.dataGridView1.Rows.Add();
        }
        
        private void AoClicarEmLimpar_Click(object sender, EventArgs e)
        {
            TextoId.Clear();
            TextoMarca.Clear();
            TextoModelo.Clear();
            TextoCor.Clear();
            TextoMemoria.Clear();

        }

        private void AoClicarEmCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
