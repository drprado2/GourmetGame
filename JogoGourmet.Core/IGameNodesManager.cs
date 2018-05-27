namespace JogoGourmet.Core
{
    public interface IGameNodesManager
    {
        GameNode CurrentNode { get; }

        void SetLeftNodeAsCurrent();

        void SetRightNodeAsCurrent();

        void AddNode(GameNode element);
        
        void SetRootAsCurrentNode();
    }
}