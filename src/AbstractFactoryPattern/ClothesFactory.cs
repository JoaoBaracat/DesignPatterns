using AbstractFactoryPattern.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrousers();


    }
}
