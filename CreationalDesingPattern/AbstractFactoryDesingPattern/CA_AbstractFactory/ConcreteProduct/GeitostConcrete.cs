using CA_AbstractFactory.Abstract;

namespace CA_AbstractFactory.ConcreteProduct
{
    public class GeitostConcrete : IPackage, IPrice
    {
        public void Packaging()
        {
            Console.WriteLine("Geitost Paketlendi!");
        }

        public void UnitPrice()
        {
            Console.WriteLine("Geitost Fiyatı Belirlendi!");
        }
    }
}
