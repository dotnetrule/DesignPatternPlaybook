using System;
using DesignPatternPlaybook.Decorator;

namespace DesignPatternPlaybook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WriteDecoratorDP();

            Console.ReadLine();
        }

        public static void WriteDecoratorDP()
        {
            var hat = new PremiumHat();
            Console.WriteLine(hat.getName());

            var goldenHat = new GoldenHat(hat);
            Console.WriteLine(goldenHat.getName());

            var ribonnedgoldenhat = new RibbonedHat(goldenHat);
            Console.WriteLine(ribonnedgoldenhat.getName()); 
        }
    }
}
