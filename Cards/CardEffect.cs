using System;

namespace Cards
{
    [Serializable]
    public class CardEffect : ICardEffect
    {
        public Guid TargetId { get; }
        public Guid SourceId { get; }
        public EffectType EffectType { get; }
        public int EffectValue { get;  }
    }
}