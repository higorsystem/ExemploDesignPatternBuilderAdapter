using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploDesignPatternAdapter.Adapter.Interface;

namespace ExemploDesignPatternAdapter
{
    class Cliente
    {
        static void Main(string[] args)
        {
            IAlvo alvo = new Adapter.Adapter();
            alvo.MostrarTextoMaiusculo("Operação Adaptada!!!");

            Console.ReadKey();
        }
    }
}
