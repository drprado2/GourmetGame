using System.Collections.Generic;

namespace JogoGourmet.Core
{
    public interface IGame
    {
        void Play(bool userResponse);
        GameMove NextMove { get; }
        void AddElement(NewGameNodeDto dto);
        void Reset();
        string LabelCurrentNode { get; }
        void Start();
    }
}