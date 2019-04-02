using Cards.DTO;
using Cards.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Query
{
    public class CardQueryService : ICardQueryService
    {
        private readonly IPersistanceService PersistanceService;

        public CardQueryService(IPersistanceService persistanceService)
        {
            PersistanceService = persistanceService;
        }

        public List<CardInfo> GetHand()
        {
            List<CardInfo> hand = PersistanceService.GetHand();
            return hand;
        }

        public CardInfo GetTargetPreview(Guid cardId, Guid targetId)
        {
            CardInfo preview = PersistanceService.GetCardPreview();
            return preview;
        }
    }
}
