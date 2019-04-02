﻿using Cards.DTO;
using Cards.Query;
using System;
using System.Collections.Generic;

namespace Cards.Persistance
{
    public interface IPersistanceService
    {
        List<CardInfo> GetHand();
        CardInfo GetCardPreview();
        Card GetCard(Guid id);
        IGameState GetGameState(Guid gameStateId);    
    }
}