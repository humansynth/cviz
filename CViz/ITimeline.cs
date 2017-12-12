﻿using System;
using CViz.Timeline.Triggers;
using StilSoft.CasparCG.AmcpClient;

namespace CViz
{
    interface ITimeline
    {
        AmcpConnection Client { get; }
        int ChannelNumber { get; }

        void SetLayerState(int layerId, LayerState state);
        LayerState GetLayerState(int layerId);
        
        string GetParameterValue(string fieldName, bool escape);

        void AddTrigger(ITrigger t);
        void RemoveAllTriggers(Predicate<ITrigger> predicate);
    }
}