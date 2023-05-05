using Modelo_de_Dados;
using System.ComponentModel;

namespace Cod3r_s_Growth.Repositorio
{
   public interface IRepositorio
    {
        public BindingList<Celular> ObterTodos();
        Celular? ObterPorId(int id);
        void adicionar(Celular novoCelular);
        void atualizar(int id, Celular novoCelular);
        void deletar(int id);
    }
}
