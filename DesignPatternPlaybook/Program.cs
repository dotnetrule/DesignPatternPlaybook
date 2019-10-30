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
            var Mp3s = new JpgIterator(@"C:\Users\verschui\Pictures");
            foreach (var mp3 in Mp3s)
            {
                Console.WriteLine(mp3.FullName); 
            }
            

        }
    }
}
