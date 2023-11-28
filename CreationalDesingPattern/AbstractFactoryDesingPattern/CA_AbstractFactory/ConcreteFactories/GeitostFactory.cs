﻿using CA_AbstractFactory.Abstract;
using CA_AbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractFactory.ConcreteFactories
{
    public class GeitostFactory : IAbstractProductFactory
    {
        public IPackage Packaging()
        {
            return new GeitostConcrete();
        }

        public IPrice Price()
        {
            return new GeitostConcrete();
        }
    }
}
