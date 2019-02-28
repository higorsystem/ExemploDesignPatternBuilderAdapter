using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploDesignPatternBuilder.Modelo;
using ExemploDesignPatternBuilder.Modelo.Builder;
using ExemploDesignPatternBuilder.Modelo.Builder.Interface;

namespace ExemploDesignPatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzaiolo pizzaiolo = new Pizzaiolo();
            IPizzaBuilder pizzaCalabrezaBuilder = new PizzaCalabrezaBuilder();
            IPizzaBuilder pizzaQueijoPresuntoBuilder = new PizzaQueijoPresuntoBuilder();

            pizzaiolo.PizzaBuilder = pizzaCalabrezaBuilder;
            Pizza p1 = pizzaiolo.PrepararPizza();

            Console.WriteLine("Pizza 01: " + p1);

            pizzaiolo.PizzaBuilder = pizzaQueijoPresuntoBuilder;
            Pizza p2 = pizzaiolo.PrepararPizza();

            Console.WriteLine("Pizza 02: " + p2);

            Console.ReadKey();
        }
    }
}
