using CA_AbstractFactory.Abstract;
using CA_AbstractFactory.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractFactory.ConcreteProduct
{
    public class AliceMuttonConcrete : IPackage,IPrice
    {
        public void Packaging()
        {
            Console.WriteLine("Alica Mutton Paketlendi!");
        }

        public void UnitPrice()
        {
            Console.WriteLine("Alica Mutton Fiyatı Belirlendi!");
        }
    }
}
