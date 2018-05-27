namespace JogoGourmet.Core
{
    public class UserSelectNoStrategy : IGameStrategy
    {
        public GameMove Execute(IGameNodesManager gameElementsManager)
        {
            if (gameElementsManager.CurrentNode.RightNode != null)
            {
                gameElementsManager.SetRightNodeAsCurrent();
                return GameMove.PlayAgain;
            }

            return GameMove.InputNewElement;
        }
    }
}