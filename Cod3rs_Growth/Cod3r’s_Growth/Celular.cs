using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modelo_de_Dados
{
    public class Celular
    {
        public int Id { get; set; }
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public DateTime AnoFabricacao { get; set; }

        public int Memoria { get; set; }

        


    }



}
