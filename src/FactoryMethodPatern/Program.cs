using FactoryMethodPatern.Continents;
using System;

namespace FactoryMethodPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            Continent[] continents = new Continent[2];

            continents[0] = new Africa();
            continents[1] = new Asia();

            foreach (Continent continent in continents)
            {
                Console.WriteLine(continent.GetType().Name + ":");

                foreach (Animal animal in continent.Animals)
                {
                    Console.WriteLine(" " + animal.GetType().Name);
                }

            }

            Console.ReadKey();
        }
    }
}
