using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RLS.Game.Gameplay
{
    public class Order
    {
        private List<OrderEntry> _entries = new List<OrderEntry>();

        public void AddEntry(OrderEntry entry)
        {
            _entries.Add(entry);
        }

        public List<OrderEntry> GetEntries() {
            return _entries;
        }

        public bool IsDone()
        {
            bool done = true;
            foreach (OrderEntry entry in _entries)
            {
                if (!entry.IsDone()) {
                    done = false;
                }
            }
            return done;
        }
    }
}

