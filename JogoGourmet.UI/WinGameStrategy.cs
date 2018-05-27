using System;
using JogoGourmet.Core;
using JogoGourmet.UI.Screens;

namespace JogoGourmet.UI
{
    public class WinGameStrategy : INextMoveStrategy
    {
        public void Move(IGame game)
        {
            var winnerForm = new WinnerForm();
            winnerForm.ShowDialog();
            game.Reset();
        }
    }
}
