using Cod3r_s_Growth.Dominio.Repositorio;
using Cod3r_s_Growth.Infra.Banco;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.SqlServer;
using Modelo_de_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;

namespace Cod3r_s_Growth.Infra
{
    public class Linq2DB : IRepositorio
    {
        private List<Celular> _listacelular = new List<Celular>();
        private BindingList<Celular> _listacelula = Singleton.Instancia();

        public void Adicionar(Celular novoCelular)
        {
            using var conexao2db = Conexao();
            conexao2db.Insert(novoCelular);

        }

        public void Atualizar(int id, Celular novoCelular)
        {
            using var conexao2db = Conexao();
            conexao2db.Update(novoCelular);
            
        }

        public void Deletar(int id)
        {
            using var conexao2db = Conexao();
            conexao2db.GetTable<Celular>().Delete(Celular => Celular.Id.Equals(id));
        }

        public Celular? ObterPorId(int id)
        {
            using var conexao2db = Conexao();
            return conexao2db.GetTable<Celular>().FirstOrDefault(Celular => Celular.Id.Equals(id));
        }

        public BindingList<Celular> ObterTodos()
        {
            using var conexao2db = Conexao();
            _listacelular.Clear();
            _listacelular = conexao2db.GetTable<Celular>().ToList();
            var bindlist = new BindingList<Celular>(_listacelular);
            return bindlist;
        }

        public DataConnection Conexao()
        {
            string CadastroCelular = ConfigurationManager.ConnectionStrings["CadastroCelular"].ConnectionString;
            DataConnection conexao = SqlServerTools.CreateDataConnection(CadastroCelular);
            return conexao;
        }
    }
}
