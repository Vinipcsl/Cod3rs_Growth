using Modelo_de_Dados;
using System.ComponentModel;
using System.Security.Permissions;

namespace Cod3r_s_Growth.Repositorio
{
    public interface IRepositorio
    {        
        public BindingList<Celular> ObterTodos();
        public Celular? ObterPorId(int id);
        public void Adicionar(Celular novoCelular);
        public void Atualizar(int id, Celular novoCelular);
        public void Deletar(int id);
    }
}