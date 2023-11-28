using CA_AbstractFactory.Abstract;

namespace CA_AbstractFactory.ConcreteProduct
{
    public class KonbuConcrete : IPackage, IPrice
    {
        public void Packaging()
        {
            Console.WriteLine("Konbu Paketlendi!");
        }

        public void UnitPrice()
        {
            Console.WriteLine("Konbu Fiyatı Belirlendi!");
        }
    }
}
