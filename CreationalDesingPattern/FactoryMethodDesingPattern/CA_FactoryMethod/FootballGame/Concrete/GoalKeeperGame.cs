using CA_FactoryMethod.Abstract;
using CA_FactoryMethod.Entity;
using CA_FactoryMethod.Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FactoryMethod.FootballGame.Concrete
{
    public class GoalKeeperGame : BaseFootballGame
    {
        public override IFootballer Football()
        {
            return new GoalKeeper();
        }
    }
}
