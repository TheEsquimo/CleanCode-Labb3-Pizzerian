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
                currentOrder.Content.Remove(ordable);
        }

        public void PlaceOrder()
        {
            currentOrder.Status = Order.OrderStatus.Active;
            orders.Add(currentOrder);
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
                activeOrders += GetOrderString(order) + "\n";
            }
            return activeOrders;
        }

        public string GetOrderString(Order order)
        {
            string orderString = "";
            orderString += $"ID: {order.ID}\n";
            orderString += GetOrderContentString(order);
            orderString += $"Total Cost: {order.TotalCost}";
            return orderString;
        }

        public string GetOrderContentString(Order order)
        {
            string contentString = "";
            var pizzas = order.Content.Where(item => item is Pizza).ToList();
            foreach(Pizza pizza in pizzas)
            {
                contentString += PizzaToString(pizza);
            }
            var drinks = order.Content.Where(item => item is Drink).ToList();
            foreach (Drink drink in drinks)
            {
                contentString += DrinkToString(drink);
            }
            var extras = order.Content.Where(item => item is Topping).ToList();
            foreach (Topping extra in extras)
            {
                contentString += ToppingToString(extra);
            }
            return contentString;
        }

        private void CreateNewOrder()
        {
            currentOrder = new Order();
            currentOrder.Content = new List<IOrdable>();
        }

        public string ToppingToString(Topping topping)
        {
            string toppingString = "";
            toppingString += (topping.Name + ":");
            toppingString += (" - " + topping.Cost + "kr\n");
            return toppingString;
        }

        public string DrinkToString(Drink drink)
        {
            string drinkString = "";
            drinkString += (drink.Name + ":");
            drinkString += (" - " + drink.Cost + "kr\n");
            return drinkString;
        }

        public string PizzaToString(Pizza pizza)
        {
            string pizzaString = "";
            pizzaString += (pizza.Name + ":");
            foreach (Topping topping in pizza.Toppings)
            {
                pizzaString += (" " + topping.Name + ",");
            }
            pizzaString += (" - " + pizza.Cost + "kr\n");
            return pizzaString;
        }
    }
}
