using JogoGourmet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.UI
{
    public class GameManager : IGameManager
    {
        private readonly IGame _game;
        private readonly MoveStrategyFactory _strategyFactory;

        public GameManager()
        {
            var gameInitializer = new DefaultGameInitializer();
            _game = gameInitializer.Initialize();
            _strategyFactory = new MoveStrategyFactory();
        }

        public void StartGame()
        {
            _game.Start();
            PlayNextMove();
        }

        public void PlayNextMove()
        {
            _strategyFactory.Resolve(_game.NextMove).Move(_game);

            if(_game.NextMove != GameMove.ResetGame)
                PlayNextMove();

            _game.Reset();
        }
    }
}
