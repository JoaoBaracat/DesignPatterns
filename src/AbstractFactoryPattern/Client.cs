using AbstractFactoryPattern.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;

        public Client(ClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();

        }

        public string DescribeYourClothes()
        {
            return $"Today  I'm dressed in: {_shirt.GetType().Name} and {_trousers.GetType().Name}";
        }
    }
}
