using JogoGourmet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.UI
{
    public interface INextMoveStrategy
    {
        void Move(IGame game);
    }
}
