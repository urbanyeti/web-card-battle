using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.DTO
{
    [Serializable]
    public class CardInfo
    {
        public Guid CardId { get; }
        public int HandPosition { get; }
        public Guid BaseCardId { get; }
        public CardType CardType { get; }
        public string Name { get; }
        public string Description { get; }
        public int Cost { get; }
    }
}
