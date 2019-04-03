using Cards.DTO;
using Cards.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Query
{
    public class CardQueryService : ICardQueryService
    {
        private readonly IPersistenceService PersistenceService;

        public CardQueryService(IPersistenceService persistanceService)
        {
            PersistenceService = persistanceService;
        }

        public List<CardInfo> GetHand()
        {
            List<CardInfo> hand = PersistenceService.GetHand();
            return hand;
        }

        public CardInfo GetTargetPreview(Guid cardId, Guid targetId)
        {
            CardInfo preview = PersistenceService.GetCardPreview();
            return preview;
        }
    }
}
