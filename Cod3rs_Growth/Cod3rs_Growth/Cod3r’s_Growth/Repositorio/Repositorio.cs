using Modelo_de_Dados;
using System.ComponentModel;

namespace Cod3r_s_Growth.Repositorio
{
    internal class Repositorio : IRepositorio
    {
        protected BindingList<Celular> _listaCelular = Singleton.Instancia();
        public BindingList<Celular> obterTodos()
        {
            return _listaCelular;
        }

        public void adicionar(Celular novoCelular)
        {
            _listaCelular.Add(novoCelular);
        }

        public void atualizar(int id, Celular novoCelular)
        {
            var index = _listaCelular.Where(c => c.Id.Equals(id)).FirstOrDefault();

            index.Marca = novoCelular.Marca;
            index.Modelo = novoCelular.Modelo;
            index.Cor = novoCelular.Cor;
            index.Memoria = novoCelular.Memoria;
            index.AnoFabricacao = novoCelular.AnoFabricacao;        
        }

        public void deletar(int id)
        {
            var celularDeletar = ObterPorId(id);
            _listaCelular.Remove(celularDeletar);
        }

        public Celular? ObterPorId(int id)
        {
            return _listaCelular.FirstOrDefault(c => c.Id == id);
        }

        public BindingList<Celular> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
