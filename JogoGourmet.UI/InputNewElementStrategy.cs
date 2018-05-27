using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoGourmet.Core;
using JogoGourmet.UI.Screens;

namespace JogoGourmet.UI
{
    public class InputNewElementStrategy : INextMoveStrategy
    {
        public void Move(IGame game)
        {
            var food = new FoodDto();
            var characteristic = new CharacteristicDto();

            var inputElementForm = new InputElementForm(food);
            inputElementForm.ShowDialog();

            var completeForm = new CompleteForm(characteristic, food.Name, game.LabelCurrentNode);
            completeForm.ShowDialog();

            var newElement = new NewGameNodeDto(characteristic.Name, food.Name);
            game.AddElement(newElement);
            game.Reset();
        }
    }
}
