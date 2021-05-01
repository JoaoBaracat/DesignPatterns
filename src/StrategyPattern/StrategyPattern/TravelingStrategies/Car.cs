using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.TravelingStrategies
{
    public class Car : TravelStrategy
    {
        public Car()
        {
            KilometerCost = 25;
        }

        public override decimal Drive(int kilometers)
        {
            return kilometers * KilometerCost;
        }
    }
}
