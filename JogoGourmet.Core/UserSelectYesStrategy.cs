namespace JogoGourmet.Core
{
    public class UserSelectYesStrategy : IGameStrategy
    {
        public GameMove Execute(IGameNodesManager gameElementsManager)
        {
            if (gameElementsManager.CurrentNode.LeftNode != null)
            {
                gameElementsManager.SetLeftNodeAsCurrent();
                return GameMove.PlayAgain;
            }

            return GameMove.WinGame;
        }
    }
}