using Modelo_de_Dados;
using System.ComponentModel;

namespace Cod3r_s_Growth.Repositorio
{
    public interface IRepositorio
    {        
        public BindingList<Celular> ObterTodos();
        Celular? ObterPorId(int id);
        public void Adicionar(Celular novoCelular);
        public void Atualizar(int id, Celular novoCelular);
        public void Deletar(int id);
    }
}
