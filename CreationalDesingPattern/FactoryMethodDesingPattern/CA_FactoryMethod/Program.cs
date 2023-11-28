using CA_FactoryMethod.Abstract;
using CA_FactoryMethod.FootballGame.Concrete;
using CA_FactoryMethod.Game.Abstract;

namespace CA_FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseFootballGame goalKeeperGame = new GoalKeeperGame();
            BaseFootballGame defenseGame = new DefenseGame();
            BaseFootballGame midFieldGame = new MidFieldGame();
            BaseFootballGame strikerGame = new StrikerGame();

            IFootballer goalKeeper = goalKeeperGame.Football();
            IFootballer defense = defenseGame.Football();
            IFootballer mid = midFieldGame.Football();
            IFootballer striker = strikerGame.Football();

            goalKeeper.Orta();
            defense.Dripling();
            mid.Dripling();
            mid.Orta();
            striker.Sut();

        }
    }
}