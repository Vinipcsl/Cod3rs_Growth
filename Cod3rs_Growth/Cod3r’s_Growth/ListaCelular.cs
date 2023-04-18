using Modelo_de_Dados;
using System.Data;

namespace Cod3r_s_Growth
{

    public partial class ListaCelular : Form
    {
     

        public ListaCelular()
        {
            InitializeComponent();
                       

        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public void recebeLista()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroCelular cadastroCelular = new CadastroCelular(lscelular);
            cadastroCelular.Show();
        }


}
}