using System;
using DesignPatternPlaybook.Decorator;
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
        public static void WriteIteratorDP()
        {
            var files = new FileIterator(@"C:\Users\verschui\Pictures","jpg");
            foreach (var file in files)
            {
                Console.WriteLine(file.FullName); 
            }
            

        }
    }
}
