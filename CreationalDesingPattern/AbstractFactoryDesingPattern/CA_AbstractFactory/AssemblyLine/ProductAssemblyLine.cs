using CA_AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractFactory.AssemblyLine
{
    public class ProductAssemblyLine
    {
        private IAbstractProductFactory _productFactory;
        public ProductAssemblyLine(IAbstractProductFactory abstractProductFactory)
        {
            _productFactory = abstractProductFactory;
        }
        public void AssemblyProduct()
        {
            IPackage package = _productFactory.Packaging();
            IPrice price = _productFactory.Price();

            Console.WriteLine("ürün işlemleri başladı!");
            package.Packaging();
            price.UnitPrice();
        }
    }
}
