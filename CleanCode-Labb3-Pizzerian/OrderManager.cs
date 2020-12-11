using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public sealed class OrderManager
    {
        private static readonly OrderManager orderManagerInstance = new OrderManager();
        public static OrderManager OrderManagerInstance { get { return orderManagerInstance; } }
        
        static OrderManager() { }
        private OrderManager() 
        {
            orders = new List<Order>();
        }

        public Order CurrentOrder { get { return currentOrder; } }
        public List<Order> Orders { get { return orders; } }
        private Order currentOrder;
        private List<Order> orders;
        private int orderIdCounter = 1;

        public double CalculateOrderTotalCost(Order order)
        {
            double cost = 0;
            foreach (IOrdable ordable in order.Content)
            {
                cost += ordable.Cost;
            }
            return cost;
        }

        public void AddItemToOrder(IOrdable ordable)
        {
            if (currentOrder == null || currentOrder.Content == null)
                CreateNewOrder();
            if (CanAddItemToOrder(ordable))
                currentOrder.Content.Add(ordable);
        }

        public void RemoveItemFromOrder(IOrdable ordable)
        {
            if (currentOrder != null)
            {
                currentOrder.Content.Remove(ordable);
            }
        }

        public Order PlaceOrder()
        {
            Order thisOrder = null;
            if (currentOrder != null && currentOrder.Content.Count > 0)
            {
                bool containsTopping = currentOrder.Content.OfType<Topping>().Any();
                bool containsPizza = currentOrder.Content.OfType<Pizza>().Any();
                if (containsPizza || !containsTopping)
                {
                    currentOrder.TotalCost = CalculateOrderTotalCost(currentOrder);
                    currentOrder.Status = Order.OrderStatus.Active;
                    orders.Add(currentOrder);
                    thisOrder = currentOrder;
                }
                ClearOrder();
            }
            return thisOrder;
        }

        public void ClearOrder()
        {
            currentOrder = null;
        }

        public void SetOrderStatus(Order order, Order.OrderStatus status)
        {
            order.Status = status;
        }

        private bool CanAddItemToOrder(IOrdable ordable)
        {
            bool canAddItem = true;
            if (ordable is Topping && !currentOrder.Content.Where(item => item is Pizza).Any())
                canAddItem = false;
            return canAddItem;
        }

        public string GetActiveOrders()
        {
            string activeOrders = "";
            foreach (Order order in orders)
            {
                activeOrders += GetOrderString(order) + "\n\n";
            }
            return activeOrders;
        }

        public string GetOrderString(Order order)
        {
            string orderString = "";
            if (order != null && order.Content.Count > 0)
            {
                orderString += $"ID: {order.Id}\n";
                orderString += GetOrderContentString(order);
                orderString += $"Total Cost: {order.TotalCost}";
            }
            return orderString;
        }

        public string GetOrderContentString(Order order)
        {
            string contentString = "";
            if (order != null && order.Content.Count > 0)
            {
                var pizzas = order.Content.Where(item => item is Pizza).ToList();
                foreach(Pizza pizza in pizzas)
                {
                    contentString += OrdablesToString.OrdableToString(pizza);
                }
                var drinks = order.Content.Where(item => item is Drink).ToList();
                foreach (Drink drink in drinks)
                {
                    contentString += OrdablesToString.OrdableToString(drink);
                }
                var extras = order.Content.Where(item => item is Topping).ToList();
                foreach (Topping extra in extras)
                {
                    contentString += OrdablesToString.OrdableToString(extra);
                }
            }
            return contentString;
        }

        private void CreateNewOrder()
        {
            currentOrder = new Order();
            currentOrder.Id = orderIdCounter;
            orderIdCounter++;
            currentOrder.Content = new List<IOrdable>();
        }
    }
}
