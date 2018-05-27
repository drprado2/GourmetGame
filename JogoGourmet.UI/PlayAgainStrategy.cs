using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoGourmet.Core;
using JogoGourmet.UI.Screens;

namespace JogoGourmet.UI
{
    public class PlayAgainStrategy : INextMoveStrategy
    {
        private bool _userResponse;

        public void Move(IGame game)
        {
            var questionResult = new QuestionResultDto();
            var questionForm = new QuestionForm(questionResult, game.LabelCurrentNode);
            questionForm.ShowDialog();
            game.Play(questionResult.Result);
        }
    }
}
