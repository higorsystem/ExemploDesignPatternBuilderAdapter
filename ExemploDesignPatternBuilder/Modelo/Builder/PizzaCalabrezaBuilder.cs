using ExemploDesignPatternBuilder.Modelo.Builder.Interface;

namespace ExemploDesignPatternBuilder.Modelo.Builder
{
    public class PizzaCalabrezaBuilder : IPizzaBuilder
    {
        public string ColocarMolho()
        {
            return "de tomate";
        }

        public string ColocarRecheio()
        {
            return "de calabreza.";
        }
    }
}