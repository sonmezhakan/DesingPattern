using CA_FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FactoryMethod.Game.Abstract
{
    public abstract class BaseFootballGame
    {
        public abstract IFootballer Football();
    }
}
