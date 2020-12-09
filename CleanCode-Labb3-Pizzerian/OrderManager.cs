﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public sealed class OrderManager
    {
        private static readonly OrderManager orderManagerInstance = new OrderManager();
        public static OrderManager OrderManagerInstance { get { return orderManagerInstance; } }
        
        static OrderManager() { }
        private OrderManager() { }

        public Order CurrentOrder { get { return currentOrder; } }
        private Order currentOrder;
    }
}