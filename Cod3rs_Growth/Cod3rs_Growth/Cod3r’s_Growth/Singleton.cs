using Modelo_de_Dados;
using System.ComponentModel;


namespace Cod3r_s_Growth
{
    public sealed class Singleton
    {
        private static Singleton? _instancia;
        public BindingList<Celular> celulars;
        private static int id = 0;

        public static Singleton Instancia()
        {
            lock (typeof(Singleton))

            if (_instancia == null)
            {
                _instancia = new Singleton()
                {
                    celulars = new BindingList<Celular>()
                };
            };

            return _instancia;
        }

        public int IdIncremento()
        {
            id++;
            return id;
        }
    }
}
