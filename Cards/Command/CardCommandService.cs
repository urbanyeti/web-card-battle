using Cards.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Command
{
    public class CardCommandService : ICardCommandService
    {
        private readonly IPersistanceService PersistanceService;
        private readonly IGameStateCommandService GameStateService;

        public CardCommandService(IPersistanceService persistanceService, IGameStateCommandService gameStateService)
        {
            PersistanceService = persistanceService;
            GameStateService = gameStateService;
        }

        public void ActivateCard(Guid gameStateId, Guid cardId)
        {
            IGameState gameState = PersistanceService.GetGameState(gameStateId);
            Card activeCard = PersistanceService.GetCard(cardId);

            gameState.ActiveCardId = activeCard.CardId;
            gameState.GameEvents.AddRange(activeCard.CardEvents);
            GameStateService.UpdateGameState(gameStateId, gameState);
        }

        public void SelectTarget(Guid sourceId, ITarget target)
        {

        }
    }
}
