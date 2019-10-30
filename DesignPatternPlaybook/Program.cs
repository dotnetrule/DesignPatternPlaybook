using System;
using DesignPatternPlaybook.Decorator;
using DesignPatternPlaybook.Factory;
using DesignPatternPlaybook.Iterator;

namespace DesignPatternPlaybook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WriteDecoratorDP();
            WriteIteratorDP();
            WriteFactoryDP();
            Console.ReadLine();
        }

        public static void WriteDecoratorDP()
        {
            Console.WriteLine("/// Decorator DP");
            var hat = new PremiumHat();
            Console.WriteLine(hat.getName());

            var goldenHat = new GoldenHat(hat);
            Console.WriteLine(goldenHat.getName());

            var ribonnedgoldenhat = new RibbonedHat(goldenHat);
            Console.WriteLine(ribonnedgoldenhat.getName()); 

        }
        public static void WriteIteratorDP()
        {
            Console.WriteLine("/// Iterator DP");
            var files = new FileIterator(@"C:\Users\verschui\Pictures","jpg");
            foreach (var file in files)
            {
                Console.WriteLine(file.FullName); 
            }
        }


        public static void WriteFactoryDP()
        {
            Console.WriteLine("/// FACTORY DP");

            var repo = RepositoryFactory.GetRepository("Sql");
            Console.WriteLine(repo.GetType().ToString());
        }
    }
}
