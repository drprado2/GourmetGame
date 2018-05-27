using System.Collections.Generic;

namespace JogoGourmet.Core
{
    public class DefaultGameInitializer : IGameInitializer 
    {
        public IGame Initialize()
        {
            var chocolateCakeOption = new GameNode("Bolo de Chocolate");
            var lasagnaOption = new GameNode("Lasanha");
            var pastaOption = new GameNode("Massa")
            {
                RightNode = chocolateCakeOption,
                LeftNode = lasagnaOption
            };
            var elementsManager = new GameNodesManager(pastaOption);
            return new Game(elementsManager);
        }
    }
}