using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.TravelingStrategies
{
    public class Bus : TravelStrategy
    {
        public Bus()
        {
            KilometerCost = 20;
        }
        public override decimal Drive(int kilometers)
        {
            return kilometers * KilometerCost;
        }
    }
}
