using System.Collections.Generic;
using System.Linq;

namespace JogoGourmet.Core
{
    public class GameNodesManager : IGameNodesManager
    {
        private GameNode _currentNode;
        private GameNode _rootNode;

        public GameNode CurrentNode
        {
            get { return _currentNode; }
        }

        public GameNodesManager(GameNode rootNode)
        {
            _currentNode = rootNode;
            _rootNode = rootNode;
        }

        public void SetLeftNodeAsCurrent()
        {
            _currentNode = _currentNode = _currentNode.LeftNode;
        }
        
        public void SetRightNodeAsCurrent()
        {
            _currentNode = _currentNode.RightNode;
        }

        public void AddNode(GameNode node)
        {
            var addInFatherLeft = _currentNode.FatherNode.LeftNode == _currentNode;
            if (addInFatherLeft)
                _currentNode.FatherNode.LeftNode = node;
            else
                _currentNode.FatherNode.RightNode = node;

            node.RightNode = _currentNode;
        }

        public void SetRootAsCurrentNode()
        {
            _currentNode = _rootNode;
        }
    }
}