﻿using System;
using System.Collections.Generic; 
using Domain;

namespace JesusNS
{
    public class Jesus : IPlayable
    { 
        public Domain.Action Execute(IList<RoundResult> previousRoundResults, PlayerNumber playerNumber)
        {
            return Domain.Action.Cooperate;
        }
    }
}