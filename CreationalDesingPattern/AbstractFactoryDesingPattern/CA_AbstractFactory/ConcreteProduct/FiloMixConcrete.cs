using CA_AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractFactory.ConcreteProduct
{
    public class FiloMixConcrete:IPackage,IPrice
    {
        public void Packaging()
        {
            Console.WriteLine("Filo Mix Paketlendi!");
        }

        public void UnitPrice()
        {
            Console.WriteLine("Filo Mix Fiyatı Belirlendi!");
        }
    }
}
