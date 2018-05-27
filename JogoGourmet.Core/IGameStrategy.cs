namespace JogoGourmet.Core
{
    public interface IGameStrategy
    {
        GameMove Execute(IGameNodesManager gameElementsManager);
    }
}