using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Query
{
    public interface IGameStateQueryService
    {
        QueryResponse<IGameEvent> GetNextGameEvent(Guid gameStateId);
    }
}
