using Cards.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards.Query
{
    public class GameStateQueryService : IGameStateQueryService
    {
        private readonly IPersistenceService PersistenceService;

        public GameStateQueryService(IPersistenceService persistanceService)
        {
            PersistenceService = persistanceService;
        }

        public QueryResponse<IGameEvent> GetNextGameEvent(Guid gameStateId)
        {
            var response = new QueryResponse<IGameEvent>();
            IGameState gameState = PersistenceService.GetGameState(gameStateId);

            IGameEvent gameEvent = gameState.GameEvents?.ElementAtOrDefault(0);
            if (gameEvent != null)
            {
                response.Status = QueryStatus.OK;
                response.Result = gameEvent;
            }
            else
            {
                response.Status = QueryStatus.NotFound;
            }

            return response;
        }
    }
}
