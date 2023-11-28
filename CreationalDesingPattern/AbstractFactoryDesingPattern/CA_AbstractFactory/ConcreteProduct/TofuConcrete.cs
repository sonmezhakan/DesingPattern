using CA_AbstractFactory.Abstract;

namespace CA_AbstractFactory.ConcreteProduct
{
    public class TofuConcrete : IPackage, IPrice
    {
        public void Packaging()
        {
            Console.WriteLine("Tofu Paketlendi!");
        }

        public void UnitPrice()
        {
            Console.WriteLine("Tofu Fiyatı Belirlendi!");
        }
    }
}
