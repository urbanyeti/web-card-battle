using System;
using System.Collections.Generic;

namespace Cards
{
    public abstract class Card : ICard
    {
        public Guid Id;
        public Guid CardId;
        public string Description;
        public int Value;

        public CardAction Action;
        public List<CardEvent> CardEvents;
    }
}
