using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uninove.Pizzaria.V2
{
    internal class PizzaV2
    {
        public int Codigo { get; set; }

        public List<IngredienteReceita> Ingredientes { get; set; }

        public List<string> Sabores { get; set; }

        public string Nome { get; set; }

        public string Formato { get; set; }

        //Broto
        //Normal
        //Familia
        public TamanhoPizza Tamanho { get; set; }

        public BordaPizza Borda { get; set; }

        public string Tipo { get; set; }

    }

    public enum TamanhoPizza
    {
        Broto,
        Normal,
        Familia
    }

    public class IngredienteReceita
    {
        public string Nome { get; set; }

        public float Quantidade { get; set; }
        
        public string UnidadeMedida { get; set; }

        public string Marca { get; set; }
    }

    public class BordaPizza
    {
        public bool Recheada { get; set; }
        public List<IngredienteReceita> Ingredientes { get; set; }
    }
}
