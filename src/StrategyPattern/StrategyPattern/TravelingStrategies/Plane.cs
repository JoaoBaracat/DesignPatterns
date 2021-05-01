using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.TravelingStrategies
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            KilometerCost = 50;
        }

        public override decimal Drive(int kilometers)
        {
            if (kilometers > 1000)
            {
                KilometerCost = 15;
            }

            return kilometers * KilometerCost;
        }
    }
}
