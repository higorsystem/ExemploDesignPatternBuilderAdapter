using ExemploDesignPatternAdapter.Adapter.Interface;
using ExemploDesignPatternAdapter.Modelo;

namespace ExemploDesignPatternAdapter.Adapter
{
    public class Adapter : StringCustomizada, IAlvo
    {
        public void MostrarTextoMaiusculo(string texto)
        {
            MostrarTexto(ConverteMaiusculas(texto));
        }
    }
}