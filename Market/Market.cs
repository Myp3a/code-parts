using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RLS.Game.Gameplay
{
    public class Market
    {
        private List<Order> _orders;

        public void AddOrder(Order order) { 
            _orders.Add(order); 
        }

        public void RemoveOrder(Order order)
        {
            _orders.Remove(order);
        }

        public List<Order> GetOrders()
        {
            return _orders;
        }
    }

}
