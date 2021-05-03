using FactoryMethodPatern.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatern.Continents
{
    class Asia : Continent
    {
        public override void CreateContinent()
        {
            Animals.Add(new Panda());
            Animals.Add(new SlowLoris());
        }
    }
}
