using System;

namespace Cards
{
    [Serializable]
    public class CardAction : ICardAction
    {
        public int Version { get; } = 1;
        public Guid TargetId { get; }
        public Guid SourceId { get; }
        public int? Damage { get; }
        public int? Healing { get; }
        public ICardEffect Effects { get; }
        public string Message { get; }
        public override string ToString()
        {
            return $"Damage: {Damage} | Healing: {Healing} | Effects: {Effects}";
        }

    }
}