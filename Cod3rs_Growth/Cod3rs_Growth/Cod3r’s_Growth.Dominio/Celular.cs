using LinqToDB.Mapping;
using System;

namespace Modelo_de_Dados
{
    [Table(Name = "Celulares")]
    public class Celular
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "Marca"), NotNull]
        public string Marca { get; set; }

        [Column(Name = "Modelo"), NotNull]
        public string Modelo { get; set; }

        [Column(Name = "Cor"), NotNull]
        public string Cor { get; set; }

        [Column(Name = "Memoria"), NotNull]
        public int Memoria { get; set; }

        [Column(Name = "AnoFabricado")]
        public DateTime AnoFabricacao { get; set; }
    }
}
