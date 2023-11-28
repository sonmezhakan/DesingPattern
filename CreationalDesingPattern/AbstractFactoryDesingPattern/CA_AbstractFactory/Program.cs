using CA_AbstractFactory.Abstract;
using CA_AbstractFactory.AssemblyLine;
using CA_AbstractFactory.ConcreteFactories;
using CA_AbstractFactory.ConcreteProduct;

namespace CA_AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAbstractProductFactory aliceMuttonFactory = new AliceMuttonFactory();
            ProductAssemblyLine aliceMuttonAssemblyLine = new ProductAssemblyLine(aliceMuttonFactory);
            aliceMuttonAssemblyLine.AssemblyProduct();

            IAbstractProductFactory chaiFactory = new ChaiFactory();
            ProductAssemblyLine chaiAssemblyLine = new ProductAssemblyLine(chaiFactory);
            chaiAssemblyLine.AssemblyProduct();

            IAbstractProductFactory FiloMixFactory = new FiloMixFactory();
            ProductAssemblyLine filoMixAssemblyLine = new ProductAssemblyLine(FiloMixFactory);
            filoMixAssemblyLine.AssemblyProduct();

            IAbstractProductFactory GeitostFactory = new GeitostFactory();
            ProductAssemblyLine geitostAssemblyLine = new ProductAssemblyLine(GeitostFactory);
            geitostAssemblyLine.AssemblyProduct();

            IAbstractProductFactory GenenShouyuFactory = new GenenShouyuFactory();
            ProductAssemblyLine genenShouyuAssemblyLine = new ProductAssemblyLine(GenenShouyuFactory);
            genenShouyuAssemblyLine.AssemblyProduct();

            IAbstractProductFactory KonbuFactory = new KonbuFactory();
            ProductAssemblyLine konbuAssemblyLine = new ProductAssemblyLine(KonbuFactory);
            konbuAssemblyLine.AssemblyProduct();

            IAbstractProductFactory PavlovaFactory = new PavlovaFactory();
            ProductAssemblyLine pavlovaAssemblyLine = new ProductAssemblyLine(PavlovaFactory);
            pavlovaAssemblyLine.AssemblyProduct();

            IAbstractProductFactory TofuFactory = new TofuFactory();
            ProductAssemblyLine tofuAssemblyLine = new ProductAssemblyLine(TofuFactory);
            tofuAssemblyLine.AssemblyProduct();
        }
    }
}