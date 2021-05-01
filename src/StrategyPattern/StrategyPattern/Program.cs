using StrategyPattern.TravelingStrategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelPlanner travelPlanner = new TravelPlanner();

            travelPlanner.SetTravelStrategy(new Plane());
            travelPlanner.Drive(1100);

            Console.ReadKey();
        }
    }
}
