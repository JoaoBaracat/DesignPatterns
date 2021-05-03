using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatern
{
    abstract class Continent
    {
        private List<Animal> _animals = new List<Animal>();

        protected Continent()
        {
            CreateContinent();
        }

        public List<Animal> Animals => _animals;

        public abstract void CreateContinent();
    }
}
