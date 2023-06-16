using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RLS.Game.Gameplay
{
    public class OrderEntry
    {
        public int RequestedCount;
        public int FulfilledCount;
        public ProductionItemType Item;

        public bool IsDone()
        {
            return RequestedCount == FulfilledCount;
        }

        public int Add(int count)
        {
            FulfilledCount += count;
            return FulfilledCount;
        }
    }
}

