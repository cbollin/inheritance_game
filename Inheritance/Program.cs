using Inheritance.Models;

namespace Inheritance
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var humanFighter = new HumanFighter();
            var enemyRat = new Rat();

            Battle.BeginCombat(humanFighter, enemyRat);
        }
    }
}
