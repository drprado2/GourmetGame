using JogoGourmet.Core;
using System.Collections.Generic;

namespace JogoGourmet.UI
{
    public class MoveStrategyFactory
    {
        private readonly IDictionary<GameMove, INextMoveStrategy> _strategies;

        public MoveStrategyFactory()
        {
            _strategies = new Dictionary<GameMove, INextMoveStrategy>()
            {
                {GameMove.PlayAgain, new PlayAgainStrategy() },
                {GameMove.InputNewElement, new InputNewElementStrategy() },
                {GameMove.WinGame, new WinGameStrategy() }
            };
        }

        public INextMoveStrategy Resolve(GameMove move)
        {
            return _strategies[move];
        }
    }
}
