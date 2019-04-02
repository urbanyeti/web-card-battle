using System;
using System.Collections.Generic;

namespace Cards
{
    public interface IGameState
    {
        Guid ActiveCardId { get; set; }
        List<IGameEvent> GameEvents { get; set; }
        
    }
}