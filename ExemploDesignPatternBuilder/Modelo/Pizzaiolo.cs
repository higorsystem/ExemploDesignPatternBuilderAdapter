using ExemploDesignPatternBuilder.Modelo.Builder.Interface;

namespace ExemploDesignPatternBuilder.Modelo
{
    public class Pizzaiolo
    {
        public IPizzaBuilder PizzaBuilder { get; set; }

        public Pizza PrepararPizza()
        {
            var pizza = new Pizza();
            pizza.Recheio = PizzaBuilder.ColocarRecheio();
            pizza.Molho = PizzaBuilder.ColocarRecheio();
            return pizza;
        }
    }
}