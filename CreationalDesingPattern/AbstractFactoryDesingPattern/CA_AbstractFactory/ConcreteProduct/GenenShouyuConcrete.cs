using CA_AbstractFactory.Abstract;

namespace CA_AbstractFactory.ConcreteProduct
{
    public class GenenShouyuConcrete : IPackage, IPrice
    {
        public void Packaging()
        {
            Console.WriteLine("Genen Shouyu Paketlendi!");
        }

        public void UnitPrice()
        {
            Console.WriteLine("Genen Shouyu Fiyatı Belirlendi!");
        }
    }
}
