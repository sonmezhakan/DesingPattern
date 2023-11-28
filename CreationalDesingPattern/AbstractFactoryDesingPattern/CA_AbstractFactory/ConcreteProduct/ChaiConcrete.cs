using CA_AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractFactory.ConcreteProduct
{
    public class ChaiConcrete : IPackage, IPrice
    {
        public void Packaging()
        {
            Console.WriteLine("Chai Paketlendi!");
        }

        public void UnitPrice()
        {
            Console.WriteLine("Chai Fiyatı Belirlendi!");
        }
    }
}
