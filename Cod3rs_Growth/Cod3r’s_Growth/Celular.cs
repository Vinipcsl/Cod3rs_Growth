using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modelo_de_Dados
{
    public class Celular
    {
        private string Marca;
        private string Modelo;
        private string Cor;
        private string AnoFabriacao;
        private int Memoria, Id;

        public Celular(string marca, string modelo, string cor, string anoFabriacao, int memoria, int id)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            AnoFabriacao = anoFabriacao;
            Memoria = memoria;
            Id = id;
        }


        public string marca
        {
            get
            { return marca; }
            set
            { marca = value; }
        }
        public string modelo
        {
            get
            { return modelo; }
            set
            { modelo = value; }
        }
        public string cor
        {
            get
            { return cor; }
            set
            { cor = value; }
        }
        public string anoFabriacao
        {
            get { return cor; }
            set { cor = value; }
        }
        public int memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }
        public int id
        {
            get { return id; }
            set { id = value; }
        }







    }



}
