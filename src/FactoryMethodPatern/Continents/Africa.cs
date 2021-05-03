using FactoryMethodPatern.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatern.Continents
{
    class Africa : Continent
    {
        public override void CreateContinent()
        {
            Animals.Add(new Lion());
            Animals.Add(new Elephant());
        }
    }
}
