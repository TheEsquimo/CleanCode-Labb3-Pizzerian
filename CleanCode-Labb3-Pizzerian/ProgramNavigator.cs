using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public sealed class ProgramNavigator
    {
        public static ProgramNavigator ProgramNavigatorInstance { get { return programNavigatorInstance; } }
        public string UserInput { get { return userInput; } }
        public Menu Menu { get { return menu; } }

        private static readonly ProgramNavigator programNavigatorInstance = new ProgramNavigator();
        private string userInput;
        private OrderManager orderManager = OrderManager.OrderManagerInstance;
        private Menu menu;

        static ProgramNavigator() { }
        private ProgramNavigator() { }

        public void StartProgram(Menu menu)
        {
            this.menu = menu;
            while (true)
            {
                MainMenu();
            }
        }

        string GetUserInput(params string[] validInput)
        {
            string userInput = "";
            while (!validInput.Contains(userInput) || validInput.Length == 0)
            {
                try
                {
                    userInput = Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return userInput;
        }

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1: Make Order");
            Console.WriteLine("2: Set Order Status");
            userInput = GetUserInput("1", "2", "3");
            switch (UserInput)
            {
                case "1":
                    Console.Clear();
                    OrderMenu();
                    break;

                case "2":
                    Console.Clear();
                    SetOrderStatusMenu();
                    break;
            }
        }

        private void OrderMenu()
        {
            Console.Clear();
            PrintMenu();
            PrintCurrentOrder();
            Console.WriteLine("1: Add Item to Order");
            Console.WriteLine("2: Remove Item from Order");
            Console.WriteLine("3: Clear Order");
            Console.WriteLine("4: Place Order");
            Console.WriteLine("5: Back to Main Menu");
            userInput = GetUserInput("1", "2", "3", "4", "5");
            switch (UserInput)
            {
                case "1":
                    Console.Clear();
                    AddItemToOrder();
                    break;

                case "2":
                    Console.Clear();
                    RemoveItemFromOrder();
                    break;

                case "3":
                    Console.Clear();
                    ClearOrder();
                    break;

                case "4":
                    Console.Clear();
                    PlaceOrder();
                    break;
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("=====ORDER MENU=====");
            string menuString = "";
            foreach (IOrdable ordable in menu.Ordables)
                menuString += OrdablesToString.OrdableToString(ordable);
            Console.WriteLine(menuString);
        }

        private void PrintCurrentOrder()
        {
            Console.WriteLine("=====CURRENT ORDER=====");
            Console.WriteLine(orderManager.GetOrderContentString(orderManager.CurrentOrder));
        }

        private void PrintActiveOrders()
        {
            Console.WriteLine("=====ORDERS=====");
            Console.WriteLine(orderManager.GetActiveOrders());
            Console.ReadKey();
        }

        private void AddItemToOrder()
        {
            PrintMenu();
            PrintCurrentOrder();
            Console.WriteLine("Enter ID to add corresponding item");
            List<string> validInput = new List<string>();
            for (int i = 1; i <= menu.Ordables.Count; i++)
            {
                validInput.Add(i.ToString());
            }
            userInput = GetUserInput(validInput.ToArray());

            IOrdable chosenOrdable = menu.Ordables.
                Where(ordable => ordable.Id == int.Parse(userInput)).
                First();

            orderManager.AddItemToOrder(chosenOrdable);
            OrderMenu();
        }

        private void RemoveItemFromOrder()
        {
            if (orderManager.CurrentOrder != null && orderManager.CurrentOrder.Content.Count > 0)
            {
                PrintCurrentOrder();
                Console.WriteLine("Enter ID to remove corresponding item");
                List<string> validInput = new List<string>();
                foreach (IOrdable ordable in orderManager.CurrentOrder.Content)
                {
                    validInput.Add(ordable.Id.ToString());
                }
                userInput = GetUserInput(validInput.ToArray());

                IOrdable chosenOrdable = menu.Ordables.
                    Where(ordable => ordable.Id == int.Parse(userInput)).
                    First();

                orderManager.RemoveItemFromOrder(chosenOrdable);
            }
            OrderMenu();
        }

        private void ClearOrder()
        {
            orderManager.ClearOrder();
        }

        private void PlaceOrder()
        {
            Order placedOrder = orderManager.PlaceOrder();
            if (placedOrder != null)
            {
                Console.WriteLine("=====ORDER SUMMARY=====");
                Console.WriteLine(orderManager.GetOrderString(placedOrder));
            }
            Console.ReadKey();
        }

        private void SetOrderStatusMenu()
        {
            if (orderManager.Orders != null && orderManager.Orders.Count > 0)
            {
                Order[] activeOrders = orderManager.Orders.
                    Where(order => order.Status == Order.OrderStatus.Active).ToArray();

                if (activeOrders.Length > 0)
                {
                    Console.WriteLine("=====CHOOSE ORDER TO MODIFY=====");
                    PrintActiveOrders();
                    Console.WriteLine("Enter ID to modify corresponding order's status");

                    List<string> validInput = new List<string>();
                    foreach (Order order in activeOrders)
                    {
                        validInput.Add(order.Id.ToString());
                    }
                    userInput = GetUserInput(validInput.ToArray());

                    Order chosenOrder = activeOrders.
                        Where(order => order.Id == int.Parse(userInput)).
                        First();

                    SetOrderStatus(chosenOrder);
                }
            }
        }

        private void SetOrderStatus(Order chosenOrder)
        {
            Console.WriteLine("=====SET ORDER STATUS=====");
            Console.WriteLine("1: Set Order to Completed");
            Console.WriteLine("2: Set Order to Cancelled");
            Console.WriteLine("3: Back to Main Menu");

            userInput = GetUserInput("1", "2", "3");
            switch (userInput)
            {
                case "1":
                    orderManager.SetOrderStatus(chosenOrder, Order.OrderStatus.Completed);
                    break;

                case "2":
                    orderManager.SetOrderStatus(chosenOrder, Order.OrderStatus.Canceled);
                    break;
            }
        }
    }
}
