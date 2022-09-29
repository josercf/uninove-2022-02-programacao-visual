using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uninove.Pizzaria.V3
{
    /// <summary>
    /// Classe pizza
    /// </summary>
    internal class PizzaV3
    {

        //public      - acessível a todos que enxergam a classe
        //internal    - acesível apenas dentro do mesmo namespace 
        //protected   - acessível apenas na classe e nas classes que dela herdam
        //private     - acessível apenas dentro da classe

        /// <summary>
        /// Método contstruto da classe pizza V3. 
        /// Cria-se uma instancia da classe com o tamanho Normal
        /// </summary>
        /// <param name="nome">Nome da pizza</param>
        internal PizzaV3(string nome) :
            this(nome, TamanhoPizza.Normal)
        {
           
        }

        /// <summary>
        /// Método contstruto da classe pizza V3. 
        /// Cria-se uma instancia da classe
        /// </summary>
        /// <param name="nome">Nome da pizza</param>
        /// <param name="tamanho">Tamanho da pizza</param>
        internal PizzaV3(string nome, TamanhoPizza tamanho)
        {
            Nome = nome;
            Tamanho = tamanho;
        }

        public void AlterarNome(string nome)
        {
            AlterarNome(nome, string.Empty);
        }

        public void AlterarNome(string nome, string formato = "")
        {
            Nome = nome;
            Formato = formato;
        }


        public int Codigo { get; set; }

        public List<IngredienteReceita> Ingredientes { get; set; }

        public List<string> Sabores { get; set; }

        public string Nome { get; private set; }

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
