using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class TravelStrategy
    {
        public int KilometerCost;
        public abstract decimal Drive(int kilometers);
    }
}
