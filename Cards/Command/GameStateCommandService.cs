﻿using Cards.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Command
{
    public class GameStateCommandService : IGameStateCommandService
    {
        private readonly IPersistenceService PersistanceService;

        public GameStateCommandService(IPersistenceService persistanceService)
        {
            PersistanceService = persistanceService;
        }

        public void UpdateGameState(Guid gameStateId, IGameState gameState)
        {
            throw new NotImplementedException();
        }
    }
}
