using ExemploDesignPatternBuilder.Modelo.Builder.Interface;

namespace ExemploDesignPatternBuilder.Modelo
{
    public class Pizza
    {
        public string Molho { get; set; }

        public string Recheio { get; set; }

        public override string ToString()
        {
            return "Pizza com molho: " + this.Molho + " e recheio " + this.Recheio;
        }
    }
}