using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uninove.Pizzaria
{
    internal class PizzaV1
    {
        public int Codigo { get; set; }

        public List<string> Ingredientes { get; set; }

        public List<string> Sabores { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        public string Formato { get; set; }

        public string Tamanho { get; set; }

        public string Borda { get; set; }

        public string RecheioBorda { get; set; }

        public string Tipo { get; set; }

    }
}
