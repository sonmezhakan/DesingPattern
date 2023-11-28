using CA_AbstractFactory.Abstract;
using CA_AbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractFactory.ConcreteFactories
{
    public class ChaiFactory : IAbstractProductFactory
    {
        public IPackage Packaging()
        {
            return new ChaiConcrete();
        }

        public IPrice Price()
        {
            return new ChaiConcrete();
        }
    }
}
