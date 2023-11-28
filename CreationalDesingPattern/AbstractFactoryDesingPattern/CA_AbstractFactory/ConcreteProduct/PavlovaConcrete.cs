using CA_AbstractFactory.Abstract;

namespace CA_AbstractFactory.ConcreteProduct
{
    public class PavlovaConcrete : IPackage, IPrice
    {
        public void Packaging()
        {
            Console.WriteLine("Pavlova Paketlendi!");
        }

        public void UnitPrice()
        {
            Console.WriteLine("Pavlova Fiyatı Belirlendi!");
        }
    }
}
