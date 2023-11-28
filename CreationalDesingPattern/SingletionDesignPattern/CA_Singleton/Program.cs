using CA_Singleton.Data;

namespace CA_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductData productData = ProductData.Instance;
        }
    }
}