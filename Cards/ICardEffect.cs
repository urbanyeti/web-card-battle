using System;

namespace Cards
{
    public interface ICardEffect
    {
        Guid TargetId { get; }
        Guid SourceId { get; }
        EffectType EffectType { get; }
        int EffectValue { get; }
    }
}