using System;
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
            if (currentOrder == null)
                CreateNewOrder();
            currentOrder.Content.Add(ordable);
        }


        public void RemoveItemFromOrder(IOrdable ordable)
        {
            if (currentOrder != null)
                currentOrder.Content.Remove(ordable);
        }

        //public string GetOrderContent()
        //{
        //    foreach (Pizza pizza in menu.GetPizzas())
        //    {
        //        Console.Write(pizza.Name + ":");
        //        foreach (Topping topping in pizza.Toppings)
        //        {
        //            Console.Write(" " + topping.Name + ",");
        //        }
        //        Console.Write(" - " + pizza.Cost + "kr\n");
        //    }
        //}

        private void CreateNewOrder()
        {
            currentOrder = new Order();
            currentOrder.Content = new List<IOrdable>();
        }
    }
}
