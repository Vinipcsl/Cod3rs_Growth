using Cod3r_s_Growth.Dominio.Repositorio;
using Modelo_de_Dados;
using System.ComponentModel;
using System.Linq;

namespace Cod3r_s_Growth.Infra.Repositorio
{
    internal class Repositorio : IRepositorio
    {
        protected BindingList<Celular> _listaCelular = Singleton.Instancia();

        public BindingList<Celular> obterTodos()
        {
            return _listaCelular;
        }

        public void Adicionar(Celular novoCelular)
        {
            _listaCelular.Add(novoCelular);
        }

        public void Atualizar(int id, Celular celularAtual)
        {
            var celularNovo = _listaCelular.Where(c => c.Id.Equals(id)).FirstOrDefault();
            
            celularNovo.Marca = celularAtual.Marca;
            celularNovo.Modelo = celularAtual.Modelo;
            celularNovo.Cor = celularAtual.Cor;
            celularNovo.Memoria = celularAtual.Memoria;
            celularNovo.AnoFabricacao = celularAtual.AnoFabricacao;           
        }

        public void Deletar(int id)
        {
            var celularDeletar = ObterPorId(id);
            _listaCelular.Remove(celularDeletar);
        }

        public Celular ObterPorId(int id)
        {
            return _listaCelular.Where(c => c.Id.Equals(id)).FirstOrDefault();
        }

        public BindingList<Celular> ObterTodos()
        {
            return _listaCelular;
        }
    }
}
