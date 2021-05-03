using AbstractFactoryPattern.AbstractProducts;
using AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factories
{
    class ElegantClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new DressShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new SuitTrousers();
        }

    }
}
