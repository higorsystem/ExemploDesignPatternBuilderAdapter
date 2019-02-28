using System;

namespace ExemploDesignPatternAdapter.Modelo
{
    public class StringCustomizada
    {
        public string ConverteMaiusculas(string texto)
        {
            return texto.ToUpper();
        }

        public void MostrarTexto(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}