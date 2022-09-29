using Uninove.Pizzaria.V3;

namespace Uninove.Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            PizzaV3 pizzaChefe = new PizzaV3("Pizza do Chefe", V3.TamanhoPizza.Broto);

            PizzaV3 pizzaFrango = new PizzaV3(".", TamanhoPizza.Broto);

            PizzaV3 pizzaChefe2 = new PizzaV3("Pizza do Chefe");

            //Quando a propriedade está ao lado esquerdo do sinal de igual =,
            //estamos realizando uma atribuição, ou seja,
            //estamos utilizando o operador set
            //pizzaFrango.Nome = "Frango";


            //Quando a propriedade está ao lado direito do sinal de igual =,
            //estamos realizando uma leitura, ou seja,
            //estamos utilizando o operador get
            txtNomePizza.Text = pizzaFrango.Nome;

            pizzaChefe.AlterarNome("", );



        }
    }
}