using Cod3r_s_Growth.Repositorio;
using Modelo_de_Dados;
using System.ComponentModel;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data.Common;
namespace Cod3r_s_Growth.RepositorioBanco
{
    internal class RepositorioDoBanco : IRepositorio
    {

        static string CadastroCelular = ConfigurationManager.ConnectionStrings["CodersGrowth"].ConnectionString;
        public BindingList<Celular> _listaCelulares = Singleton.Instancia();

        public void Adicionar(Celular novoCelular)
        {
            string sql = "INSERT INTO Celulares(Marca, Modelo, Cor, Memoria, AnoFabricado" +
                "Values" + "@Marca, @Modelo,@Cor,@Memoria,@AnoFabricado";
            using (SqlConnection connection = new SqlConnection(CadastroCelular))
            {
                connection.Open();
                using (SqlCommand command = new(sql, connection))
                {
                    command.Parameters.AddWithValue("@Marca", novoCelular.Marca);
                    command.Parameters.AddWithValue("@Modelo", novoCelular.Modelo);
                    command.Parameters.AddWithValue("@Cor", novoCelular.Cor);
                    command.Parameters.AddWithValue("@Memoria", novoCelular.Memoria);
                    command.Parameters.AddWithValue("@AnoFabricado", novoCelular.AnoFabricacao);

                    command.ExecuteNonQuery();

                }
            }
          
        }

        public void Atualizar(int id, Celular novoCelular)
        {
            string sql = "INSERT INTO Celulares(Marca, Modelo, Cor, Memoria, AnoFabricado" +
               "Values" + "@Marca, @Modelo,@Cor,@Memoria,@AnoFabricado";
            using (SqlConnection connection = new SqlConnection(CadastroCelular))
            {
                connection.Open();
                SqlCommand command = new(sql, connection);
                command.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            string sql = $"delete from Celulares where Id = {id}";
            using (SqlConnection connection = new SqlConnection(CadastroCelular))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
        }

        public Celular? ObterPorId(int id)
        {
            throw new Exception();
        }

        public BindingList<Celular> ObterTodos()
        {
            throw new Exception();
        }
    }
}
