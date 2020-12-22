using System;
using System.Collections.Generic;
using Core.Interfaces;
using Core.Handlers;
using Core;

namespace ConsoleAppHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            // The other part of the client code constructs the actual chain.
            var Milk = new  MilkHandler();
            var Sugar = new SugarHandler();
            var Coffee = new CoffeeHandler();

            Milk.SetNext(Sugar).SetNext(Coffee);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Chain: Milk > Sugar > Coffee\n");
            Context.ContextCode(Milk);
            Console.WriteLine();

            Console.WriteLine("Subchain: Sugar > Coffee\n");
            Context.ContextCode(Sugar);
           
        }
    }
}
