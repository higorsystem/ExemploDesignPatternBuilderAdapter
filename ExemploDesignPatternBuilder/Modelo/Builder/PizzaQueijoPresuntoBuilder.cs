using ExemploDesignPatternBuilder.Modelo.Builder.Interface;

namespace ExemploDesignPatternBuilder.Modelo.Builder
{
    public class PizzaQueijoPresuntoBuilder: IPizzaBuilder
    {
        public string ColocarMolho()
        {
            return "de tomate com molho branco";
        }

        public string ColocarRecheio()
        {
            return "de queijo, presunto e orégano.";
        }
    }
}