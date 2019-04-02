using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Command
{
    public interface IGameStateCommandService
    {
        void UpdateGameState(Guid gameStateId, IGameState gameState);
    }
}
