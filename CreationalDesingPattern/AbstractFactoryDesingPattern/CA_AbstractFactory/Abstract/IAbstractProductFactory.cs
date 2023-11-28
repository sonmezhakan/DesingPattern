using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractFactory.Abstract
{
    public interface IAbstractProductFactory
    {
        IPackage Packaging();
        IPrice Price();
    }
}
