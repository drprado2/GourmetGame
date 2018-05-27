using System.Collections.Generic;
using System.Linq;

namespace JogoGourmet.Core
{
    public class Game : IGame
    {
        private IGameInitializer _initializer;
        private IGameStrategy _strategy;
        private IDictionary<bool, IGameStrategy> _strategies;
        private IGameNodesManager _gameNodesManager;
        private GameMove _nextMove;
        
        public GameMove NextMove
        {
            get { return _nextMove; }
        }

        public string LabelCurrentNode { get { return _gameNodesManager.CurrentNode.Label; } }

        public Game(IGameNodesManager gameNodesManager)
        {
            _gameNodesManager = gameNodesManager;
            
            _strategies = new Dictionary<bool, IGameStrategy>()
            {
                {true, new UserSelectYesStrategy()},
                {false, new UserSelectNoStrategy()}
            };
        }

        public void Play(bool userResponse)
        {
            _nextMove = _strategies[userResponse].Execute(_gameNodesManager);
        }

        public void Start()
        {
            _gameNodesManager.SetRootAsCurrentNode();
            _nextMove = GameMove.PlayAgain;
        }

        public void Reset()
        {
            _nextMove = GameMove.ResetGame;
        }

        public void AddElement(NewGameNodeDto dto)
        {
            var gameElement = new GameNode(dto.ElementLabel);
            var masterGameElement = new GameNode(dto.ElementCharacteristic)
            {
                LeftNode = gameElement
            };
            
            _gameNodesManager.AddNode(masterGameElement);
        }
    }
}