using System;
using System.Collections.Generic;

namespace Cards
{
    public interface ITarget
    {
        TargetType TargetType { get; }
        IEnumerable<Guid> TargetIds { get; }
        int TargetCount { get; }
    }
}